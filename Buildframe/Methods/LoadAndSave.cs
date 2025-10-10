using Buildframe.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Buildframe.Methods
{
    public class LoadAndSave
    {

        public static string cleanFileName(string name)
        {
            string cleanName = name;

            foreach (string s in CommonVars.ProhibPathChars)
            {
                cleanName = cleanName.Replace(s, "");
            }
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                string s = c.ToString();
                cleanName = cleanName.Replace(s, "");
            }

            return cleanName;
        }

        public static StatsData loadStatFromFile(string path)
        {
            StatsData stats = new StatsData();

            bool resaveToConvert = false; // this will be set to true if there is an indicator of it needing to be updated to the current format for stat files

            string directory = Path.GetDirectoryName(path.Replace(envAPPLOC, ""));

            if (!directory.Contains("Arcanes") && !directory.Contains("FireModes") && !directory.Contains("Misc") && !directory.Contains("Mods"))
            {
                WriteLineIfDebug("\nFile load error: not in stat directory:\n"+path + "\n\n");
                return stats;
            }

            foreach (string s in File.ReadAllLines(path))
            {
                string[] split = s.Split('=');

                if (split[0] == "name")
                    stats.name = split[1];
                if (split[0] == "description")
                    stats.description = split[1].Replace("[NEW LINE]", "\r\n");
                if (split[0] == "id")
                    stats.id = split[1];
                if (split[0] == "tags")
                    stats.tags = split[1];
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
                {
                    stats.baseHeat = Convert.ToDouble(split[1]);
                    resaveToConvert = true;
                }
                if (split[0] == "baseHeat")
                    stats.baseHeat = Convert.ToDouble(split[1]);

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
                {
                    stats.modHeat = Convert.ToDouble(split[1]);
                    resaveToConvert = true;
                }
                if (split[0] == "modHeat")
                    stats.modHeat = Convert.ToDouble(split[1]);
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
                {
                    stats.finalHeat = Convert.ToDouble(split[1]);
                    resaveToConvert = true;
                }
                if (split[0] == "finalHeat")
                    stats.finalHeat = Convert.ToDouble(split[1]);
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

            if (resaveToConvert)
            {
                WriteLineIfDebug(path + " needed to be updated and is being resaved");
                saveStatToFile(path, stats);
            }

            if (Path.GetFileName(path).StartsWith(stats.id))
            {
                WriteLineIfDebug("Filename starts with ID, converting");
                File.Delete(path);
                saveStatToFile(path.Replace(Path.GetFileName(path), cleanFileName(stats.name + " - " + stats.id + ".cfg")), stats);
            }

            return stats;
        }

        public static void saveStatToFile(string path, GameData.StatsData stats)
        {
            WriteLineIfDebug("Saving stat file: " + path);

            string s = "";

            s += "name=" + stats.name;
            s += "\ndescription=" + stats.description.Replace("\r\n", "[NEW LINE]");
            s += "\nid=" + stats.id;
            s += "\nincarnon=" + Convert.ToString(stats.incarnon);
            s += "\ntags=" + stats.tags;

            s += "\nbaseDamage=" + Convert.ToString(stats.baseDamage);
            s += "\nbaseDamagePercentage=" + Convert.ToString(stats.baseDamagePercentage);

            s += "\nbaseAttackSpeed=" + Convert.ToString(stats.baseAttackSpeed);

            s += "\nbaseReloadTime=" + Convert.ToString(stats.baseReloadTime);
            s += "\nbaseAmmoEfficiency=" + Convert.ToString(stats.baseAmmoEfficiency);
            s += "\nbaseChargeTime=" + Convert.ToString(stats.baseChargeTime);
            s += "\nbaseMagazine=" + Convert.ToString(stats.baseMagazine);

            s += "\nbaseSlash=" + Convert.ToString(stats.baseSlash);
            s += "\nbaseImpact=" + Convert.ToString(stats.baseImpact);
            s += "\nbasePuncture=" + Convert.ToString(stats.basePuncture);

            s += "\nbaseHeat=" + Convert.ToString(stats.baseHeat);
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
            s += "\nmodMagazine=" + Convert.ToString(stats.modMagazine);


            s += "\nmodSlash=" + Convert.ToString(stats.modSlash);
            s += "\nmodImpact=" + Convert.ToString(stats.modImpact);
            s += "\nmodPuncture=" + Convert.ToString(stats.modPuncture);

            s += "\nmodHeat=" + Convert.ToString(stats.modHeat);
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
            s += "\nfinalMagazine=" + Convert.ToString(stats.finalMagazine);

            s += "\nfinalSlash=" + Convert.ToString(stats.finalSlash);
            s += "\nfinalImpact=" + Convert.ToString(stats.finalImpact);
            s += "\nfinalPuncture=" + Convert.ToString(stats.finalPuncture);

            s += "\nfinalHeat=" + Convert.ToString(stats.finalHeat);
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

            if (Path.GetDirectoryName(path) != null && Path.GetDirectoryName(path) != string.Empty)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            File.WriteAllText(path, s);

        }

        public static void saveWeaponToFile(string path, GameData.WeaponData weapon)
        {
            string s = "";
            s += "name=" + weapon.name;
            s += "\ndescription=" + weapon.description.Replace("\r\n", "[NEW LINE]");
            s += "\nid=" + weapon.id;
            s += "\ntags=" + weapon.tags;
            s += "\nfireModes=";
            foreach (StatsData stats in weapon.fireModes)
            {
                s += stats.id + ",";
            }
            s += "\nfireModesRadials=";
            foreach (KeyValuePair<string, StatsData> pair in weapon.fireModesRadials)
            {
                s += pair.Key + ":" + pair.Value.id + ",";
            }

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            File.WriteAllText(path, s);
        }

        public static WeaponData loadWeaponFromFile(string path)
        {
            WeaponData weapon = new WeaponData();
            if (!Path.GetDirectoryName(path.Replace(envAPPLOC, "")).Contains("Weapon"))
            {
                WriteLineIfDebug("\nFile load error: not in weapon directory:\n" + path + "\n\n");
                return weapon;
            }
            foreach (string s in File.ReadAllLines(path))
            {
                string[] split = s.Split('=');
                
                if (split[0] == "name")
                    weapon.name = split[1];
                if (split[0] == "description")
                    weapon.description = split[1].Replace("[NEW LINE]", "\r\n");
                if (split[0] == "id")
                    weapon.id = split[1];
                if (split[0] == "tags")
                    weapon.tags = split[1];

                if (split[0] == "fireModes")
                {
                    foreach (string fm in split[1].Split(','))
                    {
                        if (fm != "" && fireModeStats.ContainsKey(fm))
                            weapon.fireModes.Add(fireModeStats[fm]);
                    }
                }
                if (split[0] == "fireModesRadials")
                {
                    foreach (string fm in split[1].Split(','))
                    {
                        if (fm != "")
                        {
                            string[] fmsplit = fm.Split(':');
                            if (fmsplit.Length == 2 && fireModeStats.ContainsKey(fmsplit[1]))
                                weapon.fireModesRadials.Add(fmsplit[0], fireModeStats[fmsplit[1]]);
                        }
                    }
                }
            }

            if (Path.GetFileName(path).StartsWith(weapon.id))
            {
                WriteLineIfDebug("Filename starts with ID, converting");
                File.Delete(path);
                saveWeaponToFile(path.Replace(Path.GetFileName(path), cleanFileName(weapon.name + " - " + weapon.id + ".cfg")), weapon);
            }

            return weapon;
        }

        public static void loadArcaneFiles()
        {
            arcaneStats.Clear();
            string directory = Path.Combine(envAPPLOC, "Data", "Arcanes");
            Directory.CreateDirectory(directory);
            foreach (string file in Directory.GetFiles(directory, "*.cfg"))
            {
                WriteLineIfDebug("Loading arcane file: " + file.Replace(envAPPLOC, ""), DebuggingLoading);
                StatsData stats = loadStatFromFile(file);
                if (arcaneStats.ContainsKey(stats.id))
                {
                    MessageBox.Show("Duplicate ID found: " + stats.id + "\nFile " + file + "\n\nBehavior may be erratic until the file is deleted or ID is changed.", "Buildframe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                arcaneStats.Add(stats.id, stats);
            }
            arcaneStats = arcaneStats.OrderBy(x => x.Value.name).ToDictionary(x => x.Key, x => x.Value);
        }

        public static void loadModFiles()
        {
            modStats.Clear();
            string directory = Path.Combine(envAPPLOC, "Data", "Mods");
            Directory.CreateDirectory(directory);
            foreach (string file in Directory.GetFiles(directory, "*.cfg"))
            {
                WriteLineIfDebug("Loading mod file: " + file.Replace(envAPPLOC, ""), DebuggingLoading);
                StatsData stats = loadStatFromFile(file);
                if (modStats.ContainsKey(stats.id))
                {
                    MessageBox.Show("Duplicate ID found: " + stats.id + "\nFile " + file + "\n\nBehavior may be erratic until the file is deleted or ID is changed.", "Buildframe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                modStats.Add(stats.id, stats);
            }
            modStats = modStats.OrderBy(x => x.Value.name).ToDictionary(x => x.Key, x => x.Value);
        }

        public static void loadMiscFiles()
        {
            miscStats.Clear();
            string directory = Path.Combine(envAPPLOC, "Data", "Misc");
            Directory.CreateDirectory(directory);
            foreach (string file in Directory.GetFiles(directory, "*.cfg"))
            {
                WriteLineIfDebug("Loading misc file: " + file.Replace(envAPPLOC, ""), DebuggingLoading);
                StatsData stats = loadStatFromFile(file);
                if (miscStats.ContainsKey(stats.id))
                {
                    MessageBox.Show("Duplicate ID found: " + stats.id + "\nFile " + file + "\n\nBehavior may be erratic until the file is deleted or ID is changed.", "Buildframe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                miscStats.Add(stats.id, stats);
            }
            miscStats = miscStats.OrderBy(x => x.Value.name).ToDictionary(x => x.Key, x => x.Value);
        }

        public static void loadFireModeFiles()
        {
            fireModeStats.Clear();
            string directory = Path.Combine(envAPPLOC, "Data", "FireModes");
            Directory.CreateDirectory(directory);
            foreach (string file in Directory.GetFiles(directory, "*.cfg"))
            {
                WriteLineIfDebug("Loading fire mode file: " + file.Replace(envAPPLOC, ""), DebuggingLoading);
                StatsData stats = loadStatFromFile(file);
                if (fireModeStats.ContainsKey(stats.id))
                {
                    MessageBox.Show("Duplicate ID found: " + stats.id + "\nFile " + file + "\n\nBehavior may be erratic until the file is deleted or ID is changed.", "Buildframe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                fireModeStats.Add(stats.id, stats);
            }
            fireModeStats = fireModeStats.OrderBy(x => x.Value.name).ToDictionary(x => x.Key, x => x.Value);
        }

        public static void loadWeaponFiles()
        {
            weaponStats.Clear();
            string directory = Path.Combine(envAPPLOC, "Data", "Weapons");
            Directory.CreateDirectory(directory);
            foreach (string file in Directory.GetFiles(directory, "*.cfg"))
            {
                WriteLineIfDebug("Loading weapon file: " + file.Replace(envAPPLOC, ""), DebuggingLoading);
                WeaponData wpn = loadWeaponFromFile(file);
                if (weaponStats.ContainsKey(wpn.id))
                {
                    MessageBox.Show("Duplicate ID found: " + wpn.id + "\nFile " + file + "\n\nBehavior may be erratic until the file is deleted or ID is changed.", "Buildframe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                weaponStats.Add(wpn.id, wpn);
            }
            weaponStats = weaponStats.OrderBy(x => x.Value.name).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
