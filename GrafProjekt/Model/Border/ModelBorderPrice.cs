using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Model.Border
{
    public class ModelBorderPrice : ModelPrintable
    {
        public double Price { get; set; }
        public override void Print(Graphics graphics)
        {
            double roundedPrice = Price > 100 ?
                Math.Round(Price, 0) : Price > 10 ?
                Math.Round(Price, 1) : Price > 1 ? 
                Math.Round(Price, 1) : 
                Price;

            string price = roundedPrice.ToString();

            SizeF size = graphics.MeasureString(price, ProgramSettings.TextFont);

            graphics.DrawString(price,
                ProgramSettings.TextFont,
                new SolidBrush(ProgramSettings.TextColor),
                new PointF(ProgramSettings.ChartWidth + 10, Y - size.Height / 2));

            graphics.DrawLine(
                new Pen(new SolidBrush(ProgramSettings.BorderLineColor)),
                new PointF(0, Y),
                new PointF(ProgramSettings.ChartWidth + 5, Y));

            graphics.DrawLine(
                new Pen(new SolidBrush(ProgramSettings.BorderLineColor), 2),
                new PointF(ProgramSettings.ChartWidth + 5, Y),
                new PointF(ProgramSettings.ChartWidth + 10, Y));
        }
    }
}
