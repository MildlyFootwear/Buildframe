using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildframe.GameData
{
    public class Stats
    {

        public string id = "";
        public string name = "";
        public string tags = "";
        public string description = "";

        public bool incarnon = false;

        // This section is used for base stats, such as weapons and most incarnon perks.

        public double baseDamage = 0; // Only use if no other category applies.
        public double baseDamagePercentage = 0; // Only use if no other category applies.

        public double baseAttackSpeed = 0;

        public double baseReloadTime = 0;
        public double baseAmmoEfficiency = 0;
        public double baseMagazine = 0;
        public double baseChargeTime = 0;

        public double baseImpact = 0;
        public double basePuncture = 0;
        public double baseSlash = 0;

        public double baseFire = 0;
        public double baseCold = 0;
        public double baseElectric = 0;
        public double baseToxin = 0;

        public double baseBlast = 0;
        public double baseRadiation = 0;
        public double baseViral = 0;
        public double baseCorrosive = 0;
        public double baseMagnetic = 0;
        public double baseGas = 0;

        public double baseMultishot = 0;

        public double baseCriticalChance = 0;
        public double baseCriticalDamage = 0;

        public double baseStatusChance = 0;
        public double baseStatusDamage = 0;



        // This section is used for additive stats, such as mods and most arcanes.

        public double modDamage = 0;
        public double modDamagePercentage = 0;
        public double modDamageFaction = 0;

        public double modAttackSpeed = 0;

        public double modReloadTime = 0;
        public double modMagazine = 0;
        public double modAmmoEfficiency = 0;
        public double modChargeTime = 0;

        public double modSlash = 0;
        public double modImpact = 0;
        public double modPuncture = 0;

        public double modFire = 0;
        public double modCold = 0;
        public double modElectric = 0;
        public double modToxin = 0;

        public double modBlast = 0;
        public double modRadiation = 0;
        public double modViral = 0;
        public double modCorrosive = 0;
        public double modMagnetic = 0;
        public double modGas = 0;

        public double modMultishot = 0;

        public double modCriticalChance = 0;
        public double modCriticalDamage = 0;

        public double modStatusChance = 0;
        public double modStatusDamage = 0;



        // This section is used for final stats, such as Arcane Crepuscular and some status effects.

        public double finalDamage = 0;
        public double finalDamagePercentage = 0;

        public double finalAttackSpeed = 0;

        public double finalReloadTime = 0;
        public double finalMagazine = 0;
        public double finalAmmoEfficiency = 0;
        public double finalChargeTime = 0;

        public double finalSlash = 0;
        public double finalImpact = 0;
        public double finalPuncture = 0;

        public double finalFire = 0;
        public double finalCold = 0;
        public double finalElectric = 0;
        public double finalToxin = 0;

        public double finalBlast = 0;
        public double finalRadiation = 0;
        public double finalViral = 0;
        public double finalCorrosive = 0;
        public double finalMagnetic = 0;
        public double finalGas = 0;

        public double finalMultishot = 0;

        public double finalCriticalChance = 0;
        public double finalCriticalDamage = 0;

        public double finalStatusChance = 0;
        public double finalStatusDamage = 0;

        public override string ToString()
        {
            return name;
        }
    }
}
