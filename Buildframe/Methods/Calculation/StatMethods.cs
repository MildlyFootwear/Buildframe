using Buildframe.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Buildframe.Methods.Calculation
{
    public class StatMethods
    {
        public static int summedCnt = 0;

        public static Stats sumStats(List<Stats> statsList)
        {
            if (statsList.Count == 0)
            {
                return new Stats();
            }
            Stats stats = new Stats();
            summedCnt++;
            stats.name = statsList[0].name;
            stats.id = "summedTransient" + summedCnt;

            WriteLineIfDebug("Starting stats sum for " + statsList.Count + " stats");

            foreach (Stats s in statsList)
            {
                if (s.incarnon)
                {
                    stats.incarnon = true;
                    stats.baseMagazine = s.baseMagazine;
                }
            }

            foreach (Stats s in statsList)
            {
                WriteLineIfDebug(" Adding: " + s.id + "/" + s.name + " to stats.");
                stats.baseDamage += s.baseDamage;
                stats.baseDamagePercentage += s.baseDamagePercentage;

                stats.baseAttackSpeed += s.baseAttackSpeed;

                stats.baseReloadTime += s.baseReloadTime;
                if (!stats.incarnon)
                {
                    stats.baseMagazine += s.baseMagazine;
                    stats.baseAmmoEfficiency += s.baseAmmoEfficiency;
                }
                stats.baseChargeTime += s.baseChargeTime;

                stats.baseSlash += s.baseSlash;
                stats.baseImpact += s.baseImpact;
                stats.basePuncture += s.basePuncture;

                stats.baseHeat += s.baseHeat;
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
                if (!stats.incarnon)
                {
                    stats.modMagazine += s.modMagazine;
                    stats.modAmmoEfficiency += s.modAmmoEfficiency;
                }
                stats.modChargeTime += s.modChargeTime;

                stats.modSlash += s.modSlash;
                stats.modImpact += s.modImpact;
                stats.modPuncture += s.modPuncture;

                stats.modHeat += s.modHeat;
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

                stats.damageMultiplier *= s.damageMultiplier;

                stats.damageMultiplier *= 1 + (s.finalDamagePercentage / 100);
                stats.finalAttackSpeed += s.finalAttackSpeed;

                stats.finalReloadTime += s.finalReloadTime;
                if (!stats.incarnon)
                {
                    stats.finalMagazine += s.finalMagazine;
                    stats.finalAmmoEfficiency += s.finalAmmoEfficiency;

                }
                stats.finalChargeTime += s.finalChargeTime;

                stats.finalSlash += s.finalSlash;
                stats.finalImpact += s.finalImpact;
                stats.finalPuncture += s.finalPuncture;

                stats.finalHeat += s.finalHeat;
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


            if (stats.baseDamage > 0)
            {
                double dmgTotal = stats.baseImpact + stats.basePuncture + stats.baseSlash + stats.baseHeat + stats.baseCold + stats.baseElectric + stats.baseToxin + stats.baseBlast + stats.baseRadiation + stats.baseViral + stats.baseCorrosive + stats.baseMagnetic + stats.baseGas;
                if (dmgTotal > 0)
                {
                    stats.baseImpact += stats.baseImpact / dmgTotal * stats.baseDamage;
                    stats.basePuncture += stats.basePuncture / dmgTotal * stats.baseDamage;
                    stats.baseSlash += stats.baseSlash / dmgTotal * stats.baseDamage;
                    stats.baseHeat += stats.baseHeat / dmgTotal * stats.baseDamage;
                    stats.baseCold += stats.baseCold / dmgTotal * stats.baseDamage;
                    stats.baseElectric += stats.baseElectric / dmgTotal * stats.baseDamage;
                    stats.baseToxin += stats.baseToxin / dmgTotal * stats.baseDamage;
                    stats.baseBlast += stats.baseBlast / dmgTotal * stats.baseDamage;
                    stats.baseRadiation += stats.baseRadiation / dmgTotal * stats.baseDamage;
                    stats.baseViral += stats.baseViral / dmgTotal * stats.baseDamage;
                    stats.baseCorrosive += stats.baseCorrosive / dmgTotal * stats.baseDamage;
                    stats.baseMagnetic += stats.baseMagnetic / dmgTotal * stats.baseDamage;
                    stats.baseGas += stats.baseGas / dmgTotal * stats.baseDamage;
                    stats.baseDamage = 0;
                }
            }

            return stats;
        }

        public static int identifyEnervate(Stats stats)
        {
            string arcaneName = stats.name;
            int returnValue = 0;
            if (!arcaneName.Contains("Enervate"))
            {
                return 0;
            }
            if (arcaneName.Contains("0"))
            {
                returnValue = 1;
            }
            else if (arcaneName.Contains("1"))
            {
                returnValue = 2;
            }
            else if (arcaneName.Contains("2"))
            {
                returnValue = 3;
            }
            else if (arcaneName.Contains("3"))
            {
                returnValue = 4;
            }
            else if (arcaneName.Contains("4"))
            {
                returnValue = 5;
            }
            else if (arcaneName.Contains("5"))
            {
                returnValue = 6;
            }
            WriteLineIfDebug("Identified Enervate level " + returnValue + " from arcane " + arcaneName+" - "+stats.id);
            return returnValue;
        }

    }

}
