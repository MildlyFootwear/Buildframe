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
            return stats.baseSlash + stats.baseImpact + stats.basePuncture + stats.baseFire + stats.baseElectric + stats.baseCold + stats.baseToxin + stats.baseCorrosive + stats.baseViral + stats.baseRadiation + stats.baseBlast + stats.baseMagnetic + stats.baseGas;
        }
        public static double calculateCritChance(Stats stats)
        {
            return stats.baseCriticalChance * (1 + stats.modCriticalChance / 100) + stats.finalCriticalChance;
        }
        public static double calculateCritDamage(Stats stats)
        {
            return stats.baseCriticalDamage * (1 + stats.modCriticalDamage / 100) + stats.finalCriticalDamage;
        }
        public static double calculateAverageCritMultiplier(Stats stats)
        {
            return (calculateCritDamage(stats) - 1) * (calculateCritChance(stats) / 100) + 1;
        }
        public static double calculateSpeed(Stats stats)
        {
            return stats.baseAttackSpeed * (1 + stats.modAttackSpeed / 100) + stats.finalAttackSpeed;
        }
        public static double calculateMultishot(Stats stats)
        {
            return stats.baseMultishot * (1 + stats.modMultishot / 100) + stats.finalMultishot;
        }
        public static double calculateMagazine(Stats stats)
        {
            return stats.baseMagazine * (1 + stats.modMagazine / 100) + stats.finalMagazine;
        }
        public static double calculateReloadTime(Stats stats)
        {
            return stats.baseReloadTime / (1 + (stats.modReloadTime / 100));
        }
        public static double calculateAmmoEfficiency(Stats stats)
        {
            double efficiency = stats.baseAmmoEfficiency + stats.modAmmoEfficiency + stats.finalAmmoEfficiency;
            if (efficiency > 100)
            {
                efficiency = 100;
            }

            return efficiency;
        }
        public static double calculateReloadMult(Stats stats)
        {
            double ammoEfficiency = calculateAmmoEfficiency(stats);
            if (ammoEfficiency >= 100)
            {
                return 1;
            }
            double magazine = calculateMagazine(stats);
            if (magazine == 0)
            {
                return 1;
            }
            double reloadTime = calculateReloadTime(stats);
            if (reloadTime == 0)
            {
                return 1;
            }
            return 1 - (reloadTime / ((magazine / (1 - ammoEfficiency / 100) / calculateSpeed(stats)) + reloadTime));
        }
        public static double calculateDPS(Stats stats, bool reload = false)
        {
            WriteLineIfDebug("\ncalculateDPS\n\n" + stats.name);

            double baseDamage = calculateBaseDamage(stats);

            WriteLineIfDebug("baseDamage " + baseDamage);

            
            double modImpact = Physical.getModImpact(stats);
            double modPuncture = Physical.getModPuncture(stats);
            double modSlash = Physical.getModSlash(stats);

            double modFire = Elemental.getModFire(stats);
            double modElectric = Elemental.getModElectric(stats);
            double modCold = Elemental.getModCold(stats);
            double modToxin = Elemental.getModToxin(stats);

            WriteLineIfDebug("modFire " + modFire + "\nmodElectric " + modElectric + "\nmodCold " + modCold + "\nmodToxin " + modToxin);

            double modCorrosive = Elemental.getModCorrosive(stats);
            double modViral = Elemental.getModViral(stats);
            double modRadiation = Elemental.getModRadiation(stats);
            double modBlast = Elemental.getModBlast(stats);
            double modMagnetic = Elemental.getModMagnetic(stats);
            double modGas = Elemental.getModGas(stats);

            WriteLineIfDebug("modCorrosive " + modCorrosive + "\nmodViral " + modViral + "\nmodRadiation " + modRadiation + "\nmodBlast " + modBlast + "\nmodMagnetic " + modMagnetic + "\nmodGas " + modGas);

            double modElemental = modFire + modElectric + modCold + modToxin + modCorrosive + modViral + modRadiation + modBlast + modMagnetic + modGas;
            double modPhysical = modSlash + modImpact + modPuncture;

            double moddedDamage = (baseDamage + modElemental + modPhysical) * (1 + stats.modDamage / 100) * (1 + stats.modDamageFaction / 100) * (1 + stats.modDamagePercentage / 100);

            double critChance = calculateCritChance(stats);
            double critDamage = calculateCritDamage(stats);

            double averageCrit = calculateAverageCritMultiplier(stats);

            double modSpeed = calculateSpeed(stats);

            double modMultishot = stats.baseMultishot * (1 + stats.modMultishot / 100) + stats.finalMultishot;

            double reloadMult;

            double dps = moddedDamage * modMultishot * modSpeed;

            return dps;
        }
    }
}
