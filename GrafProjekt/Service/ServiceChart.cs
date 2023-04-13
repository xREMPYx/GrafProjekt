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
        private ServiceRecord recordService;

        private ServiceBorder borderService;

        private ServiceRecordSelected recordSelectedService;

        private IList<ModelRecord> displayRecords;

        private ModelBorder border;

        private ModelRecordSelected? selectedRecord;

        public ServiceChart()
        {
            recordService = new ServiceRecord();
            borderService = new ServiceBorder();
            recordSelectedService = new ServiceRecordSelected();
            SetDefaultDateRange();
        }

        public string ChangeSourceFile()
        {
            string name = recordService.ChangeSourceFile();
            SetDefaultDateRange();
            return name;
        }

        public void UpdateRecords(DateTime from, DateTime to)
        {
            displayRecords = recordService.GetRecords(from, to, ProgramSettings.ChartDisplayRecordsCount);
            border = borderService.GetBorder(displayRecords);
            recordSelectedService.UpdateRecords(displayRecords);
        }

        public void UpdateSelectedRecord(MouseEventArgs e)
        {
            selectedRecord = recordSelectedService.GetRecordSelected(e);
        }

        public void DeleteSelectedRecord()
        {
            selectedRecord = null;
        }

        public void SetDefaultDateRange() => UpdateRecords(DateTime.Now.AddYears(-10), DateTime.Now);

        public void Print(Graphics graphics)
        {
            PrintBorder(graphics);
            PrintVolumeBars(graphics);
            PrintLines(graphics);
            PrintCurrentPoint(graphics);            
            PrintCurrentPrice(graphics);
            PrintSelectedRecord(graphics);
        }
        
        private void PrintLines(Graphics graphics)
        {
            var points = displayRecords
                .Select(r => r.GetPoint())
                .ToArray();

            graphics.DrawLines(
                new Pen(new SolidBrush(ProgramSettings.LineColor), ProgramSettings.ChartLineWidth),
                points);
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
        private void PrintCurrentPrice(Graphics graphics)
        {
            var record = displayRecords.Last();

            string price = Math.Round(record.Price, 2).ToString();
            SizeF textSize = graphics.MeasureString(price, ProgramSettings.TextFont);

            int recOffsetSize = 6;
            Rectangle r = new(
                new Point(record.X + recOffsetSize / 2, record.Y - ((int)textSize.Height + recOffsetSize) / 2),
                new Size((int)textSize.Width + recOffsetSize, (int)textSize.Height + recOffsetSize));

            graphics.FillRectangle(new SolidBrush(ProgramSettings.IncreasedVolumeColor), r);

            graphics.DrawString(price, 
                ProgramSettings.TextFont, 
                Brushes.White, 
                new Point(record.X + recOffsetSize, record.Y - (int)textSize.Height / 2));
        }
        private void PrintSelectedRecord(Graphics graphics)
        {
            if (selectedRecord is null)
            {
                return;
            }

            selectedRecord.Print(graphics);
        }
    }
}
