using Buildframe.Forms;
using Buildframe.GameData;
using Buildframe.Methods;
using System.Globalization;
using static System.Windows.Forms.AxHost;

namespace Buildframe
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Weapon currentWeapon = new();
        public Stats primary = new();
        public Stats radial = new();
        public List<Stats> selectedStats = new();
        public List<Stats> fireModesWithAppliedStats = new();
        public Stats mergedStats = new();
        public Stats primaryWithAppliedStats = new();
        public Stats radialWithAppliedStats = new();
        public List<string> validModIDs = new();
        public List<string> validArcaneIDs = new();
        public List<string> validMiscIDs = new();
        public List<ComboBox> modBoxes = new();
        public List<ComboBox> miscBoxes = new();
        public List<Label> primaryValueLabels = new();
        public List<Label> radialValueLabels = new();
        public Dictionary<ComboBox, string> boxSelectedIDs = new();
        public string[] tags = { "Any" };
        public bool pauseHandler = false;

        public void loadWeapon(Weapon weapon)
        {
            currentWeapon = weapon;
            if (weapon.id == "")
                return;
            tags = weapon.tags.Split(' ');
            comboBoxFireMode.Items.Clear();
            foreach (Stats fm in weapon.fireModes)
            {
                comboBoxFireMode.Items.Add(fm.name);
            }
            labelWeaponName.Text = weapon.name;
            setHandlerPause(true);
            loadValidIDs();
            loadArcanesToSelectionBox();
            loadModsToSelectionBox();
            loadMiscsToSelectionBox();
            setHandlerPause(false);
            comboBoxFireMode.SelectedIndex = 0;

        }

        public void updateWeaponStats()
        {
            WriteLineIfDebug("\nUpdating weapon stats for firemode " + primary.name + "\n");
            selectedStats.Clear();
            foreach (ComboBox box in modBoxes)
            {
                if (box.SelectedIndex > 0)
                {
                    int idIndex = box.SelectedIndex - 1;
                    string statID = validModIDs[idIndex];
                    selectedStats.Add(modStats[statID]);

                    WriteLineIfDebug("    Selected stats added mod: " + modStats[statID].name);
                }
            }

            foreach (ComboBox box in miscBoxes)
            {
                if (box.SelectedIndex > 0)
                {
                    int idIndex = box.SelectedIndex - 1;
                    string statID = validMiscIDs[idIndex];
                    selectedStats.Add(miscStats[statID]);
                    WriteLineIfDebug("    Selected stats added misc: " + miscStats[statID].name);
                }
            }

            if (comboBoxWeaponArcane.SelectedIndex > 0)
            {
                int idIndex = comboBoxWeaponArcane.SelectedIndex - 1;
                string statID = validArcaneIDs[idIndex];
                selectedStats.Add(arcaneStats[statID]);

                WriteLineIfDebug("    Selected stats added arcane: " + arcaneStats[statID].name);
            }
            mergedStats = Methods.Calculation.StatMethods.sumStats(selectedStats);

            double summedDPSBurst = 0;
            double summedDPSSustained = 0;
            double summedDamage = 0;
            if (primary.id != "")
            {
                primaryWithAppliedStats = Methods.Calculation.StatMethods.sumStats(new List<Stats> { primary, mergedStats });

                summedDamage = Methods.Calculation.Weapon.calculateModDamagePreCrit(primaryWithAppliedStats) * Methods.Calculation.Weapon.calculateModAverageCritMultiplier(primaryWithAppliedStats) * Methods.Calculation.Weapon.calculateModMultishot(primaryWithAppliedStats);
                summedDPSBurst = Methods.Calculation.Weapon.calculateModDPS(primaryWithAppliedStats);
                summedDPSSustained = Methods.Calculation.Weapon.calculateModDPS(primaryWithAppliedStats, true);

                labelAverageCriticalValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModAverageCritMultiplier(primaryWithAppliedStats), 2).ToString() + "x";
                labelCriticalChanceValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModCritChance(primaryWithAppliedStats), 2).ToString() + "%";
                labelCriticalDamageValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModCritDamage(primaryWithAppliedStats), 2).ToString() + "x";
                labelStatusProjectileValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModStatusChance(primaryWithAppliedStats), 2).ToString() + "%";
                labelFireRateValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModSpeed(primaryWithAppliedStats), 2).ToString();
                labelMagazineValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModMagazine(primaryWithAppliedStats)).ToString();
                labelReloadValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModReloadTime(primaryWithAppliedStats), 2).ToString() + "s";
                labelAmmoEfficiencyValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModAmmoEfficiency(primaryWithAppliedStats), 2).ToString() + "%";
                labelMultishotValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModMultishot(primaryWithAppliedStats), 2).ToString();
                labelDamageValue.Text = Math.Round(summedDamage, 2).ToString("#,##0");
                labelDPSBurstValue.Text = Math.Round(summedDPSBurst, 2).ToString("#,##0");
                labelDPSSustainedValue.Text = Math.Round(summedDPSSustained, 2).ToString("#,##0");
            }
            else
            {
                foreach (Label lbl in primaryValueLabels)
                {
                    lbl.Text = "N/A";
                }
            }
            if (radial.id != "")
            {
                radialWithAppliedStats = Methods.Calculation.StatMethods.sumStats(new List<Stats> { radial, mergedStats });
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
                labelSummedDamageValue.Text = Math.Round(summedDamage, 2).ToString("#,##0");
                labelSummedDPSBurstValue.Text = Math.Round(summedDPSBurst, 2).ToString("#,##0");
                labelSummedDPSSustainedValue.Text = Math.Round(summedDPSSustained, 2).ToString("#,##0");

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

        public bool hasTag(Stats stat)
        {
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
            foreach (Stats stat in CommonVars.modStats.Values)
            {
                if (hasTag(stat))
                    validModIDs.Add(stat.id);
            }
            foreach (Stats stat in CommonVars.arcaneStats.Values)
            {
                if (hasTag(stat))
                    validArcaneIDs.Add(stat.id);
            }
            foreach (Stats stat in CommonVars.miscStats.Values)
            {
                if (hasTag(stat))
                    validMiscIDs.Add(stat.id);
            }
        }

        public void loadArcanesToSelectionBox()
        {
            WriteLineIfDebug("\nLoading valid arcanes\n");
            string statID = "";
            if (boxSelectedIDs.ContainsKey(comboBoxWeaponArcane))
            {
                statID = boxSelectedIDs[comboBoxWeaponArcane];
            }
            comboBoxWeaponArcane.Items.Clear();
            comboBoxWeaponArcane.Items.Add("None");
            foreach (string id in validArcaneIDs)
            {
                comboBoxWeaponArcane.Items.Add(arcaneStats[id].name);
            }
            if (boxSelectedIDs.ContainsKey(comboBoxWeaponArcane) && validArcaneIDs.Contains(statID))
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
                string statID = "";

                if (boxSelectedIDs.ContainsKey(box))
                {
                    statID = boxSelectedIDs[box];
                }
                if (validModIDs.Contains(statID))
                {
                    int index = validModIDs.IndexOf(statID) + 1;
                    box.SelectedIndex = index;
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
                string statID = "";

                if (boxSelectedIDs.ContainsKey(box))
                {
                    statID = boxSelectedIDs[box];
                }

                if (validMiscIDs.Contains(statID))
                {
                    int index = validMiscIDs.IndexOf(statID) + 1;
                    box.SelectedIndex = index;
                }
                else
                {
                    box.SelectedIndex = 0;
                }
            }
            setHandlerPause(false);
        }

        public void stashBoxIDs()
        {
            boxSelectedIDs.Clear();
            foreach (ComboBox box in modBoxes)
            {
                if (box.SelectedIndex > 0)
                {
                    int idIndex = box.SelectedIndex - 1;
                    string statID = validModIDs[idIndex];
                    boxSelectedIDs.Add(box, statID);
                }
            }
            foreach (ComboBox box in miscBoxes)
            {
                if (box.SelectedIndex > 0)
                {
                    int idIndex = box.SelectedIndex - 1;
                    string statID = validMiscIDs[idIndex];
                    boxSelectedIDs.Add(box, statID);
                }
            }
            if (comboBoxWeaponArcane.SelectedIndex > 0)
            {
                int idIndex = comboBoxWeaponArcane.SelectedIndex - 1;
                string statID = validArcaneIDs[idIndex];
                boxSelectedIDs.Add(comboBoxWeaponArcane, statID);
            }
        }

        public void restoreFromStash()
        {
            foreach (ComboBox box in modBoxes)
            {
                if (!boxSelectedIDs.ContainsKey(box))
                {
                    box.SelectedIndex = 0;
                    continue;
                }
                string statID = boxSelectedIDs[box];
                if (validModIDs.Contains(statID))
                {
                    int index = validModIDs.IndexOf(statID) + 1;
                    box.SelectedIndex = index;
                }
            }
            if (boxSelectedIDs.ContainsKey(comboBoxWeaponArcane))
            {
                string statID = boxSelectedIDs[comboBoxWeaponArcane];
                if (validArcaneIDs.Contains(statID))
                {
                    int index = validArcaneIDs.IndexOf(statID) + 1;
                    comboBoxWeaponArcane.SelectedIndex = index;
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
                int idIndex = comboBoxWeaponArcane.SelectedIndex - 1;
                string statID = validArcaneIDs[idIndex];
                s += "arcane=" + statID + "\n";
            }
            else
            {
                s += "arcane=\n";
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
                    }
                    else
                    {
                        WriteLineIfDebug("Weapon ID in save file not found: " + value);
                        return;
                    }
                }
                else if (key == "arcane")
                {
                    if (value != "" && CommonVars.arcaneStats.ContainsKey(value))
                    {
                        WriteLineIfDebug("Setting arcane to " + value);
                        int index = validArcaneIDs.IndexOf(value) + 1;
                        comboBoxWeaponArcane.SelectedIndex = index;
                    }
                }
                else if (key == "mods")
                {
                    string[] modIDs = value.Split(':', StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < modIDs.Length && i < modBoxes.Count; i++)
                    {
                        string modID = modIDs[i];
                        if (CommonVars.modStats.ContainsKey(modID))
                        {
                            WriteLineIfDebug("Setting mod box " + (i + 1) + " to " + modID);
                            int index = validModIDs.IndexOf(modID) + 1;
                            modBoxes[i].SelectedIndex = index;
                        }
                    }
                }
                else if (key == "misc")
                {
                    string[] miscIDs = value.Split(':', StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < miscIDs.Length && i < miscBoxes.Count; i++)
                    {
                        string miscID = miscIDs[i];
                        if (CommonVars.miscStats.ContainsKey(miscID))
                        {
                            WriteLineIfDebug("Setting misc box " + (i + 1) + " to " + miscID);
                            int index = validMiscIDs.IndexOf(miscID) + 1;
                            miscBoxes[i].SelectedIndex = index;
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
            primaryValueLabels.Add(labelStatusMultishotValue);
            primaryValueLabels.Add(labelDPSBurstValue);
            primaryValueLabels.Add(labelDPSSustainedValue);

            radialValueLabels.Add(labelRadialAverageCritMultValue);
            radialValueLabels.Add(labelRadialCriticalChanceValue);
            radialValueLabels.Add(labelRadialCriticalMultiplierValue);
            radialValueLabels.Add(labelRadialDPSBurstValue);
            radialValueLabels.Add(labelRadialDPSSustainedValue);
            radialValueLabels.Add(labelRadialStatusMultishotValue);
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

        }

        private void ToolStripMenuItemSelectWeapon_Click(object sender, EventArgs e)
        {
            stashBoxIDs();

            FormWeaponSelection form = new FormWeaponSelection();
            form.mainWindow = this;
            form.ShowDialog();
            loadWeapon(currentWeapon);
        }

        private void toolstripButtonEffectWizard_Click(object sender, EventArgs e)
        {
            stashBoxIDs();

            FormStatWizard form = new FormStatWizard();
            form.ShowDialog();

            LoadAndSave.loadFireModeFiles();
            LoadAndSave.loadModFiles();
            LoadAndSave.loadArcaneFiles();
            LoadAndSave.loadMiscFiles();
            LoadAndSave.loadWeaponFiles();
            loadValidIDs();
            loadArcanesToSelectionBox();
            loadModsToSelectionBox();
            loadMiscsToSelectionBox();
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

            updateWeaponStats();
        }
        private void comboBoxMisc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pauseHandler)
                return;

            updateWeaponStats();
        }

        private void comboBoxWeaponArcane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pauseHandler)
                return;

            updateWeaponStats();
        }

        private void addWeaponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWeaponWizard form = new FormWeaponWizard();
            form.ShowDialog();
            LoadAndSave.loadWeaponFiles();
        }

        private void comboBoxFireMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            primary = currentWeapon.fireModes[comboBoxFireMode.SelectedIndex];
            WriteLineIfDebug("Selected fire mode: " + primary.id + " : " + primary.name);
            if (currentWeapon.fireModesRadials.ContainsKey(primary.id))
            {
                radial = currentWeapon.fireModesRadials[primary.id];
            }
            else
            {
                radial = new Stats();
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
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
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
    }
}
