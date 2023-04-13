using GrafProjekt.Model;
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
            int dateValuesCount = 10;
            int priceValuesCount = 6;

            return new ModelBorder()
            {
                DateValues = GetDateValues(records, dateValuesCount),
                PriceValues = GetPriceValues(records, priceValuesCount)
            };
        }

        private IList<ModelPrice> GetPriceValues(IList<ModelRecord> records, int count)
        {
            records = records
                .OrderBy(r => r.Y)
                .ToList();

            int min = records.First().Y;
            int max = records.Last().Y;

            int offset = (int)((max - min) / count * 0.9);

            int sum = min;
            return Enumerable.Range(0, count)
                .Select(x => GetClosestElementByYValueBinary(records, sum += offset))
                .ToList();
        }

        private ModelPrice GetClosestElementByYValueBinary(IList<ModelRecord> records, int yValue, int left = -1, int right = -1)
        {
            if (right == -1)
            {
                left = 0;
                right = records.Count();
            }

            int mid = (left + right) / 2;

            var record = records[mid];

            return record.Y == yValue || left >= right ?
                new ModelPrice()
                {
                    Y = record.Y,
                    Price = record.Price
                }
                : record.Y < yValue ?
                GetClosestElementByYValueBinary(records, yValue, mid + 1, right):
                GetClosestElementByYValueBinary(records, yValue, 0, mid - 1);
        }

        private IList<ModelDate> GetDateValues(IList<ModelRecord> records, int count)
        {
            int offset = records.Count() / count;

            IList<ModelDate> result = new List<ModelDate>();

            for (int i = 2; (i * offset) < records.Count(); i++)
            {
                var actualRecord = records[(i - 1) * offset];

                string date = actualRecord.Date.Year == records[offset * i].Date.Year ?
                    actualRecord.Date.ToString("MMMM") :
                    actualRecord.Date.ToString("yyyy");

                result.Add(new ModelDate()
                {
                    X = actualRecord.X,
                    Date = date
                });
            }

            return result;
        }
    }
}
