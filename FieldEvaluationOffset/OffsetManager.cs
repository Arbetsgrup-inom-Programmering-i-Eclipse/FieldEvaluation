using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldEvaluationOffset
{
    public class OffsetManager
    {
        private List<Offset> listOfOffsets;
        private List<Offset> listOfMovedOffsets;

        public List<Offset> ListOfOffsets
        {
            get { return listOfOffsets; }
        }
        public List<Offset> ListOfMovedOffsets
        {
            get { return listOfMovedOffsets; }
        }
        public void addMovedOffset(Offset _offset)
        {
            Offset tempOffset = listOfMovedOffsets.FirstOrDefault(offset => offset.FieldID == _offset.FieldID);
            
            if (tempOffset == null)
            {
                Offset m_offset = new Offset(_offset);
                m_offset.ClearOffsetNumbers();
                listOfMovedOffsets.Add(m_offset);
            }
        }
        public void Add(Offset _offset)
        {
            listOfOffsets.Add(_offset);
        }
        public void Edit(Offset _offset, int index)
        {
            listOfOffsets[index] = _offset;
        }
        public void Delete(int index)
        {
            listOfOffsets.RemoveAt(index);
        }
        public void Clear()
        {
            listOfOffsets.Clear();
        }
        public OffsetManager()
        {
            listOfOffsets = new List<Offset>();
            listOfMovedOffsets = new List<Offset>();
        }
        public bool CheckIndex(int index)
        {
            if (index >= 0 && index < listOfOffsets.Count)
                return true;
            else
                return false;
        }
    }
}
