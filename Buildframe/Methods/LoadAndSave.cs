using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildframe.Methods
{
    public class LoadAndSave
    {
        public static void loadStatFileTo(string path, List<GameData.Stats> destination)
        {
            GameData.Stats stats = new GameData.Stats();

            foreach (string s in File.ReadAllLines(path))
            {
                string[] split = s.Split('=');

                if (split[0] == "name")
                    stats.name = split[1];
                if (split[0] == "description")
                    stats.description = split[1];
                if (split[0] == "id")
                    stats.id = split[1];
                if (split[0] == "incarnon")
                    stats.incarnon = Convert.ToBoolean(split[1]);

                if (split[0] == "baseDamage")
                    stats.baseDamage = Convert.ToDouble(split[1]);
                if (split[0] == "baseDamagePercentage")
                    stats.baseDamagePercentage = Convert.ToDouble(split[1]);

                if (split[0] == "baseAttackSpeed")
                    stats.baseAttackSpeed = Convert.ToDouble(split[1]);

                if (split[0] == "baseReloadTime")
                    stats.baseReloadTime = Convert.ToDouble(split[1]);
                if (split[0] == "baseMagazine")
                    stats.baseMagazine = Convert.ToDouble(split[1]);
                if (split[0] == "baseAmmoEfficiency")
                    stats.baseAmmoEfficiency = Convert.ToDouble(split[1]);
                if (split[0] == "baseChargeTime")
                    stats.baseChargeTime = Convert.ToDouble(split[1]);

                if (split[0] == "baseSlash")
                    stats.baseSlash = Convert.ToDouble(split[1]);
                if (split[0] == "baseImpact")
                    stats.baseImpact = Convert.ToDouble(split[1]);
                if (split[0] == "basePuncture")
                    stats.basePuncture = Convert.ToDouble(split[1]);

                if (split[0] == "baseFire")
                    stats.baseFire = Convert.ToDouble(split[1]);
                if (split[0] == "baseCold")
                    stats.baseCold = Convert.ToDouble(split[1]);
                if (split[0] == "baseElectric")
                    stats.baseElectric = Convert.ToDouble(split[1]);
                if (split[0] == "baseToxin")
                    stats.baseToxin = Convert.ToDouble(split[1]);

                if (split[0] == "baseBlast")
                    stats.baseBlast = Convert.ToDouble(split[1]);
                if (split[0] == "baseRadiation")
                    stats.baseRadiation = Convert.ToDouble(split[1]);
                if (split[0] == "baseViral")
                    stats.baseViral = Convert.ToDouble(split[1]);
                if (split[0] == "baseCorrosive")
                    stats.baseCorrosive = Convert.ToDouble(split[1]);
                if (split[0] == "baseMagnetic")
                    stats.baseMagnetic = Convert.ToDouble(split[1]);
                if (split[0] == "baseGas")
                    stats.baseGas = Convert.ToDouble(split[1]);

                if (split[0] == "baseMultishot")
                    stats.baseMultishot = Convert.ToDouble(split[1]);

                if (split[0] == "baseCriticalChance")
                    stats.baseCriticalChance = Convert.ToDouble(split[1]);
                if (split[0] == "baseCriticalDamage")
                    stats.baseCriticalDamage = Convert.ToDouble(split[1]);

                if (split[0] == "baseStatusChance")
                    stats.baseStatusChance = Convert.ToDouble(split[1]);
                if (split[0] == "baseStatusDamage")
                    stats.baseStatusDamage = Convert.ToDouble(split[1]);



                if (split[0] == "modDamage")
                    stats.modDamage = Convert.ToDouble(split[1]);
                if (split[0] == "modDamagePercentage")
                    stats.modDamagePercentage = Convert.ToDouble(split[1]);
                if (split[0] == "modDamageFaction")
                    stats.modDamageFaction = Convert.ToDouble(split[1]);

                if (split[0] == "modAttackSpeed")
                    stats.modAttackSpeed = Convert.ToDouble(split[1]);

                if (split[0] == "modReloadTime")
                    stats.modReloadTime = Convert.ToDouble(split[1]);
                if (split[0] == "modMagazine")
                    stats.modMagazine = Convert.ToDouble(split[1]);
                if (split[0] == "modAmmoEfficiency")
                    stats.modAmmoEfficiency = Convert.ToDouble(split[1]);
                if (split[0] == "modChargeTime")
                    stats.modChargeTime = Convert.ToDouble(split[1]);

                if (split[0] == "modSlash")
                    stats.modSlash = Convert.ToDouble(split[1]);
                if (split[0] == "modImpact")
                    stats.modImpact = Convert.ToDouble(split[1]);
                if (split[0] == "modPuncture")
                    stats.modPuncture = Convert.ToDouble(split[1]);

                if (split[0] == "modFire")
                    stats.modFire = Convert.ToDouble(split[1]);
                if (split[0] == "modCold")
                    stats.modCold = Convert.ToDouble(split[1]);
                if (split[0] == "modElectric")
                    stats.modElectric = Convert.ToDouble(split[1]);
                if (split[0] == "modToxin")
                    stats.modToxin = Convert.ToDouble(split[1]);

                if (split[0] == "modBlast")
                    stats.modBlast = Convert.ToDouble(split[1]);
                if (split[0] == "modRadiation")
                    stats.modRadiation = Convert.ToDouble(split[1]);
                if (split[0] == "modViral")
                    stats.modViral = Convert.ToDouble(split[1]);
                if (split[0] == "modCorrosive")
                    stats.modCorrosive = Convert.ToDouble(split[1]);
                if (split[0] == "modMagnetic")
                    stats.modMagnetic = Convert.ToDouble(split[1]);
                if (split[0] == "modGas")
                    stats.modGas = Convert.ToDouble(split[1]);

                if (split[0] == "modMultishot")
                    stats.modMultishot = Convert.ToDouble(split[1]);

                if (split[0] == "modCriticalChance")
                    stats.modCriticalChance = Convert.ToDouble(split[1]);
                if (split[0] == "modCriticalDamage")
                    stats.modCriticalDamage = Convert.ToDouble(split[1]);

                if (split[0] == "modStatusChance")
                    stats.modStatusChance = Convert.ToDouble(split[1]);
                if (split[0] == "modStatusDamage")
                    stats.modStatusDamage = Convert.ToDouble(split[1]);





                if (split[0] == "finalDamage")
                    stats.finalDamage = Convert.ToDouble(split[1]);
                if (split[0] == "finalDamagePercentage")
                    stats.finalDamagePercentage = Convert.ToDouble(split[1]);

                if (split[0] == "finalAttackSpeed")
                    stats.finalAttackSpeed = Convert.ToDouble(split[1]);

                if (split[0] == "finalReloadTime")
                    stats.finalReloadTime = Convert.ToDouble(split[1]);
                if (split[0] == "finalMagazine")
                    stats.finalMagazine = Convert.ToDouble(split[1]);
                if (split[0] == "finalAmmoEfficiency")
                    stats.finalAmmoEfficiency = Convert.ToDouble(split[1]);
                if (split[0] == "finalChargeTime")
                    stats.finalChargeTime = Convert.ToDouble(split[1]);

                if (split[0] == "finalSlash")
                    stats.finalSlash = Convert.ToDouble(split[1]);
                if (split[0] == "finalImpact")
                    stats.finalImpact = Convert.ToDouble(split[1]);
                if (split[0] == "finalPuncture")
                    stats.finalPuncture = Convert.ToDouble(split[1]);

                if (split[0] == "finalFire")
                    stats.finalFire = Convert.ToDouble(split[1]);
                if (split[0] == "finalCold")
                    stats.finalCold = Convert.ToDouble(split[1]);
                if (split[0] == "finalElectric")
                    stats.finalElectric = Convert.ToDouble(split[1]);
                if (split[0] == "finalToxin")
                    stats.finalToxin = Convert.ToDouble(split[1]);

                if (split[0] == "finalBlast")
                    stats.finalBlast = Convert.ToDouble(split[1]);
                if (split[0] == "finalRadiation")
                    stats.finalRadiation = Convert.ToDouble(split[1]);
                if (split[0] == "finalViral")
                    stats.finalViral = Convert.ToDouble(split[1]);
                if (split[0] == "finalCorrosive")
                    stats.finalCorrosive = Convert.ToDouble(split[1]);
                if (split[0] == "finalMagnetic")
                    stats.finalMagnetic = Convert.ToDouble(split[1]);
                if (split[0] == "finalGas")
                    stats.finalGas = Convert.ToDouble(split[1]);

                if (split[0] == "finalMultishot")
                    stats.finalMultishot = Convert.ToDouble(split[1]);

                if (split[0] == "finalCriticalChance")
                    stats.finalCriticalChance = Convert.ToDouble(split[1]);
                if (split[0] == "finalCriticalDamage")
                    stats.finalCriticalDamage = Convert.ToDouble(split[1]);

                if (split[0] == "finalStatusChance")
                    stats.finalStatusChance = Convert.ToDouble(split[1]);
                if (split[0] == "finalStatusDamage")
                    stats.finalStatusDamage = Convert.ToDouble(split[1]);
            }
        }

        public static void saveStatToFile(string path, GameData.Stats stats)
        {
            string s = "";

            s += "name=" + stats.name;
            s += "\ndescription=" + stats.description;
            s += "\nid=" + stats.id;
            s += "\nincarnon=" + Convert.ToString(stats.incarnon);

            s += "\nbaseDamage=" + Convert.ToString(stats.baseDamage);
            s += "\nbaseDamagePercentage=" + Convert.ToString(stats.baseDamagePercentage);

            s += "\nbaseAttackSpeed=" + Convert.ToString(stats.baseAttackSpeed);

            s += "\nbaseReloadTime=" + Convert.ToString(stats.baseReloadTime);
            s += "\nbaseAmmoEfficiency=" + Convert.ToString(stats.baseAmmoEfficiency);
            s += "\nbaseChargeTime=" + Convert.ToString(stats.baseChargeTime);

            s += "\nbaseSlash=" + Convert.ToString(stats.baseSlash);
            s += "\nbaseImpact=" + Convert.ToString(stats.baseImpact);
            s += "\nbasePuncture=" + Convert.ToString(stats.basePuncture);

            s += "\nbaseFire=" + Convert.ToString(stats.baseFire);
            s += "\nbaseCold=" + Convert.ToString(stats.baseCold);
            s += "\nbaseElectric=" + Convert.ToString(stats.baseElectric);
            s += "\nbaseToxin=" + Convert.ToString(stats.baseToxin);

            s += "\nbaseBlast=" + Convert.ToString(stats.baseBlast);
            s += "\nbaseRadiation=" + Convert.ToString(stats.baseRadiation);
            s += "\nbaseViral=" + Convert.ToString(stats.baseViral);
            s += "\nbaseCorrosive=" + Convert.ToString(stats.baseCorrosive);
            s += "\nbaseMagnetic=" + Convert.ToString(stats.baseMagnetic);
            s += "\nbaseGas=" + Convert.ToString(stats.baseGas);

            s += "\nbaseMultishot=" + Convert.ToString(stats.baseMultishot);

            s += "\nbaseCriticalChance=" + Convert.ToString(stats.baseCriticalChance);
            s += "\nbaseCriticalDamage=" + Convert.ToString(stats.baseCriticalDamage);

            s += "\nbaseStatusChance=" + Convert.ToString(stats.baseStatusChance);
            s += "\nbaseStatusDamage=" + Convert.ToString(stats.baseStatusDamage);



            s += "\nmodDamage=" + Convert.ToString(stats.modDamage);
            s += "\nmodDamagePercentage=" + Convert.ToString(stats.modDamagePercentage);
            s += "\nmodDamageFaction=" + Convert.ToString(stats.modDamageFaction);

            s += "\nmodAttackSpeed=" + Convert.ToString(stats.modAttackSpeed);

            s += "\nmodReloadTime=" + Convert.ToString(stats.modReloadTime);
            s += "\nmodAmmoEfficiency=" + Convert.ToString(stats.modAmmoEfficiency);
            s += "\nmodChargeTime=" + Convert.ToString(stats.modChargeTime);

            s += "\nmodSlash=" + Convert.ToString(stats.modSlash);
            s += "\nmodImpact=" + Convert.ToString(stats.modImpact);
            s += "\nmodPuncture=" + Convert.ToString(stats.modPuncture);

            s += "\nmodFire=" + Convert.ToString(stats.modFire);
            s += "\nmodCold=" + Convert.ToString(stats.modCold);
            s += "\nmodElectric=" + Convert.ToString(stats.modElectric);
            s += "\nmodToxin=" + Convert.ToString(stats.modToxin);

            s += "\nmodBlast=" + Convert.ToString(stats.modBlast);
            s += "\nmodRadiation=" + Convert.ToString(stats.modRadiation);
            s += "\nmodViral=" + Convert.ToString(stats.modViral);
            s += "\nmodCorrosive=" + Convert.ToString(stats.modCorrosive);
            s += "\nmodMagnetic=" + Convert.ToString(stats.modMagnetic);
            s += "\nmodGas=" + Convert.ToString(stats.modGas);

            s += "\nmodMultishot=" + Convert.ToString(stats.modMultishot);

            s += "\nmodCriticalChance=" + Convert.ToString(stats.modCriticalChance);
            s += "\nmodCriticalDamage=" + Convert.ToString(stats.modCriticalDamage);

            s += "\nmodStatusChance=" + Convert.ToString(stats.modStatusChance);
            s += "\nmodStatusDamage=" + Convert.ToString(stats.modStatusDamage);



            s += "\nfinalDamage=" + Convert.ToString(stats.finalDamage);
            s += "\nfinalDamagePercentage=" + Convert.ToString(stats.finalDamagePercentage);

            s += "\nfinalAttackSpeed=" + Convert.ToString(stats.finalAttackSpeed);

            s += "\nfinalReloadTime=" + Convert.ToString(stats.finalReloadTime);
            s += "\nfinalAmmoEfficiency=" + Convert.ToString(stats.finalAmmoEfficiency);
            s += "\nfinalChargeTime=" + Convert.ToString(stats.finalChargeTime);

            s += "\nfinalSlash=" + Convert.ToString(stats.finalSlash);
            s += "\nfinalImpact=" + Convert.ToString(stats.finalImpact);
            s += "\nfinalPuncture=" + Convert.ToString(stats.finalPuncture);

            s += "\nfinalFire=" + Convert.ToString(stats.finalFire);
            s += "\nfinalCold=" + Convert.ToString(stats.finalCold);
            s += "\nfinalElectric=" + Convert.ToString(stats.finalElectric);
            s += "\nfinalToxin=" + Convert.ToString(stats.finalToxin);

            s += "\nfinalBlast=" + Convert.ToString(stats.finalBlast);
            s += "\nfinalRadiation=" + Convert.ToString(stats.finalRadiation);
            s += "\nfinalViral=" + Convert.ToString(stats.finalViral);
            s += "\nfinalCorrosive=" + Convert.ToString(stats.finalCorrosive);
            s += "\nfinalMagnetic=" + Convert.ToString(stats.finalMagnetic);
            s += "\nfinalGas=" + Convert.ToString(stats.finalGas);

            s += "\nfinalMultishot=" + Convert.ToString(stats.finalMultishot);

            s += "\nfinalCriticalChance=" + Convert.ToString(stats.finalCriticalChance);
            s += "\nfinalCriticalDamage=" + Convert.ToString(stats.finalCriticalDamage);

            s += "\nfinalStatusChance=" + Convert.ToString(stats.finalStatusChance);
            s += "\nfinalStatusDamage=" + Convert.ToString(stats.finalStatusDamage);

            File.WriteAllText(path, s);

        }

    }
}
