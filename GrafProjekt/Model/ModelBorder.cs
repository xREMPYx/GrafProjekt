using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Model
{
    public class ModelBorder : ModelPrintable
    {
        public IEnumerable<string> DateValues { get; set; }
        public IEnumerable<string> PriceValues { get; set; }

        public override void Print(Graphics graphics)
        {
            int w = ProgramSettings.ChartWidth;
            int h = ProgramSettings.ChartHeight;

            PointF[] points = { new(w + 5, 0), new(w + 5, h), new(0, h) };

            graphics.DrawLines(new Pen(ProgramSettings.BorderLineColor, 2f), points);

            Font f = new ("Arial", 10);

            int offsetX = w / DateValues.Count();
            int offsetY = h / DateValues.Count();

            int i = 0;
            foreach (string value in DateValues)
            {
                graphics.DrawString(value, f, new SolidBrush(ProgramSettings.TextColor), new PointF(w - (i += offsetX) + 5, h));
            }

            i = 0;
            foreach (string value in PriceValues)
            {
                graphics.DrawString(value, f, new SolidBrush(ProgramSettings.TextColor), new PointF(w + 5, h + 20 - (i += offsetY)));
            }
        }
    }
}
