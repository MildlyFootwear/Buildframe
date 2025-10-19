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
        /// <summary>
        /// Returns the value of damage only scaled by base damage, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getModHeat(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modHeat / 100);
        }
        /// <summary>
        /// Returns the value of damage only scaled by base damage, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getModCold(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modCold / 100);
        }
        /// <summary>
        /// Returns the value of damage only scaled by base damage, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getModElectric(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modElectric / 100);
        }
        /// <summary>
        /// Returns the value of damage only scaled by base damage, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getModToxin(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modToxin / 100);
        }

        /// <summary>
        /// Returns the value of damage only scaled by base damage, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getModCorrosive(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modCorrosive / 100);
        }
        /// <summary>
        /// Returns the value of damage only scaled by base damage, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getModViral(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modViral / 100);
        }
        /// <summary>
        /// Returns the value of damage only scaled by base damage, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getModBlast(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modBlast / 100);
        }
        /// <summary>
        /// Returns the value of damage only scaled by base damage, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getModRadiation(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modRadiation / 100);
        }
        /// <summary>
        /// Returns the value of damage only scaled by base damage, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getModMagnetic(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modMagnetic / 100);
        }
        /// <summary>
        /// Returns the value of damage only scaled by base damage, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getModGas(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modGas / 100);
        }
    }
}
