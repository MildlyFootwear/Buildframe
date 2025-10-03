using Buildframe.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildframe.Methods.Calculation
{
    internal class Physical
    {
        public static double getModImpact(Stats stats)
        {
            return Math.Max(0, stats.baseImpact * (stats.modImpact / 100));
        }
        public static double getModPuncture(Stats stats)
        {
            return Math.Max(0, stats.basePuncture * (stats.modPuncture / 100));
        }
        public static double getModSlash(Stats stats)
        {
            return Math.Max(0, stats.baseSlash * (stats.modSlash / 100));
        }
    }
}
