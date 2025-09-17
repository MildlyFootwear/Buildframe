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
        public static Stats sumStats(List<Stats> statsList)
        {
            if (statsList.Count == 0)
            {
                return new Stats();
            }
            Stats stats = new Stats();

            stats.name = statsList[0].name;

            foreach (Stats s  in statsList) {
                if (s.incarnon)
                {
                    stats.incarnon = true;
                }
            }

            foreach (Stats s in statsList)
            {

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
                if (!stats.incarnon)
                {
                    stats.modMagazine += s.modMagazine;
                    stats.modAmmoEfficiency += s.modAmmoEfficiency;
                }
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
                if (!stats.incarnon)
                {
                    stats.finalMagazine += s.finalMagazine;
                    stats.finalAmmoEfficiency += s.finalAmmoEfficiency;

                }
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


    }

}
