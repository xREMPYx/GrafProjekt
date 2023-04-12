using GrafProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Service
{
    public class ServiceChart
    {
        private Pen linePen;
        
        private ServiceRecord recordService;

        private ServiceBorder borderService;

        private IList<ModelRecord> displayRecords;

        private ModelBorder border;

        public ServiceChart(DateTime from, DateTime to)
        {
            recordService = new ServiceRecord();
            borderService = new ServiceBorder();
            linePen = new Pen(new SolidBrush(Color.FromArgb(255, 51, 154, 245)), 2f);

            UpdateRecords(from, to);            
        }

        public void UpdateRecords(DateTime from, DateTime to)
        {
            displayRecords = recordService.GetRecords(from, to, ProgramSettings.ChartDisplayRecordsCount);
            border = borderService.GetBorder(displayRecords);
        }

        public void Print(Graphics graphics)
        {
            PrintVolumeBars(graphics);
            PrintLines(graphics);
            PrintCurrentPoint(graphics);
            PrintBorder(graphics);
        }
        
        private void PrintLines(Graphics graphics)
        {
            var points = displayRecords
                .Select(r => r.GetPoint())
                .ToArray();

            graphics.DrawLines(linePen, points);
        }
        private void PrintBorder(Graphics graphics)
        {
            border.Print(graphics);
        }
        private void PrintVolumeBars(Graphics graphics)
        {
            foreach (ModelRecord r in displayRecords)
            {
                r.Print(graphics);
            }
        }        
        private void PrintCurrentPoint(Graphics graphics)
        {            
            int d = 6;
            var record = displayRecords.Last();
            graphics.FillEllipse(new SolidBrush(ProgramSettings.ActualPointColor), record.X - d / 2, record.Y - d / 2, d, d);
            graphics.DrawEllipse(Pens.White, record.X - d / 2, record.Y - d / 2, d, d);
        }        
    }
}
