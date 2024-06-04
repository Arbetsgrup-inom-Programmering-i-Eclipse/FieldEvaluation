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
    public partial class backFieldChooser : Form
    {
        private IonPlanSetup m_plan;
        private Offset m_bakreSkallField;


        public Offset BakreSkallField
        {
            get { return m_bakreSkallField; }
            set { m_bakreSkallField = value; }
        }

        public string ID
        {
            get { return cbListOfFields.SelectedItem.ToString(); }
        }

        public backFieldChooser(IonPlanSetup plan, Offset bakreSkallField)
        {
            this.m_plan = plan;
            this.m_bakreSkallField = bakreSkallField;
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            foreach (IonBeam beam in m_plan.IonBeams)
                cbListOfFields.Items.Add(beam);
            cbListOfFields.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            m_bakreSkallField.FieldID = cbListOfFields.SelectedItem.ToString();
        }
    }
}
