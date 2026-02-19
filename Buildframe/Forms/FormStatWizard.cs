using Buildframe.Methods;
using System.Windows.Forms;

namespace Buildframe.Forms
{
    public partial class FormStatWizard : Form
    {
        public FormStatWizard()
        {
            InitializeComponent();
        }

        bool multishotBaseEdited = false;
        bool currentlyTracking = true;
        bool fieldHasBeenChanged = false;
        List<NumericUpDown> listBaseFields = new();
        List<NumericUpDown> listModFields = new();
        List<NumericUpDown> listFinalFields = new();
        string loadedFilePath = "";
        string loadedID = "";
        string loadedName = "";

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormStatWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fieldHasBeenChanged)
            {
                if (MessageBox.Show("You have unsaved changes. Are you sure you want to leave?", ToolName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        void genID()
        {
            List<string> list = new();
            int index = comboBox1.SelectedIndex;
            string newID = Guid.NewGuid().ToString().Substring(0, 18);
            if (index == 0)
            {
                list = CommonVars.modStats.Keys.ToList();
            }
            else if (index == 1)
            {
                list = CommonVars.arcaneStats.Keys.ToList();
            }
            else if (index == 2)
            {
                list = CommonVars.miscStats.Keys.ToList();
            }
            else if (index == 3)
            {
                list = CommonVars.fireModeStats.Keys.ToList();
            }
            while (list.Contains(newID))
            {
                newID = Guid.NewGuid().ToString().Substring(0, 18);
            }
            textBoxID.Text = newID;
        }
        public void loadFile(string filePath)
        {
            WriteLineIfDebug("Loading stats from file: " + filePath);
            GameData.StatsData stats = LoadAndSave.loadStatFromFile(filePath);
            if (stats.id != "")
            {
                loadStatsToForm(stats);
                loadedFilePath = filePath;
                loadedID = stats.id;
                loadedName = stats.name;
                if (filePath.Contains("Mods"))
                {
                    comboBox1.SelectedIndex = 0;
                }
                else if (filePath.Contains("Arcanes"))
                {
                    comboBox1.SelectedIndex = 1;
                }
                else if (filePath.Contains("Misc"))
                {
                    comboBox1.SelectedIndex = 2;
                }
                else if (filePath.Contains("FireModes"))
                {
                    comboBox1.SelectedIndex = 3;
                }
            }
            else
            {
                MessageBox.Show("Failed to load stats from the selected file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadStatsToForm(GameData.StatsData stats)
        {
            currentlyTracking = false;
            fieldHasBeenChanged = false;

            textBoxName.Text = stats.name;
            textBoxDescription.Text = stats.description;
            textBoxID.Text = stats.id;
            textBoxTags.Text = stats.tags;
            checkBoxIncarnon.Checked = stats.incarnon;

            numericUpDownPunchthrough.Value = (decimal)stats.punchthrough;
            numericUpDownBaseDamage.Value = (decimal)stats.baseDamage;
            numericUpDownBaseAttackSpeed.Value = (decimal)stats.baseAttackSpeed;
            numericUpDownBaseReloadTime.Value = (decimal)stats.baseReloadTime;
            numericUpDownBaseAmmoEfficiency.Value = (decimal)stats.baseAmmoEfficiency;
            numericUpDownBaseMagazine.Value = (decimal)stats.baseMagazine;
            numericUpDownBaseChargeTime.Value = (decimal)stats.baseChargeTime;
            numericUpDownBaseImpact.Value = (decimal)stats.baseImpact;
            numericUpDownBasePuncture.Value = (decimal)stats.basePuncture;
            numericUpDownBaseSlash.Value = (decimal)stats.baseSlash;
            numericUpDownBaseHeat.Value = (decimal)stats.baseHeat;
            numericUpDownBaseCold.Value = (decimal)stats.baseCold;
            numericUpDownBaseElectric.Value = (decimal)stats.baseElectric;
            numericUpDownBaseToxin.Value = (decimal)stats.baseToxin;
            numericUpDownBaseBlast.Value = (decimal)stats.baseBlast;
            numericUpDownBaseRadiation.Value = (decimal)stats.baseRadiation;
            numericUpDownBaseViral.Value = (decimal)stats.baseViral;
            numericUpDownBaseCorrosive.Value = (decimal)stats.baseCorrosive;
            numericUpDownBaseMagnetic.Value = (decimal)stats.baseMagnetic;
            numericUpDownBaseGas.Value = (decimal)stats.baseGas;
            numericUpDownBaseMultishot.Value = (decimal)stats.baseMultishot;
            numericUpDownBaseCriticalChance.Value = (decimal)stats.baseCriticalChance;
            numericUpDownBaseCriticalDamage.Value = (decimal)stats.baseCriticalDamage;
            numericUpDownBaseStatusChance.Value = (decimal)stats.baseStatusChance;
            numericUpDownBaseStatusDamage.Value = (decimal)stats.baseStatusDamage;
            numericUpDownBaseReserveAmmo.Value = (decimal)stats.baseReserveAmmo;

            numericUpDownModDamage.Value = (decimal)stats.modDamage;
            numericUpDownAbilityWeaponDamage.Value = (decimal)stats.modDamagePercentage;
            numericUpDownModDamageFaction.Value = (decimal)stats.modDamageFaction;
            numericUpDownModAttackSpeed.Value = (decimal)stats.modAttackSpeed;
            numericUpDownModReloadTime.Value = (decimal)stats.modReloadTime;
            numericUpDownModMagazine.Value = (decimal)stats.modMagazine;
            numericUpDownModChargeTime.Value = (decimal)stats.modChargeTime;
            numericUpDownModImpact.Value = (decimal)stats.modImpact;
            numericUpDownModPuncture.Value = (decimal)stats.modPuncture;
            numericUpDownModSlash.Value = (decimal)stats.modSlash;
            numericUpDownModHeat.Value = (decimal)stats.modHeat;
            numericUpDownModCold.Value = (decimal)stats.modCold;
            numericUpDownModElectric.Value = (decimal)stats.modElectric;
            numericUpDownModToxin.Value = (decimal)stats.modToxin;
            numericUpDownModBlast.Value = (decimal)stats.modBlast;
            numericUpDownModRadiation.Value = (decimal)stats.modRadiation;
            numericUpDownModViral.Value = (decimal)stats.modViral;
            numericUpDownModCorrosive.Value = (decimal)stats.modCorrosive;
            numericUpDownModMagnetic.Value = (decimal)stats.modMagnetic;
            numericUpDownModGas.Value = (decimal)stats.modGas;
            numericUpDownModMultishot.Value = (decimal)stats.modMultishot;
            numericUpDownModCriticalChance.Value = (decimal)stats.modCriticalChance;
            numericUpDownModCriticalDamage.Value = (decimal)stats.modCriticalDamage;
            numericUpDownModStatusChance.Value = (decimal)stats.modStatusChance;
            numericUpDownModStatusDamage.Value = (decimal)stats.modStatusDamage;
            numericUpDownModReserveAmmo.Value = (decimal)stats.modReserveAmmo;

            numericUpDownFinalDamageMult.Value = (decimal)stats.finalDamagePercentage + 100;
            numericUpDownFinalAttackSpeed.Value = (decimal)stats.finalAttackSpeed + 100;
            numericUpDownFinalReloadTime.Value = (decimal)stats.finalReloadTime;
            numericUpDownFinalMagazine.Value = (decimal)stats.finalMagazine;
            numericUpDownFinalChargeTime.Value = (decimal)stats.finalChargeTime;
            numericUpDownFinalImpact.Value = (decimal)stats.finalImpact;
            numericUpDownFinalPuncture.Value = (decimal)stats.finalPuncture;
            numericUpDownFinalSlash.Value = (decimal)stats.finalSlash;
            numericUpDownFinalHeat.Value = (decimal)stats.finalHeat;
            numericUpDownFinalCold.Value = (decimal)stats.finalCold;
            numericUpDownFinalElectric.Value = (decimal)stats.finalElectric;
            numericUpDownFinalToxin.Value = (decimal)stats.finalToxin;
            numericUpDownFinalBlast.Value = (decimal)stats.finalBlast;
            numericUpDownFinalRadiation.Value = (decimal)stats.finalRadiation;
            numericUpDownFinalViral.Value = (decimal)stats.finalViral;
            numericUpDownFinalCorrosive.Value = (decimal)stats.finalCorrosive;
            numericUpDownFinalMagnetic.Value = (decimal)stats.finalMagnetic;
            numericUpDownFinalGas.Value = (decimal)stats.finalGas;
            numericUpDownFinalMultishot.Value = (decimal)stats.finalMultishot;
            numericUpDownFinalCriticalChance.Value = (decimal)stats.finalCriticalChance;
            numericUpDownFinalCriticalDamage.Value = (decimal)stats.finalCriticalDamage;
            numericUpDownFinalStatusChance.Value = (decimal)stats.finalStatusChance;
            numericUpDownFinalStatusDamage.Value = (decimal)stats.finalStatusDamage;

            currentlyTracking = true;
        }
        private void FormStatWizard_Load(object sender, EventArgs e)
        {
            Text = ToolName + " - Stat Editor";
            genID();
            comboBox1.SelectedIndex = 0;

            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is NumericUpDown nud)
                {
                    WriteLineIfDebug("Adding to base list: " + nud.Name, true);
                    listBaseFields.Add(nud);
                    nud.ValueChanged += numericUpDown_TrackChanged;
                }
            }

            foreach (Control c in tableLayoutPanel3.Controls)
            {
                if (c is NumericUpDown nud)
                {
                    WriteLineIfDebug("Adding to mod list: " + nud.Name, true);
                    listModFields.Add(nud);
                    nud.ValueChanged += numericUpDown_TrackChanged;
                }
            }

            foreach (Control c in tableLayoutPanel4.Controls)
            {
                if (c is NumericUpDown nud)
                {
                    WriteLineIfDebug("Adding to final list: " + nud.Name, true);
                    listFinalFields.Add(nud);
                    nud.ValueChanged += numericUpDown_TrackChanged;
                }
            }

            tableLayoutPanel3.Width = tableLayoutPanel1.Width;
            tableLayoutPanel4.Width = tableLayoutPanel1.Width;

            tableLayoutPanel3.Height = tableLayoutPanel1.Height;
            tableLayoutPanel4.Height = tableLayoutPanel1.Height;

            Button close = new Button();
            close.Click += buttonCancel_Click;
            this.CancelButton = close;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                bool isABaseChanged = false;
                foreach (NumericUpDown nud in listBaseFields)
                {
                    if (nud.Value != 0)
                    {
                        isABaseChanged = true;
                        break;
                    }
                }
                if (isABaseChanged)
                {
                    if (MessageBox.Show("A base value has been changed for a mod effect.\nThis is typically only done in error.\nContinue?", ToolName, MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            if (textBoxName.Text.Trim() == "" || textBoxName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("A name is required.", ToolName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxID.Text == loadedID)
            {
                if (File.Exists(loadedFilePath))
                {
                    if (MessageBox.Show("\"" + loadedName + "\" will be overwritten unless you change the ID.\nContinue?", ToolName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        WriteLineIfDebug("Deleting loaded file: " + loadedFilePath);
                        File.Delete(loadedFilePath);
                    }
                }
            }
            fieldHasBeenChanged = false;
            GameData.StatsData stats = new GameData.StatsData();

            stats.name = textBoxName.Text.Trim();

            string desc = textBoxDescription.Text.Trim();
            stats.description = desc;


            stats.id = textBoxID.Text.Trim();
            stats.tags = textBoxTags.Text.Trim();
            stats.incarnon = checkBoxIncarnon.Checked;

            stats.punchthrough = (double)numericUpDownPunchthrough.Value;
            stats.baseDamage = (double)numericUpDownBaseDamage.Value;
            stats.baseAttackSpeed = (double)numericUpDownBaseAttackSpeed.Value;
            stats.baseReloadTime = (double)numericUpDownBaseReloadTime.Value;
            stats.baseAmmoEfficiency = (double)numericUpDownBaseAmmoEfficiency.Value;
            stats.baseMagazine = (double)numericUpDownBaseMagazine.Value;
            stats.baseChargeTime = (double)numericUpDownBaseChargeTime.Value;
            stats.baseImpact = (double)numericUpDownBaseImpact.Value;
            stats.basePuncture = (double)numericUpDownBasePuncture.Value;
            stats.baseSlash = (double)numericUpDownBaseSlash.Value;
            stats.baseHeat = (double)numericUpDownBaseHeat.Value;
            stats.baseCold = (double)numericUpDownBaseCold.Value;
            stats.baseElectric = (double)numericUpDownBaseElectric.Value;
            stats.baseToxin = (double)numericUpDownBaseToxin.Value;
            stats.baseBlast = (double)numericUpDownBaseBlast.Value;
            stats.baseRadiation = (double)numericUpDownBaseRadiation.Value;
            stats.baseViral = (double)numericUpDownBaseViral.Value;
            stats.baseCorrosive = (double)numericUpDownBaseCorrosive.Value;
            stats.baseMagnetic = (double)numericUpDownBaseMagnetic.Value;
            stats.baseGas = (double)numericUpDownBaseGas.Value;
            stats.baseMultishot = (double)numericUpDownBaseMultishot.Value;
            stats.baseCriticalChance = (double)numericUpDownBaseCriticalChance.Value;
            stats.baseCriticalDamage = (double)numericUpDownBaseCriticalDamage.Value;
            stats.baseStatusChance = (double)numericUpDownBaseStatusChance.Value;
            stats.baseStatusDamage = (double)numericUpDownBaseStatusDamage.Value;
            stats.baseReserveAmmo = (double)numericUpDownBaseReserveAmmo.Value;

            stats.modDamage = (double)numericUpDownModDamage.Value;
            stats.modDamagePercentage = (double)numericUpDownAbilityWeaponDamage.Value;
            stats.modDamageFaction = (double)numericUpDownModDamageFaction.Value;
            stats.modAttackSpeed = (double)numericUpDownModAttackSpeed.Value;
            stats.modReloadTime = (double)numericUpDownModReloadTime.Value;
            stats.modMagazine = (double)numericUpDownModMagazine.Value;
            stats.modChargeTime = (double)numericUpDownModChargeTime.Value;
            stats.modImpact = (double)numericUpDownModImpact.Value;
            stats.modPuncture = (double)numericUpDownModPuncture.Value;
            stats.modSlash = (double)numericUpDownModSlash.Value;
            stats.modHeat = (double)numericUpDownModHeat.Value;
            stats.modCold = (double)numericUpDownModCold.Value;
            stats.modElectric = (double)numericUpDownModElectric.Value;
            stats.modToxin = (double)numericUpDownModToxin.Value;
            stats.modBlast = (double)numericUpDownModBlast.Value;
            stats.modRadiation = (double)numericUpDownModRadiation.Value;
            stats.modViral = (double)numericUpDownModViral.Value;
            stats.modCorrosive = (double)numericUpDownModCorrosive.Value;
            stats.modMagnetic = (double)numericUpDownModMagnetic.Value;
            stats.modGas = (double)numericUpDownModGas.Value;
            stats.modMultishot = (double)numericUpDownModMultishot.Value;
            stats.modCriticalChance = (double)numericUpDownModCriticalChance.Value;
            stats.modCriticalDamage = (double)numericUpDownModCriticalDamage.Value;
            stats.modStatusChance = (double)numericUpDownModStatusChance.Value;
            stats.modStatusDamage = (double)numericUpDownModStatusDamage.Value;
            stats.modReserveAmmo = (double)numericUpDownModReserveAmmo.Value;

            stats.finalDamagePercentage = (double)numericUpDownFinalDamageMult.Value - 100;
            stats.finalAttackSpeed = (double)numericUpDownFinalAttackSpeed.Value - 100;
            stats.finalReloadTime = (double)numericUpDownFinalReloadTime.Value;
            stats.finalMagazine = (double)numericUpDownFinalMagazine.Value;
            stats.finalChargeTime = (double)numericUpDownFinalChargeTime.Value;
            stats.finalImpact = (double)numericUpDownFinalImpact.Value;
            stats.finalPuncture = (double)numericUpDownFinalPuncture.Value;
            stats.finalSlash = (double)numericUpDownFinalSlash.Value;
            stats.finalHeat = (double)numericUpDownFinalHeat.Value;
            stats.finalCold = (double)numericUpDownFinalCold.Value;
            stats.finalElectric = (double)numericUpDownFinalElectric.Value;
            stats.finalToxin = (double)numericUpDownFinalToxin.Value;
            stats.finalBlast = (double)numericUpDownFinalBlast.Value;
            stats.finalRadiation = (double)numericUpDownFinalRadiation.Value;
            stats.finalViral = (double)numericUpDownFinalViral.Value;
            stats.finalCorrosive = (double)numericUpDownFinalCorrosive.Value;
            stats.finalMagnetic = (double)numericUpDownFinalMagnetic.Value;
            stats.finalGas = (double)numericUpDownFinalGas.Value;
            stats.finalMultishot = (double)numericUpDownFinalMultishot.Value;
            stats.finalCriticalChance = (double)numericUpDownFinalCriticalChance.Value;
            stats.finalCriticalDamage = (double)numericUpDownFinalCriticalDamage.Value;
            stats.finalStatusChance = (double)numericUpDownFinalStatusChance.Value;
            stats.finalStatusDamage = (double)numericUpDownFinalStatusDamage.Value;

            string fileName = LoadAndSave.cleanFileName(stats.name.Trim() + " - " + stats.id.Trim() + ".cfg");

            string filePath = envAPPLOC;

            if (comboBox1.SelectedIndex == 0)
            {
                filePath = System.IO.Path.Combine(envAPPLOC, "Data", "Mods", fileName);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                filePath = System.IO.Path.Combine(envAPPLOC, "Data", "Arcanes", fileName);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                filePath = System.IO.Path.Combine(envAPPLOC, "Data", "Misc", fileName);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                filePath = System.IO.Path.Combine(envAPPLOC, "Data", "FireModes", fileName);
            }

            LoadAndSave.saveStatToFile(filePath, stats);

            Close();
        }

        private void FormStatWizard_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void tabControl1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string filePath = files[0];
                    loadFile(filePath);
                }
            }
        }

        private void tabControl1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            string id = textBoxID.Text.Trim();
            foreach (string s in CommonVars.ProhibPathChars)
            {
                id = id.Replace(s, "");
            }
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                string s = c.ToString();
                id = id.Replace(s, "");
            }

            if (id.Trim() == "" || id.Trim() == string.Empty)
            {
                genID();
                return;
            }
            textBoxID.Text = id;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {
                if (numericUpDownBaseMultishot.Value == 0 && !multishotBaseEdited)
                {
                    numericUpDownBaseMultishot.ValueChanged -= numericUpDownBaseMultishot_ValueChanged;
                    numericUpDownBaseMultishot.Value = 1;
                    numericUpDownBaseMultishot.ValueChanged += numericUpDownBaseMultishot_ValueChanged;

                }
            }
            else if (!multishotBaseEdited)
            {
                if (numericUpDownBaseMultishot.Value == 1)
                {
                    numericUpDownBaseMultishot.ValueChanged -= numericUpDownBaseMultishot_ValueChanged;
                    numericUpDownBaseMultishot.Value = 0;
                    numericUpDownBaseMultishot.ValueChanged += numericUpDownBaseMultishot_ValueChanged;
                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                checkBoxIncarnon.Enabled = true;
            }
            else
            {
                checkBoxIncarnon.Enabled = false;
                checkBoxIncarnon.Checked = false;
            }
        }

        private void numericUpDownBaseMultishot_ValueChanged(object sender, EventArgs e)
        {
            multishotBaseEdited = true;
        }

        private void toolStripButtonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a stat file to load";
            openFileDialog1.Filter = "Config Files|*.cfg";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = System.IO.Path.Combine(envAPPLOC, "Data");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadFile(openFileDialog1.FileName);
            }
        }

        private void textBoxTags_Leave(object sender, EventArgs e)
        {
            if (textBoxTags.Text == String.Empty || textBoxTags.Text.Trim() == "")
            {
                textBoxTags.Text = "Any";
            }
        }

        private void numericUpDown_TrackChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            WriteLineIfDebug(numericUpDown.Name + " changed to " + numericUpDown.Value, DebuggingStatWindow);

            if (!currentlyTracking || fieldHasBeenChanged) return;

            fieldHasBeenChanged = true;
        }
    }
}
