using Buildframe.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildframe.Methods.Calculation
{
    internal class Elemental
    {
        public static double getModHeat(Stats stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modHeat / 100);
        }
        public static double getModCold(Stats stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modCold / 100);
        }
        public static double getModElectric(Stats stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modElectric / 100);
        }
        public static double getModToxin(Stats stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modToxin / 100);
        }

        public static double getModCorrosive(Stats stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modCorrosive / 100);
        }
        public static double getModViral(Stats stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modViral / 100);
        }
        public static double getModBlast(Stats stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modBlast / 100);
        }
        public static double getModRadiation(Stats stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modRadiation / 100);
        }
        public static double getModMagnetic(Stats stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modMagnetic / 100);
        }
        public static double getModGas(Stats stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modGas / 100);
        }
    }
}
