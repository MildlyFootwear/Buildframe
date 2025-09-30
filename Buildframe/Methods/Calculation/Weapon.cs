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
        public static double calculateBaseDamage(Stats stats)
        {
            return stats.baseDamage + stats.baseSlash + stats.baseImpact + stats.basePuncture + stats.baseHeat + stats.baseElectric + stats.baseCold + stats.baseToxin + stats.baseCorrosive + stats.baseViral + stats.baseRadiation + stats.baseBlast + stats.baseMagnetic + stats.baseGas;
        }
        public static double calculateModDamagePreCrit(Stats stats)
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

            return moddedDamage * stats.damageMultiplier;
        }
        public static double calculateModStatusChance(Stats stats)
        {
            return stats.baseStatusChance * (1 + stats.modStatusChance / 100) + stats.finalStatusChance;
        }
        public static double calculateModCritChance(Stats stats)
        {
            return stats.baseCriticalChance * (1 + stats.modCriticalChance / 100) + stats.finalCriticalChance;
        }
        public static double calculateModCritDamage(Stats stats)
        {
            return stats.baseCriticalDamage * (1 + stats.modCriticalDamage / 100) + stats.finalCriticalDamage;
        }
        public static double calculateModAverageCritMultiplier(Stats stats)
        {
            return (calculateModCritDamage(stats) - 1) * (calculateModCritChance(stats) / 100) + 1;
        }
        public static double calculateModSpeed(Stats stats)
        {
            return stats.baseAttackSpeed * (1 + stats.modAttackSpeed / 100) + stats.finalAttackSpeed;
        }
        public static double calculateModMultishot(Stats stats)
        {
            return Math.Max(stats.baseMultishot * (1 + stats.modMultishot / 100) + stats.finalMultishot, 1);
        }
        public static double calculateModMagazine(Stats stats)
        {
            return stats.baseMagazine * (1 + stats.modMagazine / 100) + stats.finalMagazine;
        }
        public static double calculateModReloadTime(Stats stats)
        {
            return stats.baseReloadTime / (1 + (stats.modReloadTime / 100));
        }
        public static double calculateModAmmoEfficiency(Stats stats)
        {
            double efficiency = stats.baseAmmoEfficiency + stats.modAmmoEfficiency + stats.finalAmmoEfficiency;
            if (efficiency > 100)
            {
                efficiency = 100;
            }

            return efficiency;
        }
        public static double calculateModFireTime(Stats stats)
        {
            double ammoEfficiency = calculateModAmmoEfficiency(stats);
            double magazine = calculateModMagazine(stats);

            if (ammoEfficiency >= 100 || magazine == 0)
            {
                return double.PositiveInfinity;
            }
            return magazine / (1 - ammoEfficiency / 100) / calculateModSpeed(stats);
        }
        public static double calculateModReloadMult(Stats stats)
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
        public static double calculateModDPS(Stats stats, bool reload = false)
        {

            double moddedDamage = calculateModDamagePreCrit(stats);
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

        public static Stats setEnervate(Stats stats, int bigCritsCap = 6)
        {
            WriteLineIfDebug("Rolling enervate");

            double critChance = calculateModCritChance(stats);
            double steps = 0;
            Random rnd = new Random();
            int degreeOfAccuracy = 100;
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

            WriteLineIfDebug("Average of " + steps / degreeOfAccuracy);
            stats.finalCriticalChance += steps / degreeOfAccuracy * 10 / 2;
            return stats;
        }
    }
}
