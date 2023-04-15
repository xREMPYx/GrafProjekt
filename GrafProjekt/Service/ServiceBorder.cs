using GrafProjekt.Model;
using GrafProjekt.Model.Border;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Service
{
    public class ServiceBorder
    {
        public ModelBorder GetBorder(IList<ModelRecord> records)
        {
            int dateValuesCount = records.Last().Date.Subtract(records.First().Date) > TimeSpan.FromDays(2000) ? 
                ProgramSettings.ChartWidth / 58 :
                ProgramSettings.ChartWidth / 80;

            int priceValuesCount = 6;

            return new ModelBorder()
            {
                DateValues = GetDateValues(records, dateValuesCount),
                PriceValues = GetPriceValues(records, priceValuesCount)
            };
        }

        private IList<ModelBorderPrice> GetPriceValues(IList<ModelRecord> records, int count)
        {
            records = records
                .OrderBy(r => r.Y)
                .ToList();

            int min = records.First().Y;
            int max = records.Last().Y;

            int offset = (int)((max - min) / count * 0.9);

            int sum = min;
            return Enumerable.Range(0, count)
                .Select(x => GetClosestElementToYValueBinary(records, sum += offset))
                .ToList();
        }

        private ModelBorderPrice GetClosestElementToYValueBinary(IList<ModelRecord> records, int yValue, int left = -1, int right = -1)
        {
            if (right == -1)
            {
                left = 0;
                right = records.Count();
            }

            int mid = (left + right) / 2;

            var record = records[mid];

            return record.Y == yValue || left >= right ?
                new ModelBorderPrice()
                {
                    Y = record.Y,
                    Price = record.Price
                }
                : record.Y < yValue ?
                GetClosestElementToYValueBinary(records, yValue, mid + 1, right):
                GetClosestElementToYValueBinary(records, yValue, 0, mid - 1);
        }

        private IList<ModelBorderDate> GetDateValues(IList<ModelRecord> records, int count)
        {
            double offset = records.Count() / count;

            IList<ModelBorderDate> result = new List<ModelBorderDate>();

            for (int i = 1; (i * offset) < records.Count(); i++)
            {
                var actualRecord = records[(int)(i * offset)];

                string date = actualRecord.Date.Year == records[(int)(offset * (i - 1))].Date.Year ?
                    actualRecord.Date.ToString("MMMM") :
                    actualRecord.Date.ToString("yyyy");

                result.Add(new ModelBorderDate()
                {
                    X = actualRecord.X,
                    Date = date
                });
            }

            return result;
        }
    }
}
