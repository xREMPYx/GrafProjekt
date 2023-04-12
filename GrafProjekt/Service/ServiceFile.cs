using GrafProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Service
{
    public class ServiceFile
    {
        private const string FILE_NAME = "TSLA.csv";
        
        public IList<ModelRecord> GetAllRecords()
        {
            IList<ModelRecord> records = new List<ModelRecord>();

            using (StreamReader reader = new StreamReader(FILE_NAME))
            {
                reader.ReadLine(); //skips heading

                while (!reader.EndOfStream)
                {
                    records.Add(GetRecord(reader.ReadLine()));
                }
            };

            return records;
        }

        private ModelRecord GetRecord(string line)
        {
            string[] parts = line.Split(',');

            return new ModelRecord()
            {
                Date = DateTime.Parse(parts[0]),
                Price = Convert.ToDouble(parts[1].Replace('.', ',')),
                Volume = Convert.ToInt32(parts[6])
            };
        }
    }
}