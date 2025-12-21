using Buildframe.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildframe.Methods.Calculation
{
    internal class Weapon
    {
        public static double calculateBaseDamage(StatsData stats)
        {
            return stats.baseDamage + stats.baseSlash + stats.baseImpact + stats.basePuncture + stats.baseHeat + stats.baseElectric + stats.baseCold + stats.baseToxin + stats.baseCorrosive + stats.baseViral + stats.baseRadiation + stats.baseBlast + stats.baseMagnetic + stats.baseGas;
        }
        /// <summary>
        /// Calculates the modified damage before critical hits and status effects are applied.
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double calculateModDamagePreCritPreMultishot(StatsData stats, bool allowMultishotMultiplier = true)
        {
            double baseDamage = calculateBaseDamage(stats);

            double modImpact = Physical.getModImpact(stats);
            double modPuncture = Physical.getModPuncture(stats);
            double modSlash = Physical.getModSlash(stats);

            double modHeat = Elemental.getModHeat(stats);
            double modElectric = Elemental.getModElectric(stats);
            double modCold = Elemental.getModCold(stats);
            double modToxin = Elemental.getModToxin(stats);

            double modCorrosive = Elemental.getModCorrosive(stats);
            double modViral = Elemental.getModViral(stats);
            double modRadiation = Elemental.getModRadiation(stats);
            double modBlast = Elemental.getModBlast(stats);
            double modMagnetic = Elemental.getModMagnetic(stats);
            double modGas = Elemental.getModGas(stats);

            double modElemental = modHeat + modElectric + modCold + modToxin + modCorrosive + modViral + modRadiation + modBlast + modMagnetic + modGas;
            double modPhysical = modSlash + modImpact + modPuncture;

            double moddedDamage = (baseDamage + modElemental + modPhysical) * (1 + stats.modDamage / 100) * (1 + stats.modDamageFaction / 100) * (1 + stats.modDamagePercentage / 100);

            if (stats.multishotDamageMultiplier != 1 && allowMultishotMultiplier)
            {
                WriteIfDebug("Calculating multishot exclusive damage multiplier for " + stats.name + " with multishot damage multiplier of " + stats.multishotDamageMultiplier);
                moddedDamage *= calculateModMultishotExclusiveDamageMultiplier(stats, (stats.multishotDamageMultiplier - 1) * 100);
            }

            return moddedDamage * stats.damageMultiplier;
        }

        /// <summary>
        /// Used for calculating a damage multiplier when the weapon has a damage increase exclusively for multishot projectiles, such as the Braton incarnon perk.
        /// </summary>
        /// <param name="stats"></param>
        /// <param name="multishotExclusiveDamageBuff"></param>
        /// <returns></returns>
        public static double calculateModMultishotExclusiveDamageMultiplier(StatsData stats, double multishotExclusiveDamageBuff)
        {
            double modMultishot = calculateModMultishot(stats);
            double mult = ((modMultishot - 1) * (1 + multishotExclusiveDamageBuff / 100) + 1) / modMultishot;
            WriteLineIfDebug("Multishot exclusive damage multiplier: " + mult + " with multishot " + modMultishot + " and buff " + multishotExclusiveDamageBuff, DebuggingWeaponCalc);
            return mult;
        }


        public static double calculateModStatusChance(StatsData stats)
        {
            return stats.baseStatusChance * (1 + stats.modStatusChance / 100) + stats.finalStatusChance;
        }
        public static double calculateModCritChance(StatsData stats, bool preEnervate = false)
        {
            double rawCritChance = Math.Max(0, stats.baseCriticalChance * (1 + stats.modCriticalChance / 100) + stats.finalCriticalChance);

            if (preEnervate)
            {
                return rawCritChance;
            }

            int enervateRank = StatMethods.identifyEnervate(stats);

            if (enervateRank > 0)
            {
                double enervateCritIncrease = calculateEnervateIncrease(stats, enervateRank);
                return rawCritChance + enervateCritIncrease;
            }
            return rawCritChance;
        }
        public static double calculateModCritDamage(StatsData stats)
        {
            return Math.Max(1, stats.baseCriticalDamage * (1 + stats.modCriticalDamage / 100) + stats.finalCriticalDamage);
        }
        /// <summary>
        /// Calculates the average critical hit multiplier as well as Devouring Attrition and related incarnon perks if applicable.
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double calculateModAverageCritMultiplier(StatsData stats)
        {
            if (stats.tags.Contains("Devouring_Attrition"))
            {
                return ((calculateModCritDamage(stats) - 1) * (calculateModCritChance(stats) / 100) + 1) + calculateModDevouringAttritionBonusMultiplier(stats);
            }
            return (calculateModCritDamage(stats) - 1) * (calculateModCritChance(stats) / 100) + 1;
        }

        /// <summary>
        /// Calculates the average increase from Devouring Attrition and related incarnon perks, factoring in that critical hits don't receive the bonus.
        /// More or less additive with the critical multiplier, since they have opposing conditionals.
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double calculateModDevouringAttritionBonusMultiplier(StatsData stats)
        {
            double critChance = calculateModCritChance(stats);
            double daBonus = 10;
            daBonus = daBonus * (1 - Math.Min(critChance / 100, 1));
            WriteLineIfDebug("Devouring Attrition bonus " + daBonus + " with crit chance " + critChance, DebuggingWeaponCalc);
            return daBonus;
        }
        public static double calculateModSpeed(StatsData stats)
        {
            if (stats.tags.Contains("Semi_Auto_Fire"))
            {
                return Math.Min(10, stats.baseAttackSpeed * (1 + stats.modAttackSpeed / 100) * stats.speedMultiplier);
            }
            return stats.baseAttackSpeed * (1 + stats.modAttackSpeed / 100) * stats.speedMultiplier;
        }
        public static double calculateModMultishot(StatsData stats)
        {
            return Math.Max(stats.baseMultishot * (1 + stats.modMultishot / 100) + stats.finalMultishot, 1);
        }
        public static double calculateModMagazine(StatsData stats)
        {
            return stats.baseMagazine * (1 + stats.modMagazine / 100) + stats.finalMagazine;
        }
        public static double calculateModReloadTime(StatsData stats)
        {
            return stats.baseReloadTime / (1 + (stats.modReloadTime / 100));
        }
        public static double calculateModAmmoEfficiency(StatsData stats)
        {
            double efficiency = stats.baseAmmoEfficiency + stats.modAmmoEfficiency + stats.finalAmmoEfficiency;
            if (efficiency > 100)
            {
                efficiency = 100;
            }
            return efficiency;
        }
        /// <summary>
        /// Calculates the continuous time a weapon can fire, based off of modded magazine size/ammo efficiency.
        /// Takes into account Incarnon perks that consume reserve ammo when applicable.
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        public static double calculateModFireTime(StatsData stats)
        {
            double ammoEfficiency = calculateModAmmoEfficiency(stats);
            double magazine = calculateModMagazine(stats);

            if (ammoEfficiency >= 100 || magazine == 0)
            {
                return double.PositiveInfinity;
            }

            if (stats.incarnon && stats.tags.Contains("Multishot_Consumes_Reserve_Ammo"))
            {
                return magazine / calculateModMultishot(stats) / calculateModSpeed(stats);
            }
            return magazine / (1 - ammoEfficiency / 100) / calculateModSpeed(stats);
        }
        public static double calculateModReloadMult(StatsData stats)
        {
            double fireTime = calculateModFireTime(stats);
            if (fireTime == double.PositiveInfinity)
            {
                return 1;
            }
            double reloadTime = calculateModReloadTime(stats);
            if (reloadTime == 0)
            {
                return 1;
            }
            double reloadMult = 1 - (reloadTime / (fireTime + reloadTime));
            return reloadMult;
        }
        public static double calculateModDPS(StatsData stats, bool reload = false)
        {

            double moddedDamage = calculateModDamagePreCritPreMultishot(stats);
            double critChance = calculateModCritChance(stats);
            double critDamage = calculateModCritDamage(stats);

            double averageCrit = calculateModAverageCritMultiplier(stats);

            double modSpeed = calculateModSpeed(stats);

            double modMultishot = calculateModMultishot(stats);

            double reloadMult = calculateModReloadMult(stats);

            double dps = moddedDamage * modMultishot * modSpeed;
            dps *= averageCrit;

            if (reload)
            {
                dps *= calculateModReloadMult(stats);
            }

            return dps;
        }

        public static double calculateEnervateIncrease(StatsData stats, int bigCritsCap)
        {
            WriteLineIfDebug("Rolling enervate for " + stats.name + " with cap of " + bigCritsCap, DebuggingWeaponCalc);

            double critChance = calculateModCritChance(stats, true);
            uint steps = 0;
            Random rnd = new Random();
            uint degreeOfAccuracy = 1000000;
            for (int i = 0; i <= degreeOfAccuracy; i++)
            {
                int bigCrits = 0;
                double cycleCritChance = critChance;
                while (bigCrits < bigCritsCap)
                {
                    steps++;
                    cycleCritChance += 10;
                    int roll = rnd.Next(100, 200);
                    if (roll < cycleCritChance)
                    {
                        bigCrits++;
                    }
                }
            }

            WriteLineIfDebug("Average of steps " + steps / degreeOfAccuracy, DebuggingWeaponCalc);

            double enervateCritChanceIncrease = Math.Round(Convert.ToDouble(steps) / degreeOfAccuracy * 10 / 2, 1, MidpointRounding.ToZero);
            WriteLineIfDebug("Enervate crit chance increase: " + enervateCritChanceIncrease, DebuggingWeaponCalc);
            return enervateCritChanceIncrease;
        }

        public static StatsData setEnervate(StatsData stats, int bigCritsCap = 6)
        {
            double critInc = calculateEnervateIncrease(stats, bigCritsCap);
            stats.finalCriticalChance += critInc;
            return stats;
        }
    }
}
