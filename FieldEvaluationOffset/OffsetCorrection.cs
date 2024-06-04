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

namespace FieldEvaluationOffset
{
    public partial class OffsetCorrection : Form
    {
        private bool _ok;
        private Offset _offset;
        private IonPlanSetup m_plan;

        public Offset Offset
        {
            get { return _offset; }
            set { _offset = value; }
        }
        public bool OK
        {
            get { return _ok; }
            set { _ok = value; }
        }

        public OffsetCorrection(Offset offset, IonPlanSetup plan)
        {
            this.m_plan = plan;
            this._offset = offset;
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            foreach (IonBeam beam in m_plan.IonBeams)
                if (beam.Id != _offset.FieldID)
                    lbFields.Items.Add(beam);
            txtXoffset.Text = "0";
            txtYoffset.Text = "0";
            txtZoffset.Text = "0";
        }
        private void CheckOutput()
        {
            _ok = false;
            if (!string.IsNullOrEmpty(txtXoffset.Text) && !string.IsNullOrEmpty(txtYoffset.Text) && !string.IsNullOrEmpty(txtZoffset.Text))
            {
                Offset.IsoX = -double.Parse(txtXoffset.Text) * 10;
                Offset.IsoY = -double.Parse(txtYoffset.Text) * 10;
                Offset.IsoZ = -double.Parse(txtZoffset.Text) * 10;

                if (Offset.IsoX != 0 || Offset.IsoY != 0 || Offset.IsoZ != 0)
                    Offset.isIsMoved = true;

                _ok = true;
            }
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            CheckOutput();
            if (!OK)
                MessageBox.Show("Någon/några rutor är tomma");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void lbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFields.SelectedIndex != -1)
            {
                IonBeam currentBeam = m_plan.IonBeams.FirstOrDefault(beam => beam.Id.Equals(Offset.FieldID));
                IonBeam otherBeam = (IonBeam)lbFields.SelectedItem;
                txtXoffset.Text = (-(-(currentBeam.IsocenterPosition.x - otherBeam.IsocenterPosition.x) / 10)).ToString("0.00");
                txtZoffset.Text = (-((currentBeam.IsocenterPosition.y - otherBeam.IsocenterPosition.y) / 10)).ToString("0.00");
                txtYoffset.Text = (-(-(currentBeam.IsocenterPosition.z - otherBeam.IsocenterPosition.z) / 10)).ToString("0.00");
            }
        }
    }
}
