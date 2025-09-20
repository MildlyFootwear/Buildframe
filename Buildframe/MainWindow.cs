using Buildframe.Forms;
using Buildframe.GameData;
using Buildframe.Methods;
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
        public Stats primary = new Stats();
        public Stats radial = new Stats();
        public List<Stats> selectedStats = new List<Stats>();
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
            pauseHandler = true;
            loadValidIDs();
            loadArcanesToSelectionBox();
            loadModsToSelectionBox();
            loadMiscsToSelectionBox();
            pauseHandler = false;
            comboBoxFireMode.SelectedIndex = 0;
        }

        public void updateWeaponStats()
        {
            WriteLineIfDebug("\nUpdating weapon stats\n");
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
            if (primary.id != "")
            {
                primaryWithAppliedStats = Methods.Calculation.StatMethods.sumStats(new List<Stats> { primary, mergedStats });
                labelAverageCriticalValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModAverageCritMultiplier(primaryWithAppliedStats), 2).ToString() + "x";
                labelCriticalChanceValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModCritChance(primaryWithAppliedStats), 2).ToString() + "%";
                labelCriticalDamageValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModCritDamage(primaryWithAppliedStats), 2).ToString() + "x";
                labelStatusProjectileValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModStatusChance(primaryWithAppliedStats), 2).ToString() + "%";
                labelDamageValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModDamagePreCrit(primaryWithAppliedStats) * Methods.Calculation.Weapon.calculateModAverageCritMultiplier(primaryWithAppliedStats) * Methods.Calculation.Weapon.calculateModMultishot(primaryWithAppliedStats), 2).ToString();
                labelFireRateValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModSpeed(primaryWithAppliedStats), 2).ToString();
                labelMagazineValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModMagazine(primaryWithAppliedStats)).ToString();
                labelReloadValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModReloadTime(primaryWithAppliedStats), 2).ToString() + "s";
                labelAmmoEfficiencyValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModAmmoEfficiency(primaryWithAppliedStats), 2).ToString() + "%";
                labelMultishotValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModMultishot(primaryWithAppliedStats), 2).ToString();
                labelDPSBurstValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModDPS(primaryWithAppliedStats), 2).ToString();
                labelDPSSustainedValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModDPS(primaryWithAppliedStats, true), 2).ToString();
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
                labelRadialDPSBurstValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModDPS(radialWithAppliedStats), 2).ToString();
                labelRadialDPSSustainedValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModDPS(radialWithAppliedStats, true), 2).ToString();

            }
            else
            {
                foreach (Label lbl in radialValueLabels)
                {
                    lbl.Text = "N/A";
                }
            }
        }

        public bool hasTag(Stats stat)
        {
            if (stat.tags.Contains("Any") || tags.Contains("Any"))
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
            if (boxSelectedIDs.ContainsKey(comboBoxWeaponArcane))
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

            pauseHandler = true;

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

            pauseHandler = false;
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

            pauseHandler = true;

            foreach (ComboBox box in miscBoxes)
            {
                if (!boxSelectedIDs.ContainsKey(box))
                {
                    box.SelectedIndex = 0;
                    continue;
                }
                string statID = boxSelectedIDs[box];
                if (validMiscIDs.Contains(statID))
                {
                    int index = validMiscIDs.IndexOf(statID) + 1;
                    box.SelectedIndex = index;
                }
            }

            pauseHandler = false;
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

        }

        private void loadWeaponToolStripMenuItem_Click(object sender, EventArgs e)
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
            WriteLineIfDebug("Selected fire mode: " + primary.id + " : " +primary.name);
            if (currentWeapon.fireModesRadials.ContainsKey(primary.id))
            {
                radial = currentWeapon.fireModesRadials[primary.id];
            }
            else
            {
                radial = new Stats();
            }
            updateWeaponStats();
        }
    }
}
