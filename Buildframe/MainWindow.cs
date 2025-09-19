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
        public List<Label> primaryValueLabels = new();
        public List<Label> radialValueLabels = new();
        public Dictionary<ComboBox, string> boxSelectedIDs = new();
        public string[] tags = { "Any" };

        public void loadWeapon(Weapon weapon)
        {
            stashBoxIDs();

            currentWeapon = weapon;
            tags = weapon.tags.Split(' ');
            comboBoxFireMode.Items.Clear();
            foreach (Stats fm in weapon.fireModes)
            {
                comboBoxFireMode.Items.Add(fm.name);
            }
            labelWeaponName.Text = weapon.name;

            loadValidIDs();
            loadArcanesToSelectionBox();
            loadModsToSelectionBox();
            comboBoxFireMode.SelectedIndex = 0;
        }

        public void updateWeaponStats()
        {
            selectedStats.Clear();
            boxSelectedIDs.Clear();
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
                labelDamageValue.Text = Math.Round(Methods.Calculation.Weapon.calculateModDamagePreCrit(primaryWithAppliedStats), 2).ToString();
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
            if (validArcaneIDs.Contains(statID))
            {
                int index = validArcaneIDs.IndexOf(statID) + 1;
                comboBoxWeaponArcane.SelectedIndex = index;
            }
            else
            {
                comboBoxWeaponArcane.SelectedIndex = 0;
            }
        }

        public void loadModsToSelectionBox()
        {
            comboBoxMod1.Items.Clear();
            comboBoxMod2.Items.Clear();
            comboBoxMod3.Items.Clear();
            comboBoxMod4.Items.Clear();
            comboBoxMod5.Items.Clear();
            comboBoxMod6.Items.Clear();
            comboBoxMod7.Items.Clear();
            comboBoxMod8.Items.Clear();

            comboBoxMod1.Items.Add("None");
            comboBoxMod2.Items.Add("None");
            comboBoxMod3.Items.Add("None");
            comboBoxMod4.Items.Add("None");
            comboBoxMod5.Items.Add("None");
            comboBoxMod6.Items.Add("None");
            comboBoxMod7.Items.Add("None");
            comboBoxMod8.Items.Add("None");

            foreach (string id in validModIDs)
            {
                comboBoxMod1.Items.Add(modStats[id].name);
                comboBoxMod2.Items.Add(modStats[id].name);
                comboBoxMod3.Items.Add(modStats[id].name);
                comboBoxMod4.Items.Add(modStats[id].name);
                comboBoxMod5.Items.Add(modStats[id].name);
                comboBoxMod6.Items.Add(modStats[id].name);
                comboBoxMod7.Items.Add(modStats[id].name);
                comboBoxMod8.Items.Add(modStats[id].name);
            }

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

            loadWeapon(weaponStats.Values.ToList()[0]);
        }

        private void loadWeaponToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

            restoreFromStash();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.SavedPosition = this.Location;
            Settings.Default.SavedSize = this.Size;
            Settings.Default.Save();
        }

        private void comboBoxMod1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWeaponStats();
        }

        private void comboBoxMod2_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWeaponStats();
        }

        private void comboBoxMod3_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWeaponStats();
        }

        private void comboBoxMod4_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWeaponStats();
        }

        private void comboBoxMod5_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWeaponStats();
        }

        private void comboBoxMod6_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWeaponStats();
        }

        private void comboBoxMod7_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWeaponStats();
        }

        private void comboBoxMod8_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWeaponStats();
        }

        private void comboBoxWeaponArcane_SelectedIndexChanged(object sender, EventArgs e)
        {
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
