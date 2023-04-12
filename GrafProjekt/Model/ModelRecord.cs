using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt.Model
{
    public class ModelRecord : ModelPrintable
    {        
        public double Price { get; set; }
        public int Volume { get; set; }
        public int VolumeHeight { get; set; }
        public bool VolumeIncreased { get; set; }
        public DateTime Date { get; set; }    

        public override void Print(Graphics graphics)
        {                        
            float penWidth = (float)ProgramSettings.ChartWidth / (float)ProgramSettings.ChartDisplayRecordsCount / 2.5f;

            Brush b = VolumeIncreased ? 
                new SolidBrush(ProgramSettings.IncreasedVolumeColor) :
                new SolidBrush(ProgramSettings.DecreasedVolumeColor);

            graphics.DrawLine(
                new Pen(b, penWidth),
                X, ProgramSettings.ChartHeight,
                X, ProgramSettings.ChartHeight - VolumeHeight);
        }                
    }
}
