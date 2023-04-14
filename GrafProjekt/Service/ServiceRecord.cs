using GrafProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Service
{
    public class ServiceRecord
    {
        private ServiceFile fileService = new ServiceFile();      
        
        public string ChangeSourceFile()
        {
            return fileService.ChangeSourcePath();
        }

        public IList<ModelRecord> GetRecords(DateTime from, DateTime to, int recordsCount)
        {
            var records = fileService.GetAllRecords()
                .Where(r => r.Date >= from && r.Date <= to)
                .ToList();

            if (records.Count <= 0)
                throw new Exception("Sequence contains no records");

            int offset = records.Count() / recordsCount;

            double i = 0;
            var displayRecords = Enumerable.Range(0, recordsCount - 1)
                .Select(r => records[(int)(i += offset)])
                .ToList();

            displayRecords.Add(records.Last()); // <- ensures that last (actual) record is displayed

            return GetPrintableRecords(displayRecords);
        }

        private IList<ModelRecord> GetPrintableRecords(IList<ModelRecord> records)
        {
            int maxVolume = 0;
            double maxPrice = 0;                    

            foreach (ModelRecord r in records)
            {
                maxPrice = Math.Max(maxPrice, r.Price);
                maxVolume = Math.Max(maxVolume, r.Volume);
            }

            double priceScale = ProgramSettings.ChartHeight / maxPrice * 0.8;
            double volumeScale = (double)ProgramSettings.ChartHeight / (double)maxVolume / 5;

            int offsetX = ProgramSettings.ChartWidth / ProgramSettings.ChartDisplayRecordsCount;
            int offsetSum = 0;

            int i = 0;
            foreach (ModelRecord r in records)
            {
                r.X = offsetSum += offsetX;
                r.VolumeHeight = (int)(r.Volume * volumeScale);
                r.Y = ProgramSettings.ChartHeight - (int)(r.Price * priceScale);                             
                r.VolumeIncreased = i == 0 || records[i - 1].Volume < records[i].Volume;
                i++;
            }

            return records;
        }
    }
}
