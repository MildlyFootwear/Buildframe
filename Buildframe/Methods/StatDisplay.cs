using Buildframe.GameData;
using Buildframe.Methods.Calculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildframe.Methods
{
    internal class StatDisplay
    {


        public static string generateStatsDescription(StatsData stats, StatsData? fullSheet = null)
        {
            string s = stats.name;
            if (fireModeStats.Values.Contains(stats) == false || stats.tags != "Any")
                s += "\nTags: " + stats.tags;
            if (ToolDebug)
            {
                s += "\nID: " + stats.id;
            }
            
            if (stats.incarnon)
            {
                s += "\nIncarnon";
            }
            if (stats.tags.Contains("Semi_Auto_Fire"))
            {
                s += "\nSemi-Auto";
            }
            s += "\n\n";
            if (stats.description != "")
            {
                s += stats.description + "\n\n";
            }

            int enervate = StatMethods.identifyEnervate(stats);
            if (enervate != 0)
            {
                s += "Enervate Rank: " + (enervate - 1) + "\n";
                if (fullSheet != null)
                {
                    double crit = Calculation.Weapon.calculateEnervateIncrease(fullSheet, enervate);
                    s += "Enervate Critical Chance Increase: " + Math.Round(crit, 2) + "%\n\n";
                }
            }

            if (stats.punchthrough != 0)
            {
                s += "Punchthrough: " + stats.punchthrough + "\n";
            }
            if (stats.baseImpact != 0)
            {
                s += "Base Impact Damage: " + stats.baseImpact + "\n";
            }
            if (stats.basePuncture != 0)
            {
                s += "Base Puncture Damage: " + stats.basePuncture + "\n";
            }
            if (stats.baseSlash != 0)
            {
                s += "Base Slash Damage: " + stats.baseSlash + "\n";
            }

            if (stats.baseHeat != 0)
            {
                s += "Base Heat Damage: " + stats.baseHeat + "\n";
            }
            if (stats.baseCold != 0)
            {
                s += "Base Cold Damage: " + stats.baseCold + "\n";
            }
            if (stats.baseElectric != 0)
            {
                s += "Base Electric Damage: " + stats.baseElectric + "\n";
            }
            if (stats.baseToxin != 0)
            {
                s += "Base Toxin Damage: " + stats.baseToxin + "\n";
            }

            if (stats.baseBlast != 0)
            {
                s += "Base Blast Damage: " + stats.baseBlast + "\n";
            }
            if (stats.baseRadiation != 0)
            {
                s += "Base Radiation Damage: " + stats.baseRadiation + "\n";
            }
            if (stats.baseViral != 0)
            {
                s += "Base Viral Damage: " + stats.baseViral + "\n";
            }
            if (stats.baseCorrosive != 0)
            {
                s += "Base Corrosive Damage: " + stats.baseCorrosive + "\n";
            }
            if (stats.baseMagnetic != 0)
            {
                s += "Base Magnetic Damage: " + stats.baseMagnetic + "\n";
            }
            if (stats.baseGas != 0)
            {
                s += "Base Gas Damage: " + stats.baseGas + "\n";
            }

            if (stats.baseDamage != 0)
            {
                s += "Base Damage Increase: " + stats.baseDamage + "\n";
            }
            if (stats.baseDamagePercentage != 0)
            {
                s += "Base Damage Percentage: " + stats.baseDamagePercentage + "%\n";
            }

            if (stats.baseAttackSpeed != 0)
            {
                s += "Base Attack Speed: " + stats.baseAttackSpeed + "\n";
            }
            if (stats.baseChargeTime != 0)
            {
                s += "Base Charge Time: " + stats.baseChargeTime + "s\n";
            }
            if (stats.baseMagazine != 0)
            {
                s += "Base Magazine: " + stats.baseMagazine + "\n";
            }
            if (stats.baseAmmoEfficiency != 0)
            {
                s += "Base Ammo Efficiency: " + stats.baseAmmoEfficiency + "%\n";
            }
            if (stats.baseReloadTime != 0 && stats.ammoRegen != 0)
            {
                s += "Base Reload Delay: " + stats.baseReloadTime + "s\n";
            }
            else if (stats.baseReloadTime != 0)
            {
                s += "Base Reload Time: " + stats.baseReloadTime + "s\n";
            }
            if (stats.ammoRegen != 0)
            {
                s += "Ammo Regen: " + stats.ammoRegen + "/s\n";
            }


            if (stats.baseMultishot != 0)
            {
                s += "Base Multishot: " + stats.baseMultishot + "\n";
            }

            if (stats.baseCriticalChance != 0)
            {
                s += "Base Critical Chance: " + stats.baseCriticalChance + "%\n";
            }
            if (stats.baseCriticalDamage != 0)
            {
                s += "Base Critical Damage: " + stats.baseCriticalDamage + "x\n";
            }

            if (stats.baseStatusChance != 0)
            {
                s += "Base Status Chance: " + stats.baseStatusChance + "%\n";
            }
            if (stats.baseStatusDamage != 0)
            {
                s += "Base Status Damage: " + stats.baseStatusDamage + "\n";
            }
            if (stats.baseReserveAmmo != 0)
            {
                s += "Base Reserve Ammo: " + stats.baseReserveAmmo + "\n";
            }


            if (stats.modDamage != 0)
            {
                s += "Mod Damage: " + stats.modDamage + "%\n";
            }
            if (stats.modDamagePercentage != 0)
            {
                s += "Mod Damage Percentage: " + stats.modDamagePercentage + "%\n";
            }
            if (stats.modDamageFaction != 0)
            {
                s += "Mod Damage Faction: " + stats.modDamageFaction + "%\n";
            }



            if (stats.modSlash != 0)
            {
                s += "Mod Slash: " + stats.modSlash + "%\n";
            }
            if (stats.modImpact != 0)
            {
                s += "Mod Impact: " + stats.modImpact + "%\n";
            }
            if (stats.modPuncture != 0)
            {
                s += "Mod Puncture: " + stats.modPuncture + "%\n";
            }

            if (stats.modHeat != 0)
            {
                s += "Mod Heat: " + stats.modHeat + "%\n";
            }
            if (stats.modCold != 0)
            {
                s += "Mod Cold: " + stats.modCold + "%\n";
            }
            if (stats.modElectric != 0)
            {
                s += "Mod Electric: " + stats.modElectric + "%\n";
            }
            if (stats.modToxin != 0)
            {
                s += "Mod Toxin: " + stats.modToxin + "%\n";
            }

            if (stats.modBlast != 0)
            {
                s += "Mod Blast: " + stats.modBlast + "%\n";
            }
            if (stats.modRadiation != 0)
            {
                s += "Mod Radiation: " + stats.modRadiation + "%\n";
            }
            if (stats.modViral != 0)
            {
                s += "Mod Viral: " + stats.modViral + "%\n";
            }
            if (stats.modCorrosive != 0)
            {
                s += "Mod Corrosive: " + stats.modCorrosive + "%\n";
            }
            if (stats.modMagnetic != 0)
            {
                s += "Mod Magnetic: " + stats.modMagnetic + "%\n";
            }
            if (stats.modGas != 0)
            {
                s += "Mod Gas: " + stats.modGas + "%\n";
            }

            if (stats.modMultishot != 0)
            {
                s += "Mod Multishot: " + stats.modMultishot + "%\n";
            }

            if (stats.modAttackSpeed != 0)
            {
                s += "Mod Attack Speed: " + stats.modAttackSpeed + "%\n";
            }

            if (stats.modMagazine != 0)
            {
                s += "Mod Magazine: " + stats.modMagazine + "%\n";
            }
            if (stats.modReloadTime != 0)
            {
                s += "Mod Reload Speed: " + stats.modReloadTime + "%\n";
            }
            if (stats.modAmmoEfficiency != 0)
            {
                s += "Mod Ammo Efficiency: " + stats.modAmmoEfficiency + "%\n";
            }
            if (stats.modChargeTime != 0)
            {
                s += "Mod Charge Time: " + stats.modChargeTime + "%\n";
            }

            if (stats.modCriticalChance != 0)
            {
                s += "Mod Critical Chance: " + stats.modCriticalChance + "%\n";
            }
            if (stats.modCriticalDamage != 0)
            {
                s += "Mod Critical Damage: " + stats.modCriticalDamage + "%\n";
            }

            if (stats.modStatusChance != 0)
            {
                s += "Mod Status Chance: " + stats.modStatusChance + "%\n";
            }
            if (stats.modStatusDamage != 0)
            {
                s += "Mod Status Damage: " + stats.modStatusDamage + "%\n";
            }
            if (stats.modReserveAmmo != 0)
            {
                s += "Mod Reserve Ammo: " + stats.modReserveAmmo + "%\n";
            }

            if (stats.finalDamage != 0)
            {
                s += "Final Damage: " + stats.finalDamage + "\n";
            }

            if (stats.tags.Contains("Multishot_Exclusive_Damage_Mult") && stats.finalDamagePercentage != 0)
            { 
                s += "Multishot Damage Multiplier: " + (stats.finalDamagePercentage / 100 + 1) + "x\n";
            } else if (stats.tags.Contains("Extra_Hit") && stats.finalDamagePercentage != 0)
            {
                s += "Extra Hit: " + stats.finalDamagePercentage + "%\n";
            }
            else if (stats.finalDamagePercentage != 0)
            {
                s += "Damage Multiplier: " + (stats.finalDamagePercentage / 100 + 1) + "x\n";
            }

            if (stats.finalAttackSpeed != 0)
            {
                s += "Attack Speed Multiplier: " + (stats.finalAttackSpeed / 100 + 1) + "x\n";
            }

            if (stats.finalReloadTime != 0)
            {
                s += "Final Reload Time: " + stats.finalReloadTime + "s\n";
            }
            if (stats.finalMagazine != 0)
            {
                s += "Final Magazine: " + stats.finalMagazine + "\n";
            }
            if (stats.finalAmmoEfficiency != 0)
            {
                s += "Final Ammo Efficiency: " + stats.finalAmmoEfficiency + "%\n";
            }
            if (stats.finalChargeTime != 0)
            {
                s += "Final Charge Time: " + stats.finalChargeTime + "s\n";
            }

            if (stats.finalSlash != 0)
            {
                s += "Final Slash: " + stats.finalSlash + "\n";
            }
            if (stats.finalImpact != 0)
            {
                s += "Final Impact: " + stats.finalImpact + "\n";
            }
            if (stats.finalPuncture != 0)
            {
                s += "Final Puncture: " + stats.finalPuncture + "\n";
            }

            if (stats.finalHeat != 0)
            {
                s += "Final Heat: " + stats.finalHeat + "\n";
            }
            if (stats.finalCold != 0)
            {
                s += "Final Cold: " + stats.finalCold + "\n";
            }
            if (stats.finalElectric != 0)
            {
                s += "Final Electric: " + stats.finalElectric + "\n";
            }
            if (stats.finalToxin != 0)
            {
                s += "Final Toxin: " + stats.finalToxin + "\n";
            }

            if (stats.finalBlast != 0)
            {
                s += "Final Blast: " + stats.finalBlast + "\n";
            }
            if (stats.finalRadiation != 0)
            {
                s += "Final Radiation: " + stats.finalRadiation + "\n";
            }
            if (stats.finalViral != 0)
            {
                s += "Final Viral: " + stats.finalViral + "\n";
            }
            if (stats.finalCorrosive != 0)
            {
                s += "Final Corrosive: " + stats.finalCorrosive + "\n";
            }
            if (stats.finalMagnetic != 0)
            {
                s += "Final Magnetic: " + stats.finalMagnetic + "\n";
            }
            if (stats.finalGas != 0)
            {
                s += "Final Gas: " + stats.finalGas + "\n";
            }

            if (stats.finalMultishot != 0)
            {
                s += "Final Multishot: " + stats.finalMultishot + "\n";
            }

            if (stats.finalCriticalChance != 0)
            {
                s += "Final Critical Chance: " + stats.finalCriticalChance + "%\n";
            }
            if (stats.finalCriticalDamage != 0)
            {
                s += "Final Critical Damage: " + stats.finalCriticalDamage + "x\n";
            }

            if (stats.finalStatusChance != 0)
            {
                s += "Final Status Chance: " + stats.finalStatusChance + "%\n";
            }
            if (stats.finalStatusDamage != 0)
            {
                s += "Final Status Damage: " + stats.finalStatusDamage + "\n";
            }

            return s;
        }
    }
}
