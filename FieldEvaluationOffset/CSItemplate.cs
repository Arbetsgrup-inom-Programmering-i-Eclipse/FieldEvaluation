using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.TPS.Common.Model.API;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FieldEvaluationOffset
{
    class CSItemplate
    {
        private OffsetManager _om;
        public OffsetManager CSIOffsetManager { get { return _om; } }

        public CSItemplate(IonPlanSetup m_plan)
        {
            _om = new OffsetManager();
            Offset bakreSkallField = new Offset();
            Offset lowerRyggField = new Offset();
            Offset upperRyggField = new Offset();
            bakreSkallField.OriginalPlanID = m_plan.Id;
            lowerRyggField.OriginalPlanID = m_plan.Id;
            upperRyggField.OriginalPlanID = m_plan.Id;

            int i = 0;
            int id = 2;

            backFieldChooser bfc = new backFieldChooser(m_plan, bakreSkallField);
            DialogResult dlgResult = bfc.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                bakreSkallField.FieldID = bfc.BakreSkallField.FieldID;
            }
            else
                bakreSkallField.FieldID = m_plan.IonBeams.ElementAt(2).Id;

            foreach (IonBeam beam in m_plan.IonBeams)
            {
                if (int.Parse(Regex.Match(beam.Id, @"\d+").Value) == bakreSkallField.FieldIDnumber)
                    id = i;
                if (int.Parse(Regex.Match(beam.Id, @"\d+").Value) == 4)
                    upperRyggField.FieldID = beam.Id;
                else if (int.Parse(Regex.Match(beam.Id, @"\d+").Value) == 5)
                    lowerRyggField.FieldID = beam.Id;
                i++;
            }
            if (bakreSkallField == null)
                bakreSkallField.FieldID = m_plan.IonBeams.ElementAt(2).Id;
            


            IonBeam ionBeam = m_plan.IonBeams.FirstOrDefault(beam => beam.IonControlPoints.First().GantryAngle < 150);
            bakreSkallField.IsoX = Math.Round((ionBeam.IsocenterPosition.x - m_plan.Beams.ElementAt(id).IsocenterPosition.x), 1);
            bakreSkallField.IsoZ = Math.Round(-(ionBeam.IsocenterPosition.y - m_plan.Beams.ElementAt(id).IsocenterPosition.y), 1);
            bakreSkallField.IsoY = Math.Round((ionBeam.IsocenterPosition.z - m_plan.Beams.ElementAt(id).IsocenterPosition.z), 1);

            bakreSkallField.isIsMoved = true;
            _om.addMovedOffset(bakreSkallField);

            bakreSkallField.y = 2;
            _om.Add(bakreSkallField);

            bakreSkallField = new Offset(bakreSkallField);
            bakreSkallField.y = -2;
            _om.Add(bakreSkallField);

            bakreSkallField = new Offset(bakreSkallField);
            bakreSkallField.y = 0;
            bakreSkallField.x = 2;
            _om.Add(bakreSkallField);

            bakreSkallField = new Offset(bakreSkallField);
            bakreSkallField.x = -2;
            _om.Add(bakreSkallField);
            
            upperRyggField.y = 3;
            _om.Add(upperRyggField);

            upperRyggField = new Offset(upperRyggField);
            upperRyggField.y = -3;
            _om.Add(upperRyggField);

            upperRyggField = new Offset(upperRyggField);
            upperRyggField.y = 0;
            upperRyggField.x = 5;
            _om.Add(upperRyggField);

            upperRyggField = new Offset(upperRyggField);
            upperRyggField.x = -5;
            _om.Add(upperRyggField);


            if (m_plan.IonBeams.Count() > 4)
            {
                lowerRyggField.y = 10;
                _om.Add(lowerRyggField);

                lowerRyggField = new Offset(lowerRyggField);
                lowerRyggField.y = -10;
                _om.Add(lowerRyggField);

                lowerRyggField = new Offset(lowerRyggField);
                lowerRyggField.y = 0;
                lowerRyggField.x = 5;
                _om.Add(lowerRyggField);

                lowerRyggField = new Offset(lowerRyggField);
                lowerRyggField.x = -5;
                _om.Add(lowerRyggField);
            }
        }
    }
}
