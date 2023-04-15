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
            ModelRecord? r = GetClosestElementToXValueBinary(e.X);

            return e.X > ProgramSettings.ChartWidth + 10 || e.X < -10 || r is null ?
                null : 
                new ModelRecordSelected()
                {
                    Y = r.Y,
                    X = r.X,
                    Date = r.Date,
                    Price = r.Price                                                            
                };
        }

        private ModelRecord? GetClosestElementToXValueBinary(int xValue, int left = -10, int right = -10)
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
                GetClosestElementToXValueBinary(xValue, mid + 1, right) :
                GetClosestElementToXValueBinary(xValue, 0, mid - 1);
        }
    }
}
