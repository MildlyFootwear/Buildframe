using Buildframe.GameData;

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
                WriteLineIfDebug("\nFile load error: not in stat directory:\n" + path + "\n\n");
                return stats;
            }

            stats.filePath = path;

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

                if (split[0] == "baseTau")
                    stats.baseTau = Convert.ToDouble(split[1]);

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
                if (split[0] == "baseReserveAmmo")
                    stats.baseReserveAmmo = Convert.ToDouble(split[1]);


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

                if (split[0] == "modTau")
                    stats.modTau = Convert.ToDouble(split[1]);

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
                if (split[0] == "modReserveAmmo")
                    stats.modReserveAmmo = Convert.ToDouble(split[1]);




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

                if (split[0] == "baseAmmoEfficiency")
                {
                    stats.finalAmmoEfficiency = Convert.ToDouble(split[1]);
                    resaveToConvert = true;
                }
                if (split[0] == "finalAmmoEfficiency" && stats.finalAmmoEfficiency == 0)
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


                if (split[0] == "punchthrough")
                    stats.punchthrough = Convert.ToDouble(split[1]);
                if (split[0] == "ammoRegen")
                    stats.ammoRegen = Convert.ToDouble(split[1]);
            }

            if (resaveToConvert)
            {
                WriteLineIfDebug(path + " needed to be updated and is being resaved");
                saveStatToFile(path, stats);
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

            if (stats.baseDamage != 0)
                s += "\nbaseDamage=" + Convert.ToString(stats.baseDamage);
            if (stats.baseDamagePercentage != 0)
                s += "\nbaseDamagePercentage=" + Convert.ToString(stats.baseDamagePercentage);
            if (stats.baseAttackSpeed != 0)
                s += "\nbaseAttackSpeed=" + Convert.ToString(stats.baseAttackSpeed);

            if (stats.baseReloadTime != 0)
                s += "\nbaseReloadTime=" + Convert.ToString(stats.baseReloadTime);
            if (stats.baseAmmoEfficiency != 0)
                s += "\nbaseAmmoEfficiency=" + Convert.ToString(stats.baseAmmoEfficiency);
            if (stats.baseChargeTime != 0)
                s += "\nbaseChargeTime=" + Convert.ToString(stats.baseChargeTime);
            if (stats.baseMagazine != 0)
                s += "\nbaseMagazine=" + Convert.ToString(stats.baseMagazine);

            if (stats.baseSlash != 0)
                s += "\nbaseSlash=" + Convert.ToString(stats.baseSlash);
            if (stats.baseImpact != 0)
                s += "\nbaseImpact=" + Convert.ToString(stats.baseImpact);
            if (stats.basePuncture != 0)
                s += "\nbasePuncture=" + Convert.ToString(stats.basePuncture);

            if (stats.baseHeat != 0)
                s += "\nbaseHeat=" + Convert.ToString(stats.baseHeat);
            if (stats.baseCold != 0)
                s += "\nbaseCold=" + Convert.ToString(stats.baseCold);
            if (stats.baseElectric != 0)
                s += "\nbaseElectric=" + Convert.ToString(stats.baseElectric);
            if (stats.baseToxin != 0)
                s += "\nbaseToxin=" + Convert.ToString(stats.baseToxin);
            if (stats.baseTau != 0)
                s += "\nbaseTau=" + Convert.ToString(stats.baseTau);

            if (stats.baseBlast != 0)
                s += "\nbaseBlast=" + Convert.ToString(stats.baseBlast);
            if (stats.baseRadiation != 0)
                s += "\nbaseRadiation=" + Convert.ToString(stats.baseRadiation);
            if (stats.baseViral != 0)
                s += "\nbaseViral=" + Convert.ToString(stats.baseViral);
            if (stats.baseCorrosive != 0)
                s += "\nbaseCorrosive=" + Convert.ToString(stats.baseCorrosive);
            if (stats.baseMagnetic != 0)
                s += "\nbaseMagnetic=" + Convert.ToString(stats.baseMagnetic);
            if (stats.baseGas != 0)
                s += "\nbaseGas=" + Convert.ToString(stats.baseGas);

            if (stats.baseMultishot != 0)
                s += "\nbaseMultishot=" + Convert.ToString(stats.baseMultishot);

            if (stats.baseCriticalChance != 0)
                s += "\nbaseCriticalChance=" + Convert.ToString(stats.baseCriticalChance);
            if (stats.baseCriticalDamage != 0)
                s += "\nbaseCriticalDamage=" + Convert.ToString(stats.baseCriticalDamage);

            if (stats.baseStatusChance != 0)
                s += "\nbaseStatusChance=" + Convert.ToString(stats.baseStatusChance);
            if (stats.baseStatusDamage != 0)
                s += "\nbaseStatusDamage=" + Convert.ToString(stats.baseStatusDamage);
            if (stats.baseReserveAmmo != 0)
                s += "\nbaseReserveAmmo=" + Convert.ToString(stats.baseReserveAmmo);


            if (stats.modDamage != 0)
                s += "\nmodDamage=" + Convert.ToString(stats.modDamage);
            if (stats.modDamagePercentage != 0)
                s += "\nmodDamagePercentage=" + Convert.ToString(stats.modDamagePercentage);
            if (stats.modDamageFaction != 0)
                s += "\nmodDamageFaction=" + Convert.ToString(stats.modDamageFaction);

            if (stats.modAttackSpeed != 0)
                s += "\nmodAttackSpeed=" + Convert.ToString(stats.modAttackSpeed);

            if (stats.modReloadTime != 0)
                s += "\nmodReloadTime=" + Convert.ToString(stats.modReloadTime);
            if (stats.modAmmoEfficiency != 0)
                s += "\nmodAmmoEfficiency=" + Convert.ToString(stats.modAmmoEfficiency);
            if (stats.modChargeTime != 0)
                s += "\nmodChargeTime=" + Convert.ToString(stats.modChargeTime);
            if (stats.modMagazine != 0)
                s += "\nmodMagazine=" + Convert.ToString(stats.modMagazine);


            if (stats.modSlash != 0)
                s += "\nmodSlash=" + Convert.ToString(stats.modSlash);
            if (stats.modImpact != 0)
                s += "\nmodImpact=" + Convert.ToString(stats.modImpact);
            if (stats.modPuncture != 0)
                s += "\nmodPuncture=" + Convert.ToString(stats.modPuncture);

            if (stats.modHeat != 0)
                s += "\nmodHeat=" + Convert.ToString(stats.modHeat);
            if (stats.modCold != 0)
                s += "\nmodCold=" + Convert.ToString(stats.modCold);
            if (stats.modElectric != 0)
                s += "\nmodElectric=" + Convert.ToString(stats.modElectric);
            if (stats.modToxin != 0)
                s += "\nmodToxin=" + Convert.ToString(stats.modToxin);
            if (stats.modTau != 0)
                s += "\nmodTau=" + Convert.ToString(stats.modTau);

            if (stats.modBlast != 0)
                s += "\nmodBlast=" + Convert.ToString(stats.modBlast);
            if (stats.modRadiation != 0)
                s += "\nmodRadiation=" + Convert.ToString(stats.modRadiation);
            if (stats.modViral != 0)
                s += "\nmodViral=" + Convert.ToString(stats.modViral);
            if (stats.modCorrosive != 0)
                s += "\nmodCorrosive=" + Convert.ToString(stats.modCorrosive);
            if (stats.modMagnetic != 0)
                s += "\nmodMagnetic=" + Convert.ToString(stats.modMagnetic);
            if (stats.modGas != 0)
                s += "\nmodGas=" + Convert.ToString(stats.modGas);

            if (stats.modMultishot != 0)
                s += "\nmodMultishot=" + Convert.ToString(stats.modMultishot);

            if (stats.modCriticalChance != 0)
                s += "\nmodCriticalChance=" + Convert.ToString(stats.modCriticalChance);
            if (stats.modCriticalDamage != 0)
                s += "\nmodCriticalDamage=" + Convert.ToString(stats.modCriticalDamage);

            if (stats.modStatusChance != 0)
                s += "\nmodStatusChance=" + Convert.ToString(stats.modStatusChance);
            if (stats.modStatusDamage != 0)
                s += "\nmodStatusDamage=" + Convert.ToString(stats.modStatusDamage);
            if (stats.modReserveAmmo != 0)
                s += "\nmodReserveAmmo=" + Convert.ToString(stats.modReserveAmmo);


            if (stats.finalDamage != 0)
                s += "\nfinalDamage=" + Convert.ToString(stats.finalDamage);
            if (stats.finalDamagePercentage != 0)
                s += "\nfinalDamagePercentage=" + Convert.ToString(stats.finalDamagePercentage);

            if (stats.finalAttackSpeed != 0)
                s += "\nfinalAttackSpeed=" + Convert.ToString(stats.finalAttackSpeed);

            if (stats.finalReloadTime != 0)
                s += "\nfinalReloadTime=" + Convert.ToString(stats.finalReloadTime);
            if (stats.finalMagazine != 0)
                s += "\nfinalMagazine=" + Convert.ToString(stats.finalMagazine);
            if (stats.finalAmmoEfficiency != 0)
                s += "\nfinalAmmoEfficiency=" + Convert.ToString(stats.finalAmmoEfficiency);
            if (stats.finalChargeTime != 0)
                s += "\nfinalChargeTime=" + Convert.ToString(stats.finalChargeTime);
            if (stats.finalMagazine != 0)
                s += "\nfinalMagazine=" + Convert.ToString(stats.finalMagazine);

            if (stats.finalSlash != 0)
                s += "\nfinalSlash=" + Convert.ToString(stats.finalSlash);
            if (stats.finalImpact != 0)
                s += "\nfinalImpact=" + Convert.ToString(stats.finalImpact);
            if (stats.finalPuncture != 0)
                s += "\nfinalPuncture=" + Convert.ToString(stats.finalPuncture);

            if (stats.finalHeat != 0)
                s += "\nfinalHeat=" + Convert.ToString(stats.finalHeat);
            if (stats.finalCold != 0)
                s += "\nfinalCold=" + Convert.ToString(stats.finalCold);
            if (stats.finalElectric != 0)
                s += "\nfinalElectric=" + Convert.ToString(stats.finalElectric);
            if (stats.finalToxin != 0)
                s += "\nfinalToxin=" + Convert.ToString(stats.finalToxin);

            if (stats.finalBlast != 0)
                s += "\nfinalBlast=" + Convert.ToString(stats.finalBlast);
            if (stats.finalRadiation != 0)
                s += "\nfinalRadiation=" + Convert.ToString(stats.finalRadiation);
            if (stats.finalViral != 0)
                s += "\nfinalViral=" + Convert.ToString(stats.finalViral);
            if (stats.finalCorrosive != 0)
                s += "\nfinalCorrosive=" + Convert.ToString(stats.finalCorrosive);
            if (stats.finalMagnetic != 0)
                s += "\nfinalMagnetic=" + Convert.ToString(stats.finalMagnetic);
            if (stats.finalGas != 0)
                s += "\nfinalGas=" + Convert.ToString(stats.finalGas);

            if (stats.finalMultishot != 0)
                s += "\nfinalMultishot=" + Convert.ToString(stats.finalMultishot);

            if (stats.finalCriticalChance != 0)
                s += "\nfinalCriticalChance=" + Convert.ToString(stats.finalCriticalChance);
            if (stats.finalCriticalDamage != 0)
                s += "\nfinalCriticalDamage=" + Convert.ToString(stats.finalCriticalDamage);

            if (stats.finalStatusChance != 0)
                s += "\nfinalStatusChance=" + Convert.ToString(stats.finalStatusChance);
            if (stats.finalStatusDamage != 0)
                s += "\nfinalStatusDamage=" + Convert.ToString(stats.finalStatusDamage);

            if (stats.punchthrough != 0)
                s += "\npunchthrough=" + Convert.ToString(stats.punchthrough);
            if (stats.ammoRegen != 0)
                s += "\nammoRegen=" + Convert.ToString(stats.ammoRegen);



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
            weapon.filePath = path;
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

            return weapon;
        }

        public static void loadArcaneFiles()
        {
            arcaneStats.Clear();
            string directory = Path.Combine(envAPPLOC, "Data", "Arcanes");
            Directory.CreateDirectory(directory);
            foreach (string file in Directory.GetFiles(directory, "*.cfg").OrderByDescending(f => File.GetLastWriteTime(f)))
            {
                WriteLineIfDebug("Loading arcane file: " + file.Replace(envAPPLOC, ""), DebuggingLoading);
                StatsData stats = loadStatFromFile(file);
                if (arcaneStats.ContainsKey(stats.id))
                {
                    promptForDelete(stats.id, arcaneStats[stats.id].name, arcaneStats[stats.id].filePath, file);
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
            foreach (string file in Directory.GetFiles(directory, "*.cfg").OrderByDescending(f => File.GetLastWriteTime(f)))
            {
                WriteLineIfDebug("Loading mod file: " + file.Replace(envAPPLOC, ""), DebuggingLoading);
                StatsData stats = loadStatFromFile(file);
                if (modStats.ContainsKey(stats.id))
                {
                    promptForDelete(stats.id, modStats[stats.id].name, modStats[stats.id].filePath, file);
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
            foreach (string file in Directory.GetFiles(directory, "*.cfg").OrderByDescending(f => File.GetLastWriteTime(f)))
            {
                WriteLineIfDebug("Loading misc file: " + file.Replace(envAPPLOC, ""), DebuggingLoading);
                StatsData stats = loadStatFromFile(file);
                if (miscStats.ContainsKey(stats.id))
                {
                    promptForDelete(stats.id, miscStats[stats.id].name, miscStats[stats.id].filePath, file);
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
            foreach (string file in Directory.GetFiles(directory, "*.cfg").OrderByDescending(f => File.GetLastWriteTime(f)))
            {
                WriteLineIfDebug("Loading fire mode file: " + file.Replace(envAPPLOC, ""), DebuggingLoading);
                StatsData stats = loadStatFromFile(file);
                if (fireModeStats.ContainsKey(stats.id))
                {
                    promptForDelete(stats.id, fireModeStats[stats.id].name, fireModeStats[stats.id].filePath, file);
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
            foreach (string file in Directory.GetFiles(directory, "*.cfg").OrderByDescending(f => File.GetLastWriteTime(f)))
            {
                WriteLineIfDebug("Loading weapon file: " + file.Replace(envAPPLOC, ""), DebuggingLoading);
                WeaponData wpn = loadWeaponFromFile(file);
                if (weaponStats.ContainsKey(wpn.id))
                {
                    WriteLineIfDebug("Duplicate weapon ID found: " + wpn.id + " in file " + file, DebuggingLoading);
                    promptForDelete(wpn.id, weaponStats[wpn.id].name, weaponStats[wpn.id].filePath, file);
                    continue;
                }
                weaponStats.Add(wpn.id, wpn);
            }
            weaponStats = weaponStats.OrderBy(x => x.Value.name).ToDictionary(x => x.Key, x => x.Value);
        }

        static void promptForDelete(string id, string name, string file1, string file2)
        {
            DateTime file1Date = File.GetLastWriteTime(file1);
            DateTime file2Date = File.GetLastWriteTime(file2);
            string path = file1Date < file2Date ? file1 : file2;
            DialogResult result = MessageBox.Show("Duplicate ID found: " + id + " which is \"" + name + "\"\nOlder file is " + path + "\nOlder file will not be loaded.\n\nWould you like to delete the older file?", ToolName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                File.Delete(path);
            }
        }
    }
}
