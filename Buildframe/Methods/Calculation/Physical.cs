using Buildframe.GameData;

namespace Buildframe.Methods.Calculation
{
    internal class Physical
    {
        public static double getModImpact(StatsData stats)
        {
            return stats.baseImpact * (stats.modImpact / 100);
        }
        public static double getModPuncture(StatsData stats)
        {
            return stats.basePuncture * (stats.modPuncture / 100);
        }
        public static double getModSlash(StatsData stats)
        {
            return stats.baseSlash * (stats.modSlash / 100);
        }
    }
}
