using Buildframe.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Buildframe.Methods
{
    public class CalculationMethods
    {
        public static Stats sumStats(List<Stats> statsList)
        {
            Stats stats = new Stats();

            foreach (Stats s in statsList)
            {
                stats.baseDamage += s.baseDamage;
                stats.baseDamagePercentage += s.baseDamagePercentage;

                stats.baseAttackSpeed += s.baseAttackSpeed;

                stats.baseReloadTime += s.baseReloadTime;
                stats.baseAmmoEfficiency += s.baseAmmoEfficiency;
                stats.baseChargeTime += s.baseChargeTime;

                stats.baseSlash += s.baseSlash;
                stats.baseImpact += s.baseImpact;
                stats.basePuncture += s.basePuncture;

                stats.baseFire += s.baseFire;
                stats.baseCold += s.baseCold;
                stats.baseElectric += s.baseElectric;
                stats.baseToxin += s.baseToxin;

                stats.baseBlast += s.baseBlast;
                stats.baseRadiation += s.baseRadiation;
                stats.baseViral += s.baseViral;
                stats.baseCorrosive += s.baseCorrosive;
                stats.baseMagnetic += s.baseMagnetic;
                stats.baseGas += s.baseGas;

                stats.baseMultishot += s.baseMultishot;

                stats.baseCriticalChance += s.baseCriticalChance;
                stats.baseCriticalDamage += s.baseCriticalDamage;

                stats.baseStatusChance += s.baseStatusChance;
                stats.baseStatusDamage += s.baseStatusDamage;



                stats.modDamage += s.modDamage;
                stats.modDamagePercentage += s.modDamagePercentage;
                stats.modDamageFaction += s.modDamageFaction;

                stats.modAttackSpeed += s.modAttackSpeed;

                stats.modReloadTime += s.modReloadTime;
                stats.modAmmoEfficiency += s.modAmmoEfficiency;
                stats.modChargeTime += s.modChargeTime;

                stats.modSlash += s.modSlash;
                stats.modImpact += s.modImpact;
                stats.modPuncture += s.modPuncture;

                stats.modFire += s.modFire;
                stats.modCold += s.modCold;
                stats.modElectric += s.modElectric;
                stats.modToxin += s.modToxin;

                stats.modBlast += s.modBlast;
                stats.modRadiation += s.modRadiation;
                stats.modViral += s.modViral;
                stats.modCorrosive += s.modCorrosive;
                stats.modMagnetic += s.modMagnetic;
                stats.modGas += s.modGas;

                stats.modMultishot += s.modMultishot;

                stats.modCriticalChance += s.modCriticalChance;
                stats.modCriticalDamage += s.modCriticalDamage;

                stats.modStatusChance += s.modStatusChance;
                stats.modStatusDamage += s.modStatusDamage;


                stats.finalDamage += s.finalDamage;
                stats.finalDamagePercentage += s.finalDamagePercentage;

                stats.finalAttackSpeed += s.finalAttackSpeed;

                stats.finalReloadTime += s.finalReloadTime;
                stats.finalAmmoEfficiency += s.finalAmmoEfficiency;
                stats.finalChargeTime += s.finalChargeTime;

                stats.finalSlash += s.finalSlash;
                stats.finalImpact += s.finalImpact;
                stats.finalPuncture += s.finalPuncture;

                stats.finalFire += s.finalFire;
                stats.finalCold += s.finalCold;
                stats.finalElectric += s.finalElectric;
                stats.finalToxin += s.finalToxin;

                stats.finalBlast += s.finalBlast;
                stats.finalRadiation += s.finalRadiation;
                stats.finalViral += s.finalViral;
                stats.finalCorrosive += s.finalCorrosive;
                stats.finalMagnetic += s.finalMagnetic;
                stats.finalGas += s.finalGas;

                stats.finalMultishot += s.finalMultishot;

                stats.finalCriticalChance += s.finalCriticalChance;
                stats.finalCriticalDamage += s.finalCriticalDamage;

                stats.finalStatusChance += s.finalStatusChance;
                stats.finalStatusDamage += s.finalStatusDamage;

            }

            return stats;
        }
        public static double calculateDPS(Stats stats)
        {
            WriteLineIfDebug("\ncalculateDPS\n\n"+stats.name);

            double baseDamage = stats.baseSlash + stats.baseImpact + stats.basePuncture + stats.baseFire + stats.baseElectric + stats.baseCold + stats.baseToxin + stats.baseCorrosive + stats.baseViral + stats.baseRadiation + stats.baseBlast + stats.baseMagnetic + stats.baseGas;

            WriteLineIfDebug("baseDamage " + baseDamage);

            double modSlash = stats.baseSlash * (stats.modSlash / 100);
            double modImpact = stats.baseImpact * (stats.modImpact / 100);
            double modPuncture = stats.basePuncture * (stats.modPuncture / 100);

            double modFire = baseDamage * (stats.modFire / 100);
            double modElectric = baseDamage * (stats.modElectric / 100);
            double modCold = baseDamage * (stats.modCold / 100);
            double modToxin = baseDamage * (stats.modToxin / 100);

            WriteLineIfDebug("modFire " + modFire + "\nmodElectric "+ modElectric + "\nmodCold " + modCold + "\nmodToxin " + modToxin);

            double modCorrosive = baseDamage * (stats.modCorrosive / 100);
            double modViral = baseDamage * (stats.modViral / 100);
            double modRadiation = baseDamage * (stats.modRadiation / 100);
            double modBlast = baseDamage * (stats.modBlast / 100);
            double modMagnetic = baseDamage * (stats.modMagnetic / 100);
            double modGas = baseDamage * (stats.modGas / 100);

            WriteLineIfDebug("modCorrosive " + modCorrosive + "\nmodViral " + modViral + "\nmodRadiation " + modRadiation + "\nmodBlast " + modBlast + "\nmodMagnetic " + modMagnetic + "\nmodGas " + modGas);

            double modElemental = modFire + modElectric + modCold + modToxin + modCorrosive + modViral + modRadiation + modBlast + modMagnetic + modGas;
            double modPhysical = modSlash + modImpact + modPuncture;

            double moddedDamage = (baseDamage + modElemental + modPhysical) * (1 + stats.modDamage / 100) * (1 + stats.modDamageFaction / 100) * (1 + stats.modDamagePercentage / 100);

            double critChance = stats.baseCriticalChance * (1 + stats.modCriticalChance / 100) + stats.finalCriticalChance;
            double critDamage = stats.baseCriticalDamage * (1 + stats.modCriticalDamage / 100) + stats.finalCriticalDamage;

            double averageCrit = (critDamage - 1) * (critChance / 100) + 1;

            double dps = 0;

            return dps;
        }
    }

}
