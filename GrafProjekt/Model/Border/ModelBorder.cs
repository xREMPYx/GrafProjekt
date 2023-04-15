using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Model.Border
{
    public class ModelBorder : ModelPrintable
    {
        public IEnumerable<ModelBorderDate> DateValues { get; set; }
        public IEnumerable<ModelBorderPrice> PriceValues { get; set; }

        public override void Print(Graphics graphics)
        {
            int w = ProgramSettings.ChartWidth;
            int h = ProgramSettings.ChartHeight;

            PointF[] points = { new(w + 5, 0), new(w + 5, h), new(0, h) };

            graphics.DrawLines(new Pen(ProgramSettings.BorderLineColor, 2f), points);

            foreach (ModelBorderDate date in DateValues)
            {
                date.Print(graphics);
            }

            foreach (ModelBorderPrice price in PriceValues)
            {
                price.Print(graphics);
            }
        }
    }
}
