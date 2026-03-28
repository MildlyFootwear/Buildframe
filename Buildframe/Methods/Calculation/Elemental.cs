using Buildframe.GameData;

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


        /// <summary>
        /// Returns the damage of a given element considering only the weapon's base damage and the mod's percentage increase, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getBaseAndModHeat(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modHeat / 100) + stats.baseHeat;
        }
        /// <summary>
        /// Returns the damage of a given element considering only the weapon's base damage and the mod's percentage increase, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getBaseAndModCold(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modCold / 100) + stats.baseCold;
        }
        /// <summary>
        /// Returns the damage of a given element considering only the weapon's base damage and the mod's percentage increase, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getBaseAndModElectric(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modElectric / 100) + stats.baseElectric;
        }
        /// <summary>
        /// Returns the damage of a given element considering only the weapon's base damage and the mod's percentage increase, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getBaseAndModToxin(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modToxin / 100) + stats.baseToxin;
        }
        /// <summary>
        /// Returns the damage of a given element considering only the weapon's base damage and the mod's percentage increase, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getBaseAndModCorrosive(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modCorrosive / 100) + stats.baseCorrosive;
        }
        /// <summary>
        /// Returns the damage of a given element considering only the weapon's base damage and the mod's percentage increase, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getBaseAndModViral(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modViral / 100) + stats.baseViral;
        }
        /// <summary>
        /// Returns the damage of a given element considering only the weapon's base damage and the mod's percentage increase, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getBaseAndModBlast(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modBlast / 100) + stats.baseBlast;
        }
        /// <summary>
        /// Returns the damage of a given element considering only the weapon's base damage and the mod's percentage increase, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getBaseAndModRadiation(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modRadiation / 100) + stats.baseRadiation;
        }
        /// <summary>
        /// Returns the damage of a given element considering only the weapon's base damage and the mod's percentage increase, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getBaseAndModMagnetic(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modMagnetic / 100) + stats.baseMagnetic;
        }
        /// <summary>
        /// Returns the damage of a given element considering only the weapon's base damage and the mod's percentage increase, before modifiers like Deadhead/Roar/etc
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double getBaseAndModGas(StatsData stats)
        {
            return Weapon.calculateBaseDamage(stats) * (stats.modGas / 100) + stats.baseGas;
        }

    }
}
