using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Model
{
    public abstract class ModelPrintable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointF GetPoint() => new (X, Y);
        public abstract void Print(Graphics graphics);
    }
}