﻿using Buildframe.GameData;
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

        static void appendTagIfValid(StatsData s, StatsData stats, string tag)
        {
            if (s.tags.Contains(tag) && !stats.tags.Contains(tag))
            {
                WriteLineIfDebug("  Tag \"" + tag + "\" found on " + s);
                stats.tags += " " + tag;
            }
        }

        public static StatsData sumStats(List<StatsData> statsList)
        {
            if (statsList.Count == 0)
            {
                return new StatsData();
            }
            StatsData stats = new StatsData();
            summedCnt++;
            stats.name = "";
            stats.id = "summedTransient" + summedCnt;

            WriteLineIfDebug("Starting stats sum for " + statsList.Count + " stats");

            foreach (StatsData s in statsList)
            {
                if (s.incarnon)
                {
                    stats.incarnon = true;
                    stats.baseMagazine = s.baseMagazine;
                }
            }

            foreach (StatsData s in statsList)
            {
                WriteLineIfDebug(" Adding: " + s.id + "/" + s.name + " to stats.");

                stats.name += s.name + ", ";

                appendTagIfValid(s, stats, "Devouring_Attrition");
                appendTagIfValid(s, stats, "Multishot_Consumes_Reserve_Ammo");
                appendTagIfValid(s, stats, "Secondary_Enervate_Rank_0");
                appendTagIfValid(s, stats, "Secondary_Enervate_Rank_1");
                appendTagIfValid(s, stats, "Secondary_Enervate_Rank_2");
                appendTagIfValid(s, stats, "Secondary_Enervate_Rank_3");
                appendTagIfValid(s, stats, "Secondary_Enervate_Rank_4");
                appendTagIfValid(s, stats, "Secondary_Enervate_Rank_5");
                appendTagIfValid(s, stats, "Semi_Auto_Fire");

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

                if (s.multishotDamageMultiplier != 1)
                {
                    stats.multishotDamageMultiplier *= s.multishotDamageMultiplier;
                }

                if (s.finalAttackSpeed != 0)
                {
                    stats.speedMultiplier *= 1 + (s.finalAttackSpeed / 100);
                }

                if (s.tags.Contains("Multishot_Exclusive_Damage_Mult"))
                {
                    stats.multishotDamageMultiplier *= 1 + (s.finalDamagePercentage / 100);
                } else
                {
                    stats.damageMultiplier *= 1 + (s.finalDamagePercentage / 100);
                }

                stats.damageMultiplier *= s.damageMultiplier;
                stats.speedMultiplier *= s.speedMultiplier;
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

            // Floor damage so it doesn't go negative.
            stats.modSlash = Math.Max(stats.modSlash, -100);
            stats.modImpact = Math.Max(stats.modImpact, -100);
            stats.modPuncture = Math.Max(stats.modPuncture, -100);

            stats.name = stats.name.Trim().TrimEnd(',');

            return stats;
        }

        public static int identifyEnervate(StatsData stats)
        {
            string arcaneTags = stats.tags;
            int returnValue = 0;
            if (!arcaneTags.Contains("Secondary_Enervate_Rank"))
            {
                return 0;
            }
            if (arcaneTags.Contains("Secondary_Enervate_Rank_0"))
            {
                returnValue = 1;
            }
            else if (arcaneTags.Contains("Secondary_Enervate_Rank_1"))
            {
                returnValue = 2;
            }
            else if (arcaneTags.Contains("Secondary_Enervate_Rank_2"))
            {
                returnValue = 3;
            }
            else if (arcaneTags.Contains("Secondary_Enervate_Rank_3"))
            {
                returnValue = 4;
            }
            else if (arcaneTags.Contains("Secondary_Enervate_Rank_4"))
            {
                returnValue = 5;
            }
            else if (arcaneTags.Contains("Secondary_Enervate_Rank_5"))
            {
                returnValue = 6;
            }
            WriteLineIfDebug("Identified Enervate level " + returnValue + " from arcane " + stats +" - " + stats.id);
            return returnValue;
        }

    }

}
