using Buildframe.Forms;
using Buildframe.GameData;
using Buildframe.Methods;
using static System.Net.Mime.MediaTypeNames;

namespace Buildframe
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public List<ComboBox> modBoxes = new();
        public List<ComboBox> miscBoxes = new();
        public List<Label> primaryValueLabels = new();
        public List<Label> radialValueLabels = new();
        public bool pauseHandler = false;

        public List<string> validModIDs = new();
        public List<string> validArcaneIDs = new();
        public List<string> validMiscIDs = new();

        public List<StatsData> selectedStats = new();
        public StatsData mergedStats = new();

        public WeaponData currentWeapon = new();
        public string[] tags = { "None" };
        public StatsData selectedFiremode = new();
        public StatsData radial = new();
        public StatsData selectedFiremodeWithAppliedStats = new();
        public StatsData radialWithAppliedStats = new();

        public Dictionary<ComboBox, string> boxSelectedEffects = new();

        public void loadWeapon(WeaponData weapon)
        {
            currentWeapon = weapon;

            if (weapon.id == "")
            {
                foreach (Label lbl in primaryValueLabels)
                {
                    lbl.Text = "N/A";
                }
                foreach (Label lbl in radialValueLabels)
                {
                    lbl.Text = "N/A";
                }
                tags = "None".Split('.');
                setHandlerPause(true);
                loadValidIDs();
                loadArcanesToSelectionBox();
                loadModsToSelectionBox();
                loadMiscsToSelectionBox();

                comboBoxArchgunArcane.Visible = false;
                comboBoxArchgunArcane.SelectedIndex = 0;
                comboBoxFireMode.Items.Clear();
                labelWeaponName.Text = "[Weapon Name]";
                selectedFiremode = new StatsData();
                radial = new StatsData();
                setHandlerPause(false);
                return;

            }

            tags = weapon.tags.Split(' ');

            comboBoxFireMode.Items.Clear();
            foreach (StatsData fm in weapon.fireModes)
            {
                comboBoxFireMode.Items.Add(fm);
            }
            labelWeaponName.Text = weapon.name;
            setHandlerPause(true);
            loadValidIDs();
            loadArcanesToSelectionBox();
            loadModsToSelectionBox();
            loadMiscsToSelectionBox();
            if (tags.Contains("Archgun"))
            {
                comboBoxArchgunArcane.Visible = true;
            }
            else
            {
                comboBoxArchgunArcane.Visible = false;
                comboBoxArchgunArcane.SelectedIndex = 0;
            }
            setHandlerPause(false);
            comboBoxFireMode.SelectedIndex = 0;

        }

        public void updateWeaponStats()
        {
            WriteLineIfDebug("\nUpdating weapon stats for firemode " + selectedFiremode.name + "\n");
            selectedStats.Clear();
            foreach (ComboBox box in modBoxes)
            {
                if (box.SelectedIndex > 0)
                {
                    StatsData stats = (StatsData)box.SelectedItem;
                    selectedStats.Add(stats);
                    WriteLineIfDebug("    Selected stats added mod: " + stats.name);
                }
            }

            foreach (ComboBox box in miscBoxes)
            {
                if (box.SelectedIndex > 0)
                {
                    StatsData stats = (StatsData)box.SelectedItem;
                    selectedStats.Add(stats);
                    WriteLineIfDebug("    Selected stats added misc: " + stats.name);
                }
            }

            if (comboBoxWeaponArcane.SelectedIndex > 0 && comboBoxWeaponArcane.SelectedItem.ToString() != "Secondary Enervate")
            {
                StatsData stats = (StatsData)comboBoxWeaponArcane.SelectedItem;
                selectedStats.Add(stats);
                WriteLineIfDebug("    Selected stats added arcane: " + stats.name);
            }

            if (tags.Contains("Archgun") && comboBoxArchgunArcane.SelectedIndex > 0)
            {
                StatsData stats = (StatsData)comboBoxArchgunArcane.SelectedItem;
                selectedStats.Add(stats);
                WriteLineIfDebug("    Selected stats added arcane: " + stats.name);
            }

            mergedStats = Methods.Calculation.StatMethods.sumStats(selectedStats);

            double summedDamage = 0;
            double summedDPSBurst = 0;
            double summedDPSSustained = 0;
            int enervateCeiling = 0;
            string arcaneName = "";
            if (comboBoxWeaponArcane.SelectedIndex > 0)
            {
                arcaneName = comboBoxWeaponArcane.SelectedItem.ToString();
                enervateCeiling = Methods.Calculation.StatMethods.identifyEnervate((StatsData)comboBoxWeaponArcane.SelectedItem);
            }

            if (selectedFiremode.id != "")
            {
                selectedFiremodeWithAppliedStats = Methods.Calculation.StatMethods.sumStats(new List<StatsData> { selectedFiremode, mergedStats });

                if (selectedFiremodeWithAppliedStats.tags.Contains("Devouring_Attrition"))
                {
                    labelAverageCritical.Text = "Average DA/Crit Multiplier";
                }
                else
                {
                    labelAverageCritical.Text = "Average Critical Multiplier";
                }

                if (enervateCeiling > 0)
                {
                    WriteLineIfDebug("    Selected stats using hardcoded arcane: Secondary Enervate");
                    selectedFiremodeWithAppliedStats = Methods.Calculation.Weapon.setEnervate(selectedFiremodeWithAppliedStats, enervateCeiling);
                }

                double Damage = Methods.Calculation.Weapon.calculateModDamagePreCrit(selectedFiremodeWithAppliedStats) * Methods.Calculation.Weapon.calculateModAverageCritMultiplier(selectedFiremodeWithAppliedStats) * Methods.Calculation.Weapon.calculateModMultishot(selectedFiremodeWithAppliedStats); ;
                double DPSBurst = Methods.Calculation.Weapon.calculateModDPS(selectedFiremodeWithAppliedStats);
                double DPSSustained = Methods.Calculation.Weapon.calculateModDPS(selectedFiremodeWithAppliedStats, true);

                double multishot = Methods.Calculation.Weapon.calculateModMultishot(selectedFiremodeWithAppliedStats);
                double statusChance = Methods.Calculation.Weapon.calculateModStatusChance(selectedFiremodeWithAppliedStats);
                double speed = Methods.Calculation.Weapon.calculateModSpeed(selectedFiremodeWithAppliedStats);

                labelAverageCriticalValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModAverageCritMultiplier(selectedFiremodeWithAppliedStats), 2).ToString() + "x";
                labelCriticalChanceValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModCritChance(selectedFiremodeWithAppliedStats), 2).ToString() + "%";
                labelCriticalDamageValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModCritDamage(selectedFiremodeWithAppliedStats), 2).ToString() + "x";
                labelStatusProjectileValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModStatusChance(selectedFiremodeWithAppliedStats), 2).ToString() + "%";
                labelFireRateValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModSpeed(selectedFiremodeWithAppliedStats), 2).ToString();
                labelMagazineValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModMagazine(selectedFiremodeWithAppliedStats)).ToString();

                double fireTime = Methods.Calculation.Weapon.calculateModFireTime(selectedFiremodeWithAppliedStats);
                if (fireTime != double.PositiveInfinity)
                {
                    labelFireTimeValue.Text = Math.Round(fireTime, 2).ToString() + "s";
                }
                else
                {
                    labelFireTimeValue.Text = fireTime.ToString();
                }

                labelReloadValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModReloadTime(selectedFiremodeWithAppliedStats), 2).ToString() + "s";
                labelAmmoEfficiencyValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModAmmoEfficiency(selectedFiremodeWithAppliedStats), 2).ToString() + "%";

                labelMultishotValue.Text = Math.Round(multishot, 2).ToString();
                labelStatusPerSecondValue.Text = Math.Round(multishot * statusChance / 100 * speed, 2).ToString();

                labelDamageValue.Text = Damage.ToString("#,##0");
                labelDPSBurstValue.Text = DPSBurst.ToString("#,##0");
                labelDPSSustainedValue.Text = DPSSustained.ToString("#,##0");

                summedDamage = Damage;
                summedDPSBurst = DPSBurst;
                summedDPSSustained = DPSSustained;
            }
            else
            {
                foreach (Label lbl in primaryValueLabels)
                {
                    lbl.Text = "N/A";
                }
                labelAverageCritical.Text = "Average Critical Multiplier";
            }
            if (radial.id != "")
            {
                radialWithAppliedStats = Methods.Calculation.StatMethods.sumStats(new List<StatsData> { radial, mergedStats });

                if (enervateCeiling > 0)
                {
                    radialWithAppliedStats = Methods.Calculation.Weapon.setEnervate(radialWithAppliedStats, enervateCeiling);
                }

                double multishot = Methods.Calculation.Weapon.calculateModMultishot(radialWithAppliedStats);
                double statusChance = Methods.Calculation.Weapon.calculateModStatusChance(radialWithAppliedStats);
                double speed = Methods.Calculation.Weapon.calculateModSpeed(radialWithAppliedStats);

                labelRadialStatusPerSecondValue.Text = Math.Round(multishot * statusChance / 100 * speed, 2).ToString();
                labelRadialAverageCritMultValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModAverageCritMultiplier(radialWithAppliedStats), 2).ToString() + "x";
                labelRadialCriticalChanceValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModCritChance(radialWithAppliedStats), 2).ToString() + "%";
                labelRadialCriticalMultiplierValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModCritDamage(radialWithAppliedStats), 2).ToString() + "x";
                labelRadialStatusValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModStatusChance(radialWithAppliedStats), 2).ToString() + "%";
                labelRadialDamageValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModDamagePreCrit(radialWithAppliedStats) * Methods.Calculation.Weapon.calculateModAverageCritMultiplier(radialWithAppliedStats) * Methods.Calculation.Weapon.calculateModMultishot(radialWithAppliedStats), 2).ToString("#,##0");
                labelRadialDPSBurstValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModDPS(radialWithAppliedStats), 2).ToString("#,##0");
                labelRadialDPSSustainedValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModDPS(radialWithAppliedStats, true), 2).ToString("#,##0");
                summedDamage += Methods.Calculation.Weapon.calculateModDamagePreCrit(radialWithAppliedStats) * Methods.Calculation.Weapon.calculateModAverageCritMultiplier(radialWithAppliedStats) * Methods.Calculation.Weapon.calculateModMultishot(radialWithAppliedStats);
                summedDPSBurst += Methods.Calculation.Weapon.calculateModDPS(radialWithAppliedStats);
                summedDPSSustained += Methods.Calculation.Weapon.calculateModDPS(radialWithAppliedStats, true);
                labelSummedDamageValue.Text = summedDamage.ToString("#,##0");
                labelSummedDPSBurstValue.Text = summedDPSBurst.ToString("#,##0");
                labelSummedDPSSustainedValue.Text = summedDPSSustained.ToString("#,##0");

            }
            else
            {
                foreach (Label lbl in radialValueLabels)
                {
                    lbl.Text = "N/A";
                }
            }
            WriteLineIfDebug("Finished updating weapon stats\n");
        }

        public bool hasTag(StatsData stat)
        {
            if (tags.Contains("None"))
            {
                return false;
            }
            if (stat.tags.Contains("Any") || tags.Contains("Any") || stat.tags.Contains(currentWeapon.name))
            {
                return true;
            }
            foreach (string tag in tags)
            {
                if (stat.tags.Contains(tag))
                {
                    return true;
                }
            }
            return false;
        }

        public void loadValidIDs()
        {
            WriteLineIfDebug("Loading valid IDs for weapon with tags: " + string.Join(", ", tags));
            validModIDs.Clear();
            validArcaneIDs.Clear();
            validMiscIDs.Clear();
            foreach (StatsData stat in CommonVars.modStats.Values)
            {
                if (hasTag(stat))
                    validModIDs.Add(stat.id);
            }
            foreach (StatsData stat in CommonVars.arcaneStats.Values)
            {
                if (hasTag(stat))
                    validArcaneIDs.Add(stat.id);
            }
            foreach (StatsData stat in CommonVars.miscStats.Values)
            {
                if (hasTag(stat))
                    validMiscIDs.Add(stat.id);
            }
        }

        public void loadArcanesToSelectionBox()
        {
            if (tags.Contains("Archgun"))
            {
                loadArchgunArcanesToBoxes();
                return;
            }
            WriteLineIfDebug("\nLoading valid arcanes\n");


            string statID = "";
            if (boxSelectedEffects.ContainsKey(comboBoxWeaponArcane))
            {
                statID = boxSelectedEffects[comboBoxWeaponArcane];
            }
            comboBoxWeaponArcane.Items.Clear();
            comboBoxWeaponArcane.Items.Add("None");
            comboBoxArchgunArcane.Items.Clear();
            comboBoxArchgunArcane.Items.Add("None");

            comboBoxArchgunArcane.Visible = false;
            comboBoxArchgunArcane.SelectedIndex = 0;

            foreach (string id in validArcaneIDs)
            {
                comboBoxWeaponArcane.Items.Add(arcaneStats[id]);
            }
            if (boxSelectedEffects.ContainsKey(comboBoxWeaponArcane) && validArcaneIDs.Contains(statID))
            {
                int index = validArcaneIDs.IndexOf(statID) + 1;
                comboBoxWeaponArcane.SelectedIndex = index;
            }
            else
            {
                WriteLineIfDebug("    No previous arcane selected, defaulting to None");
                comboBoxWeaponArcane.SelectedIndex = 0;
            }
        }

        public void loadArchgunArcanesToBoxes()
        {
            WriteLineIfDebug("\nLoading archgun arcanes\n");
            List<ComboBox> arcaneBoxes = new();
            arcaneBoxes.Add(comboBoxWeaponArcane);
            arcaneBoxes.Add(comboBoxArchgunArcane);
            comboBoxArchgunArcane.Visible = true;

            comboBoxWeaponArcane.Items.Clear();
            comboBoxWeaponArcane.Items.Add("None");
            comboBoxArchgunArcane.Items.Clear();
            comboBoxArchgunArcane.Items.Add("None");

            foreach (StatsData stat in CommonVars.arcaneStats.Values)
            {
                if (stat.tags.Contains("Any"))
                {
                    comboBoxArchgunArcane.Items.Add(stat);
                    comboBoxWeaponArcane.Items.Add(stat);
                }
                if (stat.tags.Contains("Rifle") || stat.tags.Contains("Primary"))
                {
                    comboBoxArchgunArcane.Items.Add(stat);
                }
                if (stat.tags.Contains("Pistol") || stat.tags.Contains("Secondary"))
                {
                    comboBoxWeaponArcane.Items.Add(stat);
                }
            }

            foreach (ComboBox box in arcaneBoxes)
            {

                if (boxSelectedEffects.ContainsKey(box) && box.Items.Contains(arcaneStats[boxSelectedEffects[box]]))
                {
                    box.SelectedItem = arcaneStats[boxSelectedEffects[box]];
                }
                else
                {
                    box.SelectedIndex = 0;
                }
            }
        }

        public void loadModsToSelectionBox()
        {
            WriteLineIfDebug("\nLoading valid mods\n");
            foreach (ComboBox box in modBoxes)
            {
                box.Items.Clear();
                box.Items.Add("None");
            }

            foreach (string id in validModIDs)
            {
                foreach (ComboBox box in modBoxes)
                {
                    box.Items.Add(modStats[id]);

                }
            }

            setHandlerPause(true);

            foreach (ComboBox box in modBoxes)
            {
                if (boxSelectedEffects.ContainsKey(box) && box.Items.Contains(modStats[boxSelectedEffects[box]]))
                {
                    box.SelectedItem = modStats[boxSelectedEffects[box]];
                }
                else
                {
                    box.SelectedIndex = 0;
                }
            }
            setHandlerPause(false);
        }

        public void loadMiscsToSelectionBox()
        {
            WriteLineIfDebug("\nLoading valid misc effects\n");
            foreach (ComboBox box in miscBoxes)
            {
                box.Items.Clear();
                box.Items.Add("None");
            }

            foreach (string id in validMiscIDs)
            {
                foreach (ComboBox box in miscBoxes)
                {
                    box.Items.Add(miscStats[id]);
                }
            }

            setHandlerPause(true);

            foreach (ComboBox box in miscBoxes)
            {
                if (boxSelectedEffects.ContainsKey(box) && box.Items.Contains(miscStats[boxSelectedEffects[box]]))
                {
                    box.SelectedItem = miscStats[boxSelectedEffects[box]];
                }
                else
                {
                    box.SelectedIndex = 0;
                }
            }
            setHandlerPause(false);
        }

        public void stashBoxEffects()
        {
            boxSelectedEffects.Clear();
            foreach (ComboBox box in modBoxes)
            {
                if (box.SelectedIndex > 0)
                {
                    boxSelectedEffects.Add(box, ((StatsData)box.SelectedItem).id);
                }
                else
                {
                    boxSelectedEffects.Remove(box);
                }
            }
            foreach (ComboBox box in miscBoxes)
            {
                if (box.SelectedIndex > 0)
                {
                    boxSelectedEffects.Add(box, ((StatsData)box.SelectedItem).id);
                }
                else
                {
                    boxSelectedEffects.Remove(box);
                }
            }
            if (comboBoxWeaponArcane.SelectedIndex > 0)
            {
                boxSelectedEffects.Add(comboBoxWeaponArcane, ((StatsData)comboBoxWeaponArcane.SelectedItem).id);
            }
            else
            {
                boxSelectedEffects.Remove(comboBoxWeaponArcane);
            }
            if (comboBoxArchgunArcane.SelectedIndex > 0)
            {
                boxSelectedEffects.Add(comboBoxArchgunArcane, ((StatsData)comboBoxArchgunArcane.SelectedItem).id);
            }
            else
            {
                boxSelectedEffects.Remove(comboBoxArchgunArcane);
            }
        }

        public void restoreFromStash()
        {
            foreach (ComboBox box in modBoxes)
            {
                if (!boxSelectedEffects.ContainsKey(box))
                {
                    box.SelectedIndex = 0;
                    continue;
                }
                StatsData stat = modStats[boxSelectedEffects[box]];
                if (validModIDs.Contains(stat.id))
                {
                    box.SelectedItem = stat;
                }
            }
            if (boxSelectedEffects.ContainsKey(comboBoxWeaponArcane))
            {
                StatsData stat = arcaneStats[boxSelectedEffects[comboBoxWeaponArcane]];
                if (validArcaneIDs.Contains(stat.id))
                {
                    comboBoxWeaponArcane.SelectedItem = stat;
                }
            }
            else
            {
                comboBoxWeaponArcane.SelectedIndex = 0;
            }
        }

        public void saveSelectedToFile(string path = "lastbuild.cfg")
        {
            if (currentWeapon.id == "")
            {
                return;
            }
            string s = "";
            s += "weapon=" + currentWeapon.id + "\n";
            if (comboBoxWeaponArcane.SelectedIndex > 0)
            {
                string statID = ((StatsData)comboBoxWeaponArcane.SelectedItem).id;
                s += "arcane=" + statID + "\n";
            }
            else
            {
                s += "arcane=\n";
            }

            if (tags.Contains("Archgun") && comboBoxArchgunArcane.SelectedIndex > 0)
            {
                StatsData stat = (StatsData)comboBoxArchgunArcane.SelectedItem;

                string statID = stat.id;

                s += "archgunarcane=" + statID + "\n";
            }
            else if (tags.Contains("Archgun"))
            {
                s += "archgunarcane=\n";
            }

            s += "mods=";
            foreach (ComboBox box in modBoxes)
            {
                if (box.SelectedIndex > 0)
                {
                    int idIndex = box.SelectedIndex - 1;
                    string statID = validModIDs[idIndex];
                    s += statID + ":";
                }
                else
                {
                    s += ":";
                }
            }
            s += "\n";
            s += "misc=";
            foreach (ComboBox box in miscBoxes)
            {
                if (box.SelectedIndex > 0)
                {
                    int idIndex = box.SelectedIndex - 1;
                    string statID = validMiscIDs[idIndex];
                    s += statID + ":";
                }
                else
                {
                    s += ":";
                }
            }
            File.WriteAllText(path, s);
            WriteLineIfDebug("Saved build to " + path);
        }
        public void loadSelectedFromFile(string path = "lastbuild.cfg")
        {
            if (!File.Exists(path))
            {
                return;
            }
            WriteLineIfDebug("Loading build from " + path);
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] parts = line.Split('=');
                if (parts.Length != 2)
                    continue;
                string key = parts[0];
                string value = parts[1];
                if (key == "weapon")
                {
                    if (CommonVars.weaponStats.ContainsKey(value))
                    {
                        loadWeapon(CommonVars.weaponStats[value]);
                        setHandlerPause(true);
                        if (tags.Contains("Archgun"))
                        {
                            comboBoxArchgunArcane.SelectedIndex = 0;
                        }
                        comboBoxWeaponArcane.SelectedIndex = 0;
                        foreach (ComboBox box in modBoxes)
                        {
                            box.SelectedIndex = 0;
                        }
                        foreach (ComboBox box in miscBoxes)
                        {
                            box.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        WriteLineIfDebug("Weapon ID in save file not found: " + value);
                        return;
                    }
                }
                else if (key == "arcane")
                {
                    if (value != "" && CommonVars.arcaneStats.ContainsKey(value) && comboBoxWeaponArcane.Items.Contains(arcaneStats[value]))
                    {
                        WriteLineIfDebug("Setting arcane to " + value);
                        StatsData stat = CommonVars.arcaneStats[value];
                        comboBoxWeaponArcane.SelectedItem = stat;
                    }
                    else
                    {
                        WriteLineIfDebug("Arcane ID in file not found or not valid for weapon: " + value);
                    }
                }
                else if (key == "archgunarcane")
                {
                    if (value != "" && CommonVars.arcaneStats.ContainsKey(value) && tags.Contains("Archgun"))
                    {
                        WriteLineIfDebug("Setting archgun arcane to " + value);
                        StatsData stat = CommonVars.arcaneStats[value];
                        comboBoxArchgunArcane.SelectedItem = stat;
                    }
                    else if (value != "" && tags.Contains("Archgun"))
                    {
                        WriteLineIfDebug("Archgun Arcane ID in file not found or not valid for weapon: " + value);
                    }
                }
                else if (key == "mods")
                {
                    string[] modIDs = value.Split(':');
                    for (int i = 0; i < modIDs.Length && i < modBoxes.Count; i++)
                    {
                        string modID = modIDs[i];
                        if (CommonVars.modStats.ContainsKey(modID))
                        {
                            WriteLineIfDebug("Setting mod box " + (i + 1) + " to " + modID);
                            int index = validModIDs.IndexOf(modID) + 1;
                            modBoxes[i].SelectedIndex = index;
                        }
                        else if (modID.Length > 2)
                        {
                            WriteLineIfDebug("Mod ID " + modID + " for slot " + (i + 1) + " not found.");
                        }
                    }
                }
                else if (key == "misc")
                {
                    string[] miscIDs = value.Split(':');
                    for (int i = 0; i < miscIDs.Length && i < miscBoxes.Count; i++)
                    {
                        string miscID = miscIDs[i];
                        if (CommonVars.miscStats.ContainsKey(miscID))
                        {
                            WriteLineIfDebug("Setting misc box " + (i + 1) + " to " + miscID);
                            int index = validMiscIDs.IndexOf(miscID) + 1;
                            miscBoxes[i].SelectedIndex = index;
                        }
                        else if (miscID.Length > 2)
                        {
                            WriteLineIfDebug("miscID " + miscID + " for slot " + (i + 1) + " not found.");
                        }
                    }
                }
            }
            setHandlerPause(false);
            updateWeaponStats();
            WriteLineIfDebug("Loaded build from " + path);
        }

        public void setHandlerPause(bool pause)
        {
            if (!pause && pauseHandler)
            {
                WriteLineIfDebug("Resumed weapon updates.");
            }
            pauseHandler = pause;
            if (pauseHandler)
            {
                WriteLineIfDebug("Paused weapon updates.");
            }
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Text = Settings.Default.ToolName + " " + Settings.Default.Version;
            if (Settings.Default.SavedPosition != new Point(1, 1))
                this.Location = Settings.Default.SavedPosition; WriteLineIfDebug("    Set position to " + this.Location);
            if (Settings.Default.SavedSize != new Size(1, 1))
                this.Size = Settings.Default.SavedSize; WriteLineIfDebug("    Set size to " + this.Size);

            comboBoxFireMode.Width = tableLayoutPanel1.Width;

            modBoxes.Add(comboBoxMod1);
            modBoxes.Add(comboBoxMod2);
            modBoxes.Add(comboBoxMod3);
            modBoxes.Add(comboBoxMod4);
            modBoxes.Add(comboBoxMod5);
            modBoxes.Add(comboBoxMod6);
            modBoxes.Add(comboBoxMod7);
            modBoxes.Add(comboBoxMod8);

            miscBoxes.Add(comboBoxMiscEffect1);
            miscBoxes.Add(comboBoxMiscEffect2);
            miscBoxes.Add(comboBoxMiscEffect3);
            miscBoxes.Add(comboBoxMiscEffect4);
            miscBoxes.Add(comboBoxMiscEffect5);
            miscBoxes.Add(comboBoxMiscEffect6);
            miscBoxes.Add(comboBoxMiscEffect7);
            miscBoxes.Add(comboBoxMiscEffect8);
            miscBoxes.Add(comboBoxMiscEffect9);
            miscBoxes.Add(comboBoxMiscEffect10);
            miscBoxes.Add(comboBoxMiscEffect11);
            miscBoxes.Add(comboBoxMiscEffect12);

            setHandlerPause(true);

            foreach (ComboBox box in modBoxes)
            {
                box.Items.Add("None");
                box.SelectedIndex = 0;
            }
            foreach (ComboBox box in miscBoxes)
            {
                box.Items.Add("None");
                box.SelectedIndex = 0;
            }

            comboBoxWeaponArcane.Items.Add("None");
            comboBoxWeaponArcane.SelectedIndex = 0;

            setHandlerPause(false);

            primaryValueLabels.Add(labelDamageValue);
            primaryValueLabels.Add(labelFireRateValue);
            primaryValueLabels.Add(labelMagazineValue);
            primaryValueLabels.Add(labelReloadValue);
            primaryValueLabels.Add(labelAmmoEfficiencyValue);
            primaryValueLabels.Add(labelMultishotValue);
            primaryValueLabels.Add(labelAverageCriticalValue);
            primaryValueLabels.Add(labelCriticalChanceValue);
            primaryValueLabels.Add(labelCriticalDamageValue);
            primaryValueLabels.Add(labelStatusProjectileValue);
            primaryValueLabels.Add(labelStatusPerSecondValue);
            primaryValueLabels.Add(labelDPSBurstValue);
            primaryValueLabels.Add(labelDPSSustainedValue);
            primaryValueLabels.Add(labelFireTimeValue);

            radialValueLabels.Add(labelRadialAverageCritMultValue);
            radialValueLabels.Add(labelRadialCriticalChanceValue);
            radialValueLabels.Add(labelRadialCriticalMultiplierValue);
            radialValueLabels.Add(labelRadialDPSBurstValue);
            radialValueLabels.Add(labelRadialDPSSustainedValue);
            radialValueLabels.Add(labelRadialStatusPerSecondValue);
            radialValueLabels.Add(labelRadialStatusValue);
            radialValueLabels.Add(labelRadialDamageValue);
            radialValueLabels.Add(labelSummedDamageValue);
            radialValueLabels.Add(labelSummedDPSBurstValue);
            radialValueLabels.Add(labelSummedDPSSustainedValue);


            foreach (Label lbl in primaryValueLabels)
            {
                lbl.Text = "N/A";
            }
            foreach (Label lbl in radialValueLabels)
            {
                lbl.Text = "N/A";
            }

            if (File.Exists("lastbuild.cfg"))
            {
                WriteLineIfDebug("Loading last session from file");
                loadSelectedFromFile();
            }

            Padding newMargin = tableLayoutPanel1.Margin;
            newMargin.Bottom = tableLayoutPanel1.Location.X;
            tableLayoutPanel1.Margin = newMargin;

        }

        private void ToolStripMenuItemSelectWeapon_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.SavedPosition = this.Location;
            Settings.Default.SavedSize = this.Size;
            Settings.Default.Save();
            saveSelectedToFile();
        }

        private void comboBoxMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pauseHandler)
                return;
            if ((ComboBox)sender != null && ((ComboBox)sender).DroppedDown)
            {
                comboBoxTooltipShow_Event(sender, e);
            }
            updateWeaponStats();
        }
        private void comboBoxMisc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pauseHandler)
                return;
            if ((ComboBox)sender != null && ((ComboBox)sender).DroppedDown)
            {
                comboBoxTooltipShow_Event(sender, e);
            }
            updateWeaponStats();
        }

        private void comboBoxWeaponArcane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pauseHandler)
                return;
            if ((ComboBox)sender != null && ((ComboBox)sender).DroppedDown)
            {
                comboBoxTooltipShow_Event(sender, e);
            }
            updateWeaponStats();
        }

        private void comboBoxFireMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFiremode = currentWeapon.fireModes[comboBoxFireMode.SelectedIndex];
            WriteLineIfDebug("Selected fire mode: " + selectedFiremode.id + " : " + selectedFiremode.name);
            if (currentWeapon.fireModesRadials.ContainsKey(selectedFiremode.id))
            {
                radial = currentWeapon.fireModesRadials[selectedFiremode.id];
            }
            else
            {
                radial = new StatsData();
            }
            if (comboBoxFireMode.DroppedDown)
            {
                comboBoxFireModeTooltipShow_Event(sender, e);
            }

            if (pauseHandler)
                return;
            updateWeaponStats();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = currentWeapon.name + " build.cfg";
            Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "Builds"));
            saveFileDialog1.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "Builds");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveSelectedToFile(saveFileDialog1.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "Builds"));
            openFileDialog1.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "Builds");
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                loadSelectedFromFile(openFileDialog1.FileName);
            }
        }

        private void createFireModeOrBuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stashBoxEffects();

            FormStatWizard form = new FormStatWizard();
            form.ShowDialog();

            LoadAndSave.loadFireModeFiles();
            LoadAndSave.loadModFiles();
            LoadAndSave.loadArcaneFiles();
            LoadAndSave.loadMiscFiles();
            LoadAndSave.loadWeaponFiles();
            if (currentWeapon.id != "")
            {
                loadWeapon(weaponStats[currentWeapon.id]);
            }
        }

        private void createWeaponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stashBoxEffects();

            FormWeaponWizard form = new FormWeaponWizard();
            form.ShowDialog();
            LoadAndSave.loadWeaponFiles();
            if (currentWeapon.id != "")
            {
                loadWeapon(weaponStats[currentWeapon.id]);
            }
        }

        private void toolStripButtonSelectWeapon_Click(object sender, EventArgs e)
        {
            stashBoxEffects();

            FormWeaponSelection form = new FormWeaponSelection();
            form.mainWindow = this;
            form.ShowDialog();
            loadWeapon(currentWeapon);
        }

        private void toolStripButtonInfo_Click(object sender, EventArgs e)
        {
            Info form = new Info();
            form.ShowDialog();
        }

        private void comboBoxTooltipShow_Event(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            Point p = box.Location;
            p.X += box.Width;
            p.X += 10 * this.DeviceDpi / 100;
            p.Y += box.Height / 2;
            p.X += tableLayoutPanel2.Location.X;
            p.Y += tableLayoutPanel2.Location.Y;
            p.Y += toolStrip1.Height;
            if (box.SelectedItem is StatsData)
            {
                int enervate = Methods.Calculation.StatMethods.identifyEnervate((StatsData)box.SelectedItem);
                if (box == comboBoxWeaponArcane && enervate > 0)
                {
                    toolTipMods.Show(StatDisplay.generateStatsDescription((StatsData)box.SelectedItem, (Methods.Calculation.StatMethods.sumStats(new List<StatsData> { selectedFiremode, mergedStats }))), this, p);
                    return;
                }
                toolTipMods.Show(Methods.StatDisplay.generateStatsDescription((StatsData)box.SelectedItem), this, p);
            }
            else
            {
                toolTipMods.Hide(this);
            }
        }

        private void comboBoxFireModeTooltipShow_Event(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            Point p = box.Location;
            p.X += box.Width;
            p.X += 10 * this.DeviceDpi / 100;
            p.Y += box.Height / 2;
            p.Y += toolStrip1.Height;

            if (box.SelectedItem is StatsData)
            {
                string tooltip = Methods.StatDisplay.generateStatsDescription((StatsData)box.SelectedItem);
                if (radial.id != "")
                {
                    tooltip += "\nRadial:\n";
                    tooltip += Methods.StatDisplay.generateStatsDescription(radial);
                }

                toolTipMods.Show(tooltip, this, p);
            }
            else
            {
                toolTipMods.Hide(this);
            }
        }

        private void comboBoxTooltipHide_Event(object sender, EventArgs e)
        {
            toolTipMods.Hide(this);
        }
    }
}
