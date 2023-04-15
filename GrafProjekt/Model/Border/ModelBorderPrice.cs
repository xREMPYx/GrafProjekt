using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Model.Border
{
    public class ModelPrice : ModelPrintable
    {
        public double Price { get; set; }
        public override void Print(Graphics graphics)
        {
            string price = Math.Round(Price, 2).ToString();

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
