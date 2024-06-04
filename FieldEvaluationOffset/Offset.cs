using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.TPS.Common.Model.Types;
using VMS.TPS.Common.Model.API;
using System.Text.RegularExpressions;

namespace FieldEvaluationOffset
{
    public class Offset
    {
        private string _originalPlanID;
        private double _x;
        private double _y;
        private double _z;
        private double _isoX;
        private double _isoY;
        private double _isoZ;
        private string _xSign;
        private string _ySign;
        private string _zSign;
        private string _fieldID;
        private string _sign;
        private string _offsetName;
        private bool _isIsoMoved;

        public bool isIsMoved
        {
            get { return _isIsoMoved; }
            set { _isIsoMoved = value; }
        }
        public string OffsetName
        {
            get { return _offsetName; }
            set { _offsetName = value; }
        }
        public string Sign
        {
            get { return _sign; }
            set { _sign = value; }
        }
        public string FieldID
        {
            get { return _fieldID; }
            set { _fieldID = value; }
        }
        public string OriginalPlanID
        {
            get { return _originalPlanID; }
            set { _originalPlanID = value; }
        }
        public double IsoZ
        {
            get { return _isoZ; }
            set { _isoZ = value; }
        }
        public double IsoY
        {
            get { return _isoY; }
            set { _isoY = value; }
        }
        public double IsoX
        {
            get { return _isoX; }
            set { _isoX = value; }
        }

        public int FieldIDnumber
        {
            get { return int.Parse(Regex.Match(_fieldID, @"\d+").Value); }
        }
        public double x
        {
            get { return _x; }
            set { _x = value; }
        }
        public double y
        {
            get { return _y; }
            set { _y = value; }
        }
        public double z
        {
            get { return _z; }
            set { _z = value; }
        }
        public double absX
        {
            get { return _x; }
        }
        public double absY
        {
            get { return _y; }
        }
        public double absZ
        {
            get { return _z; }
        }
        public Offset()
        {
            _isIsoMoved = false;
            _isoX = 0;
            _isoY = 0;
            _isoZ = 0;
            _x = 0;
            _y = 0;
            _z = 0;
        }
        public Offset(Offset copy)
        {
            this._x = copy._x;
            this._y = copy._y;
            this._z = copy._z;
            this._isoX = copy._isoX;
            this._isoY = copy._isoY;
            this._isoZ = copy._isoZ;
            this._fieldID = copy._fieldID;
            this._originalPlanID = copy._originalPlanID;
            this._isIsoMoved = copy._isIsoMoved;
        }
        public VVector correctOffset(VVector fieldOffset)
        {
            fieldOffset.x += _isoX + _x;
            fieldOffset.y -= _isoZ + _z;
            fieldOffset.z += _isoY + _y;
            return fieldOffset;
        }
        public string NewPlanID()
        {
            OffsetSigns();
            string planID = string.Format("{0}F{1}_{2}mm", _originalPlanID.Substring(0, 2), FieldIDnumber, _xSign + _ySign + _zSign);
            if (planID.Length >= 13)
                planID = planID.Substring(0, 13);
            return planID;
        }

        public void ClearOffsetNumbers()
        {
            _x = 0;
            _y = 0;
            _z = 0;
        }

        private void OffsetSigns()
        {
            _xSign = SignCheck(_x, "X");
            _ySign = SignCheck(_y, "Y");
            _zSign = SignCheck(_z, "Z");
        }
        private string SignCheck(double number, string axis)
        {
            string name = "";
            if (number != 0 && number > 0)
                name = "+" + number + axis;
            else if (number != 0 && number < 0)
                name = number + axis;
            return name;
        }
        public override string ToString()
        {
            string strOut = string.Format("{0, 3} {1, 7} {2, 5} {3, 5} {4, 8} {5, 6} {6, 7}", FieldIDnumber, _x, _y, _z, -_isoX, -_isoY, -_isoZ);
            return strOut;
        }
    }
}
