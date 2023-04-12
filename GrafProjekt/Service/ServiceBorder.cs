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
            int count = 5;

            return new ModelBorder()
            {
                DateValues = GetDateValues(records, count),
                PriceValues = GetPriceValues(records, count)
            };
        }

        private IEnumerable<string> GetPriceValues(IList<ModelRecord> records, int count)
        {
            records.OrderBy(r => r.Price);

            double min = records.First().Price;
            double max = records.Last().Price;

            double offset = (max - min) / count;

            double i = min;
            return Enumerable.Range(0, count)
                .Select(x => (i += offset).ToString());
        }

        private IEnumerable<string> GetDateValues(IList<ModelRecord> records, int count)
        {
            int offset = records.Count() / (count + 10);

            int i = 0;
            return Enumerable.Range(0, 5)
                .Select(x => records[i += offset].Date.ToString("MMMM"));
        }
    }
}
