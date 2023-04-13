using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Model
{
    public class ModelRecordSelected : ModelPrintable
    {
        public ModelRecord Record { get; set; }
        public override void Print(Graphics graphics)
        {
            float[] dashPattern = { 5, 2 };

            Pen linePen = new Pen(new SolidBrush(ProgramSettings.SelectedLineColor))
            {
                DashPattern = dashPattern
            };

            graphics.DrawLine(
                linePen, 
                new Point(Record.X, 0), 
                new Point(Record.X, ProgramSettings.ChartHeight + 5));

            graphics.DrawLine(
                linePen,
                new Point(0, Record.Y),
                new Point(ProgramSettings.ChartWidth + 5, Record.Y));

            PrintRecordDateBox(graphics);
            PrintRecordPriceBox(graphics);            
        }

        private void PrintRecordPriceBox(Graphics graphics)
        {
            string price = Math.Round(Record.Price, 2).ToString();
            SizeF textSize = graphics.MeasureString(price, ProgramSettings.TextFont);

            int recOffsetSize = 6;
            Rectangle r = new(
                new Point(ProgramSettings.ChartWidth + recOffsetSize / 2, Record.Y - ((int)textSize.Height + recOffsetSize) / 2),
                new Size((int)textSize.Width + recOffsetSize, (int)textSize.Height + recOffsetSize));

            graphics.FillRectangle(new SolidBrush(ProgramSettings.SelectedBoxColor), r);

            graphics.DrawString(price,
                ProgramSettings.TextFont,
                Brushes.White,
                new Point(ProgramSettings.ChartWidth + recOffsetSize, Record.Y - (int)textSize.Height / 2));
        }

        private void PrintRecordDateBox(Graphics graphics)
        {
            string date = Record.Date.ToString("d/M/yyyy");
            SizeF textSize = graphics.MeasureString(date, ProgramSettings.TextFont);

            int recOffsetSize = 6;
            Rectangle r = new(
                new Point(Record.X - (int)(textSize.Width + recOffsetSize) / 2, ProgramSettings.ChartHeight + 5),
                new Size((int)textSize.Width + recOffsetSize, (int)textSize.Height + recOffsetSize));

            graphics.FillRectangle(new SolidBrush(ProgramSettings.SelectedBoxColor), r);

            graphics.DrawString(date,
                ProgramSettings.TextFont,
                Brushes.White,
                new Point(Record.X - (int)textSize.Width / 2, ProgramSettings.ChartHeight + 5 + (int)(textSize.Height / 4)));
        }
    }
}
