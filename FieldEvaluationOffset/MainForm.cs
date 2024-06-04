using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Timers;
using System.IO.Ports;

namespace FieldEvaluationOffset
{
    public partial class MainForm : Form
    {
        private IonPlanSetup m_plan;
        private Course m_course;
        private Offset m_offset;
        private Offset oppisiteOffset;
        private OffsetManager om;
        private Patient m_patient;
        private DateTime start;
        private string felMsg;
        private bool FinishClock;
        private int heltal;
        private readonly System.Timers.Timer t = new System.Timers.Timer(1000);
        static UIListener tba = null;
        string dubbelField;

        public MainForm(IonPlanSetup plan, Patient patient)
        {
            this.m_plan = plan;
            this.m_course = plan.Course;
            this.m_patient = patient;
            FinishClock = true;
            m_patient.BeginModifications();

            InitializeComponent();
            System.Windows.Forms.Application.EnableVisualStyles();
            InitializeGUI();
            ClockFinish.Text = string.Empty;
        }
        private void InitializeGUI()
        {
            felMsg = "";
            lblProgress.Text = "";
            foreach (IonBeam beam in m_plan.Beams)
            {
                cbFieldID.Items.Add(beam);
            }
            cbFieldID.SelectedIndex = 0;
            om = new OffsetManager();
            m_offset = new Offset();

        }
        private void UpdateList()
        {
            lbListOfOffsets.Items.Clear();
            foreach (var offset in om.ListOfOffsets)
                lbListOfOffsets.Items.Add(offset.ToString());
        }
        private void UpdateProgressBar(int n)
        {
            lblProgress.Text = (n) + "/" + om.ListOfOffsets.Count;
            if (n == om.ListOfOffsets.Count)
                pbDoseCalculations.Value = 100;
            else
                pbDoseCalculations.Value = n * heltal;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            worker.WorkerReportsProgress = true;
            for (int i = 0; i < 100; i++)
            {
                worker.ReportProgress(i);
            }
        }
        private void TimeEstimation(DateTime start)
        {
            DateTime end = DateTime.Now;
            TimeSpan timeDiff = end - start;

            timeDiff = TimeSpan.FromTicks(timeDiff.Ticks * (om.ListOfOffsets.Count - 1));
            DateTime answer = end.Add(timeDiff);
            if (this.ClockFinish.InvokeRequired)
            {
                this.ClockFinish.BeginInvoke((MethodInvoker)delegate () { this.ClockFinish.Text = answer.ToString("HH\\:mm"); ; });
            }
            else
            {
                this.ClockFinish.Text = answer.ToString("HH\\:mm"); ;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbDoseCalculations.Value = e.ProgressPercentage;
        }
        
        private bool CheckForID(Course course, string ID)
        {
            bool ok = true;
            foreach (IonPlanSetup plan in course.IonPlanSetups)
            {
                if (plan.Id.Equals(ID))
                    ok = false;
            }
            return ok;
        }
        private IonPlanSetup ModifyParameters(IonPlanSetup ionPlan, Offset offset)
        {
            IonBeamParameters parameters = ionPlan.IonBeams.FirstOrDefault(ionbeam => ionbeam.Id.Equals(offset.FieldID)).GetEditableParameters();
            VVector vVector = ionPlan.IonBeams.FirstOrDefault(ionbeam => ionbeam.Id.Equals(offset.FieldID)).IsocenterPosition;
            vVector = offset.correctOffset(vVector);
            parameters.Isocenter = vVector;
            ionPlan.IonBeams.FirstOrDefault(ionbeam => ionbeam.Id.Equals(offset.FieldID)).ApplyParameters(parameters);
            return ionPlan;
        }
        private void CalculatePlans(Offset _offset)
        {
            if (CheckForID(m_course, _offset.NewPlanID()))
            {
                IonPlanSetup IonPlan = (IonPlanSetup)m_course.CopyPlanSetup(m_plan);

                foreach (var movedISO in om.ListOfMovedOffsets)
                {
                    if (!movedISO.FieldID.Equals(_offset.FieldID))
                        IonPlan = ModifyParameters(IonPlan, movedISO);
                }

                IonPlan = ModifyParameters(IonPlan, _offset);
                IonPlan.Id = _offset.NewPlanID();
                tba = UIListener.Find();
                tba.ListenForPopup();

                IonPlan.CalculateDose();
                tba.ListenForPopup();
                if (FinishClock)
                    TimeEstimation(start);
                FinishClock = false;
            }
            else
            {
                felMsg += ("Plannamnet: " + _offset.NewPlanID() + " finns redan, ta bort och försök igen\n");
            }
        }

        private bool OffsetCorrectionUpdate()
        {
            bool ok = false;
            OffsetCorrection oc = new OffsetCorrection(m_offset, m_plan);
            DialogResult dlgResult = oc.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                m_offset = oc.Offset;
                if (m_offset.isIsMoved)
                    om.addMovedOffset(m_offset);
                ok = true;
            }
            return ok;
        }

        private double AddOutputToOffset(string input)
        {
            double coordinate;
            if (!double.TryParse(input, out coordinate))
                coordinate = 0;
            return coordinate;
        }

        private void OutputFromField()
        {
            oppisiteOffset = new Offset(m_offset);
            bool ok = false;

            if (rbMinusX.Checked)
            {
                m_offset.x = AddOutputToOffset("-" + txtShiftX.Text);
                oppisiteOffset.x = AddOutputToOffset("-" + txtShiftX.Text);
            }
            else if (rbPlusX.Checked)
            {
                m_offset.x = AddOutputToOffset(txtShiftX.Text);
                oppisiteOffset.x = AddOutputToOffset(txtShiftX.Text);
            }
            else if (rbPlusMinusX.Checked)
            {
                m_offset.x = AddOutputToOffset(txtShiftX.Text);
                oppisiteOffset.x = AddOutputToOffset("-" + txtShiftX.Text);
                ok = true;
            }

            if (rbMinusY.Checked)
            {
                m_offset.y = AddOutputToOffset("-" + txtShiftY.Text);
                oppisiteOffset.y = AddOutputToOffset("-" + txtShiftY.Text);
            }
            else if (rbPlusY.Checked)
            {
                m_offset.y = AddOutputToOffset(txtShiftY.Text);
                oppisiteOffset.y = AddOutputToOffset(txtShiftY.Text);
            }
            else if (rbPlusMinusY.Checked)
            {
                m_offset.y = AddOutputToOffset(txtShiftY.Text);
                oppisiteOffset.y = AddOutputToOffset("-" + txtShiftY.Text);
                ok = true;
            }

            if (rbMinusZ.Checked)
            {
                m_offset.z = AddOutputToOffset("-" + txtShiftZ.Text);
                oppisiteOffset.z = AddOutputToOffset("-" + txtShiftZ.Text);
            }
            else if (rbPlusZ.Checked)
            {
                m_offset.z = AddOutputToOffset(txtShiftZ.Text);
                oppisiteOffset.z = AddOutputToOffset(txtShiftZ.Text);
            }
            else if (rbPlusMinusZ.Checked)
            {
                m_offset.z = AddOutputToOffset(txtShiftZ.Text);
                oppisiteOffset.z = AddOutputToOffset("-" + txtShiftZ.Text);
                ok = true;
            }

            om.Add(m_offset);
            if (ok)
                om.Add(oppisiteOffset);
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ClockFinish.Text = "Beräknar...";
            {
                start = DateTime.Now;
                double tal = 100 / om.ListOfOffsets.Count;
                heltal = (int)Math.Ceiling(tal);
                lblProgress.Text = (0) + "/" + om.ListOfOffsets.Count;

                for (int i = 0; i < om.ListOfOffsets.Count; i++)
                {
                    lblProgress.Text = (i) + "/" + om.ListOfOffsets.Count;
                    System.Windows.Forms.Application.DoEvents();
                    CalculatePlans(om.ListOfOffsets.ElementAt(i));
                    UpdateProgressBar(i + 1);
                }
                MessageBox.Show("Done!");
                if (felMsg != "")
                    MessageBox.Show(felMsg);
            }
        }

        private void btnCSItemplate_Click(object sender, EventArgs e)
        {
            if (m_plan.IonBeams.Count() >= 4)
            {
                om = new OffsetManager();
                UpdateList();
                CSItemplate temp = new CSItemplate(m_plan);
                om = temp.CSIOffsetManager;
                //OffsetCorrectionUpdate();
                UpdateList();
            }
            else
                MessageBox.Show("För få fält för mall, lägg till manuellt");
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            bool ok = CheckIsoGroup();

            m_offset.FieldID = cbFieldID.SelectedItem.ToString();
            m_offset.OriginalPlanID = m_plan.Id;

            if (ok)
            {
                if (OffsetCorrectionUpdate())
                {
                    OutputFromField();
                    UpdateList();
                    m_offset = new Offset();
                }
            }
            else
            {
                MessageBox.Show("Det valda fältet har samma iso som " + dubbelField + " och kommer därför flytta båda fälten vid beräkning\n\nSkapa ny isocentergrupp för att undvika");
                OutputFromField();
                UpdateList();
                m_offset = new Offset();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (om.CheckIndex(lbListOfOffsets.SelectedIndex))
                om.Delete(lbListOfOffsets.SelectedIndex);
            UpdateList();
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            om.Clear();
            UpdateList();
        }

        private void RensaInput_Click(object sender, EventArgs e)
        {
            var cntls = GetAll(this, typeof(RadioButton));
            foreach (Control cntrl in cntls)
            {
                RadioButton _rb = (RadioButton)cntrl;
                if (_rb.Checked)
                {
                    _rb.Checked = false;
                }
            }
            var textBoxes = GetAll(this, typeof(TextBox));
            foreach (Control txtbox in textBoxes)
            {
                TextBox _tb = (TextBox)txtbox;
                if (_tb.Text != "")
                {
                    _tb.Text = "";
                }
            }
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrls => GetAll(ctrls, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        private bool CheckIsoGroup()
        {
            bool ok = true;
            dubbelField = "";
            int i = 0;
            foreach (var beam in m_plan.IonBeams)
            {
                IonBeam currentBeam = (IonBeam)cbFieldID.SelectedItem;
                double x = -(currentBeam.IsocenterPosition.x - beam.IsocenterPosition.x);
                double y = currentBeam.IsocenterPosition.y - beam.IsocenterPosition.y;
                double z = -(currentBeam.IsocenterPosition.z - beam.IsocenterPosition.z);
                if (x == 0 && y == 0 && z == 0)
                {
                    i++;
                    if (i > 1)
                    {
                        ok = false;
                    }
                    dubbelField += beam.Id + ", ";
                }
            }
            return ok;
        }
    }
}
