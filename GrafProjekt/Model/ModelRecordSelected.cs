using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Model
{
    public class ModelRecordSelected : ModelRecord
    {
        public override void Print(Graphics graphics)
        {
            float[] dashPattern = { 5, 2 };

            Pen linePen = new Pen(new SolidBrush(ProgramSettings.SelectedLineColor))
            {
                DashPattern = dashPattern
            };

            graphics.DrawLine(
                linePen, 
                new Point(X, 0), 
                new Point(X, ProgramSettings.ChartHeight + 5));

            graphics.DrawLine(
                linePen,
                new Point(0, Y),
                new Point(ProgramSettings.ChartWidth + 5, Y));

            PrintRecordDateBox(graphics);
            PrintRecordPriceBox(graphics);            
        }

        private void PrintRecordPriceBox(Graphics graphics)
        {
            double roundedPrice = Price > 1 ?
                Math.Round(Price, 2) :
                Price;

            string price = roundedPrice.ToString();
            SizeF textSize = graphics.MeasureString(price, ProgramSettings.TextFont);

            int recOffsetSize = 6;
            Rectangle r = new(
                new Point(ProgramSettings.ChartWidth + recOffsetSize / 2, Y - ((int)textSize.Height + recOffsetSize) / 2),
                new Size((int)textSize.Width + recOffsetSize, (int)textSize.Height + recOffsetSize));

            graphics.FillRectangle(new SolidBrush(ProgramSettings.SelectedBoxColor), r);

            graphics.DrawString(price,
                ProgramSettings.TextFont,
                Brushes.White,
                new Point(ProgramSettings.ChartWidth + recOffsetSize, Y - (int)textSize.Height / 2));
        }

        private void PrintRecordDateBox(Graphics graphics)
        {
            string date = Date.ToShortDateString();
            SizeF textSize = graphics.MeasureString(date, ProgramSettings.TextFont);

            int recOffsetSize = 6;
            Rectangle r = new(
                new Point(X - (int)(textSize.Width + recOffsetSize) / 2, ProgramSettings.ChartHeight + 5),
                new Size((int)textSize.Width + recOffsetSize, (int)textSize.Height + recOffsetSize));

            graphics.FillRectangle(new SolidBrush(ProgramSettings.SelectedBoxColor), r);

            graphics.DrawString(date,
                ProgramSettings.TextFont,
                Brushes.White,
                new Point(X - (int)textSize.Width / 2, ProgramSettings.ChartHeight + 5 + (int)(textSize.Height / 4)));
        }
    }
}
