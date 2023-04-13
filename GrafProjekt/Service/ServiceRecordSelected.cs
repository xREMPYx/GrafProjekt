using GrafProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Service
{
    public class ServiceRecordSelected
    {
        private IList<ModelRecord> records;

        public void UpdateRecords(IList<ModelRecord> records)
        {
            this.records = records;
        }

        public ModelRecordSelected? GetRecordSelected(MouseEventArgs e)
        {
            ModelRecord? r = GetClosestElementByYValueBinary(e.X);

            return e.X > ProgramSettings.ChartWidth || e.X < 0 || r is null ?
                null : 
                new() { Record = r };
        }

        private ModelRecord? GetClosestElementByYValueBinary(int xValue, int left = -10, int right = -10)
        {
            if (right == -10)
            {
                left = 0;
                right = records.Count() - 1;
            }

            int mid = (left + right) / 2;

            var record = records[mid];

            return record.X == xValue || left >= right ?
                 record :
                 xValue <= 0 ? 
                 null : 
                 record.X < xValue ?
                GetClosestElementByYValueBinary(xValue, mid + 1, right) :
                GetClosestElementByYValueBinary(xValue, 0, mid - 1);
        }
    }
}
