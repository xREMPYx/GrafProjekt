using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafProjekt
{
    public static class ProgramSettings
    {
        public static int ChartWidth { get; } = 550;
        public static int ChartHeight { get; } = 430;
        public static int ChartDisplayRecordsCount { get; } = 55;
        // (ChartWidth % ChartDisplayRecordsCount) <- has to be equal to zero,
        // other value causes picture box to draw points incorectly

        public static Color TextColor { get; } = Color.FromArgb(255, 125, 131, 136);
        public static Color BorderLineColor { get; } = Color.FromArgb(255, 198, 201, 204);        
        public static Color ActualPointColor { get; } = Color.FromArgb(255, 0, 129, 242);
        public static Color DecreasedVolumeColor { get; } = Color.FromArgb(255, 255, 112, 117);
        public static Color IncreasedVolumeColor { get; } = Color.FromArgb(255, 76, 200, 144);                
    }
}
