namespace Buildframe
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            toolStrip1 = new ToolStrip();
            toolStripButtonSelectWeapon = new ToolStripButton();
            toolStripDropDownButtonSaveLoad = new ToolStripDropDownButton();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButtonCreationWizards = new ToolStripDropDownButton();
            createFireModeOrBuffToolStripMenuItem = new ToolStripMenuItem();
            createWeaponToolStripMenuItem = new ToolStripMenuItem();
            toolStripButtonInfo = new ToolStripButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelFireTimeValue = new Label();
            labelFireTime = new Label();
            labelSummedDamageValue = new Label();
            label5 = new Label();
            labelDPSSustainedValue = new Label();
            labelDPSBurstValue = new Label();
            labelAverageCriticalValue = new Label();
            labelCriticalDamageValue = new Label();
            labelCriticalChanceValue = new Label();
            labelReloadValue = new Label();
            labelMagazineValue = new Label();
            labelMultishotValue = new Label();
            labelFireRateValue = new Label();
            labelAverageCritical = new Label();
            labelCriticalDamage = new Label();
            labelCriticalChance = new Label();
            labelReload = new Label();
            labelMagazine = new Label();
            labelMultishot = new Label();
            labelFireRate = new Label();
            labelDPSSustained = new Label();
            labelDPSBurst = new Label();
            labelAmmoEfficiency = new Label();
            labelAmmoEfficiencyValue = new Label();
            labelStatusProjectile = new Label();
            labelStatus = new Label();
            labelStatusProjectileValue = new Label();
            labelStatusPerSecondValue = new Label();
            labelDamage = new Label();
            labelDamageValue = new Label();
            label19 = new Label();
            label18 = new Label();
            labelRadialDPSSustainedValue = new Label();
            labelRadialDPSBurstValue = new Label();
            label16 = new Label();
            label17 = new Label();
            label = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            labelRadialCriticalChanceValue = new Label();
            labelRadialStatusValue = new Label();
            labelRadialStatusMultishotValue = new Label();
            labelRadialDamageValue = new Label();
            labelRadialCriticalMultiplierValue = new Label();
            labelRadialAverageCritMultValue = new Label();
            label21 = new Label();
            labelSummedDPSSustainedValue = new Label();
            label20 = new Label();
            labelSummedDPSBurstValue = new Label();
            labelWeaponName = new Label();
            comboBoxFireMode = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboBoxArchgunArcane = new ComboBox();
            comboBoxMiscEffect12 = new ComboBox();
            comboBoxMiscEffect11 = new ComboBox();
            comboBoxMiscEffect10 = new ComboBox();
            comboBoxMiscEffect9 = new ComboBox();
            comboBoxMiscEffect8 = new ComboBox();
            comboBoxMiscEffect7 = new ComboBox();
            comboBoxMiscEffect6 = new ComboBox();
            comboBoxMiscEffect5 = new ComboBox();
            comboBoxMiscEffect4 = new ComboBox();
            comboBoxMiscEffect3 = new ComboBox();
            comboBoxMiscEffect2 = new ComboBox();
            comboBoxMiscEffect1 = new ComboBox();
            label3 = new Label();
            comboBoxMod8 = new ComboBox();
            comboBoxMod7 = new ComboBox();
            comboBoxMod6 = new ComboBox();
            comboBoxMod5 = new ComboBox();
            comboBoxMod4 = new ComboBox();
            comboBoxMod3 = new ComboBox();
            comboBoxMod2 = new ComboBox();
            label2 = new Label();
            comboBoxWeaponArcane = new ComboBox();
            label1 = new Label();
            comboBoxMod1 = new ComboBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            toolTipMods = new ToolTip(components);
            toolStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonSelectWeapon, toolStripDropDownButtonSaveLoad, toolStripDropDownButtonCreationWizards, toolStripButtonInfo });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1045, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSelectWeapon
            // 
            toolStripButtonSelectWeapon.AutoToolTip = false;
            toolStripButtonSelectWeapon.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSelectWeapon.Image = (Image)resources.GetObject("toolStripButtonSelectWeapon.Image");
            toolStripButtonSelectWeapon.ImageTransparentColor = Color.Magenta;
            toolStripButtonSelectWeapon.Name = "toolStripButtonSelectWeapon";
            toolStripButtonSelectWeapon.Size = new Size(89, 22);
            toolStripButtonSelectWeapon.Text = "Select Weapon";
            toolStripButtonSelectWeapon.Click += toolStripButtonSelectWeapon_Click;
            // 
            // toolStripDropDownButtonSaveLoad
            // 
            toolStripDropDownButtonSaveLoad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButtonSaveLoad.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            toolStripDropDownButtonSaveLoad.Image = (Image)resources.GetObject("toolStripDropDownButtonSaveLoad.Image");
            toolStripDropDownButtonSaveLoad.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButtonSaveLoad.Name = "toolStripDropDownButtonSaveLoad";
            toolStripDropDownButtonSaveLoad.Size = new Size(105, 22);
            toolStripDropDownButtonSaveLoad.Text = "Save/Load Build";
            toolStripDropDownButtonSaveLoad.ToolTipText = "Save and load builds to and from files.";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(130, 22);
            saveToolStripMenuItem.Text = "Save Build";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(130, 22);
            loadToolStripMenuItem.Text = "Load Build";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // toolStripDropDownButtonCreationWizards
            // 
            toolStripDropDownButtonCreationWizards.AutoToolTip = false;
            toolStripDropDownButtonCreationWizards.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButtonCreationWizards.DropDownItems.AddRange(new ToolStripItem[] { createFireModeOrBuffToolStripMenuItem, createWeaponToolStripMenuItem });
            toolStripDropDownButtonCreationWizards.Image = (Image)resources.GetObject("toolStripDropDownButtonCreationWizards.Image");
            toolStripDropDownButtonCreationWizards.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButtonCreationWizards.Name = "toolStripDropDownButtonCreationWizards";
            toolStripDropDownButtonCreationWizards.Size = new Size(150, 22);
            toolStripDropDownButtonCreationWizards.Text = "Create Effect Or Weapon";
            // 
            // createFireModeOrBuffToolStripMenuItem
            // 
            createFireModeOrBuffToolStripMenuItem.Name = "createFireModeOrBuffToolStripMenuItem";
            createFireModeOrBuffToolStripMenuItem.Size = new Size(211, 22);
            createFireModeOrBuffToolStripMenuItem.Text = "Create Effect or Fire Mode";
            createFireModeOrBuffToolStripMenuItem.Click += createFireModeOrBuffToolStripMenuItem_Click;
            // 
            // createWeaponToolStripMenuItem
            // 
            createWeaponToolStripMenuItem.Name = "createWeaponToolStripMenuItem";
            createWeaponToolStripMenuItem.Size = new Size(211, 22);
            createWeaponToolStripMenuItem.Text = "Create Weapon";
            createWeaponToolStripMenuItem.Click += createWeaponToolStripMenuItem_Click;
            // 
            // toolStripButtonInfo
            // 
            toolStripButtonInfo.AutoToolTip = false;
            toolStripButtonInfo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonInfo.Image = (Image)resources.GetObject("toolStripButtonInfo.Image");
            toolStripButtonInfo.ImageTransparentColor = Color.Magenta;
            toolStripButtonInfo.Name = "toolStripButtonInfo";
            toolStripButtonInfo.Size = new Size(32, 22);
            toolStripButtonInfo.Text = "Info";
            toolStripButtonInfo.Click += toolStripButtonInfo_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.13149F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.86851F));
            tableLayoutPanel1.Controls.Add(labelFireTimeValue, 1, 4);
            tableLayoutPanel1.Controls.Add(labelFireTime, 0, 4);
            tableLayoutPanel1.Controls.Add(labelSummedDamageValue, 1, 22);
            tableLayoutPanel1.Controls.Add(label5, 0, 22);
            tableLayoutPanel1.Controls.Add(labelDPSSustainedValue, 1, 13);
            tableLayoutPanel1.Controls.Add(labelDPSBurstValue, 1, 12);
            tableLayoutPanel1.Controls.Add(labelAverageCriticalValue, 1, 10);
            tableLayoutPanel1.Controls.Add(labelCriticalDamageValue, 1, 9);
            tableLayoutPanel1.Controls.Add(labelCriticalChanceValue, 1, 8);
            tableLayoutPanel1.Controls.Add(labelReloadValue, 1, 5);
            tableLayoutPanel1.Controls.Add(labelMagazineValue, 1, 2);
            tableLayoutPanel1.Controls.Add(labelMultishotValue, 1, 1);
            tableLayoutPanel1.Controls.Add(labelFireRateValue, 1, 0);
            tableLayoutPanel1.Controls.Add(labelAverageCritical, 0, 10);
            tableLayoutPanel1.Controls.Add(labelCriticalDamage, 0, 9);
            tableLayoutPanel1.Controls.Add(labelCriticalChance, 0, 8);
            tableLayoutPanel1.Controls.Add(labelReload, 0, 5);
            tableLayoutPanel1.Controls.Add(labelMagazine, 0, 2);
            tableLayoutPanel1.Controls.Add(labelMultishot, 0, 1);
            tableLayoutPanel1.Controls.Add(labelFireRate, 0, 0);
            tableLayoutPanel1.Controls.Add(labelDPSSustained, 0, 13);
            tableLayoutPanel1.Controls.Add(labelDPSBurst, 0, 12);
            tableLayoutPanel1.Controls.Add(labelAmmoEfficiency, 0, 3);
            tableLayoutPanel1.Controls.Add(labelAmmoEfficiencyValue, 1, 3);
            tableLayoutPanel1.Controls.Add(labelStatusProjectile, 0, 6);
            tableLayoutPanel1.Controls.Add(labelStatus, 0, 7);
            tableLayoutPanel1.Controls.Add(labelStatusProjectileValue, 1, 6);
            tableLayoutPanel1.Controls.Add(labelStatusPerSecondValue, 1, 7);
            tableLayoutPanel1.Controls.Add(labelDamage, 0, 11);
            tableLayoutPanel1.Controls.Add(labelDamageValue, 1, 11);
            tableLayoutPanel1.Controls.Add(label19, 0, 21);
            tableLayoutPanel1.Controls.Add(label18, 0, 20);
            tableLayoutPanel1.Controls.Add(labelRadialDPSSustainedValue, 1, 21);
            tableLayoutPanel1.Controls.Add(labelRadialDPSBurstValue, 1, 20);
            tableLayoutPanel1.Controls.Add(label16, 0, 14);
            tableLayoutPanel1.Controls.Add(label17, 0, 15);
            tableLayoutPanel1.Controls.Add(label, 0, 19);
            tableLayoutPanel1.Controls.Add(label13, 0, 16);
            tableLayoutPanel1.Controls.Add(label14, 0, 17);
            tableLayoutPanel1.Controls.Add(label15, 0, 18);
            tableLayoutPanel1.Controls.Add(labelRadialCriticalChanceValue, 1, 16);
            tableLayoutPanel1.Controls.Add(labelRadialStatusValue, 1, 14);
            tableLayoutPanel1.Controls.Add(labelRadialStatusMultishotValue, 1, 15);
            tableLayoutPanel1.Controls.Add(labelRadialDamageValue, 1, 19);
            tableLayoutPanel1.Controls.Add(labelRadialCriticalMultiplierValue, 1, 17);
            tableLayoutPanel1.Controls.Add(labelRadialAverageCritMultValue, 1, 18);
            tableLayoutPanel1.Controls.Add(label21, 0, 24);
            tableLayoutPanel1.Controls.Add(labelSummedDPSSustainedValue, 1, 24);
            tableLayoutPanel1.Controls.Add(label20, 0, 23);
            tableLayoutPanel1.Controls.Add(labelSummedDPSBurstValue, 1, 23);
            tableLayoutPanel1.Location = new Point(12, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 26;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(292, 547);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelFireTimeValue
            // 
            labelFireTimeValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFireTimeValue.CausesValidation = false;
            labelFireTimeValue.Location = new Point(173, 85);
            labelFireTimeValue.Name = "labelFireTimeValue";
            labelFireTimeValue.Size = new Size(115, 20);
            labelFireTimeValue.TabIndex = 54;
            // 
            // labelFireTime
            // 
            labelFireTime.AutoSize = true;
            labelFireTime.Location = new Point(4, 85);
            labelFireTime.Name = "labelFireTime";
            labelFireTime.Size = new Size(55, 15);
            labelFireTime.TabIndex = 53;
            labelFireTime.Text = "Fire Time";
            // 
            // labelSummedDamageValue
            // 
            labelSummedDamageValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSummedDamageValue.CausesValidation = false;
            labelSummedDamageValue.Location = new Point(173, 463);
            labelSummedDamageValue.Name = "labelSummedDamageValue";
            labelSummedDamageValue.Size = new Size(115, 20);
            labelSummedDamageValue.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 463);
            label5.Name = "label5";
            label5.Size = new Size(156, 15);
            label5.TabIndex = 51;
            label5.Text = "Average Damage (Summed)";
            // 
            // labelDPSSustainedValue
            // 
            labelDPSSustainedValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDPSSustainedValue.CausesValidation = false;
            labelDPSSustainedValue.Location = new Point(173, 274);
            labelDPSSustainedValue.Name = "labelDPSSustainedValue";
            labelDPSSustainedValue.Size = new Size(115, 20);
            labelDPSSustainedValue.TabIndex = 35;
            // 
            // labelDPSBurstValue
            // 
            labelDPSBurstValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDPSBurstValue.CausesValidation = false;
            labelDPSBurstValue.Location = new Point(173, 253);
            labelDPSBurstValue.Name = "labelDPSBurstValue";
            labelDPSBurstValue.Size = new Size(115, 20);
            labelDPSBurstValue.TabIndex = 34;
            // 
            // labelAverageCriticalValue
            // 
            labelAverageCriticalValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAverageCriticalValue.CausesValidation = false;
            labelAverageCriticalValue.Location = new Point(173, 211);
            labelAverageCriticalValue.Name = "labelAverageCriticalValue";
            labelAverageCriticalValue.Size = new Size(115, 20);
            labelAverageCriticalValue.TabIndex = 31;
            // 
            // labelCriticalDamageValue
            // 
            labelCriticalDamageValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCriticalDamageValue.CausesValidation = false;
            labelCriticalDamageValue.Location = new Point(173, 190);
            labelCriticalDamageValue.Name = "labelCriticalDamageValue";
            labelCriticalDamageValue.Size = new Size(115, 20);
            labelCriticalDamageValue.TabIndex = 30;
            // 
            // labelCriticalChanceValue
            // 
            labelCriticalChanceValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCriticalChanceValue.CausesValidation = false;
            labelCriticalChanceValue.Location = new Point(173, 169);
            labelCriticalChanceValue.Name = "labelCriticalChanceValue";
            labelCriticalChanceValue.Size = new Size(115, 20);
            labelCriticalChanceValue.TabIndex = 29;
            // 
            // labelReloadValue
            // 
            labelReloadValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelReloadValue.CausesValidation = false;
            labelReloadValue.Location = new Point(173, 106);
            labelReloadValue.Name = "labelReloadValue";
            labelReloadValue.Size = new Size(115, 20);
            labelReloadValue.TabIndex = 28;
            // 
            // labelMagazineValue
            // 
            labelMagazineValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelMagazineValue.CausesValidation = false;
            labelMagazineValue.Location = new Point(173, 43);
            labelMagazineValue.Name = "labelMagazineValue";
            labelMagazineValue.Size = new Size(115, 20);
            labelMagazineValue.TabIndex = 27;
            // 
            // labelMultishotValue
            // 
            labelMultishotValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelMultishotValue.CausesValidation = false;
            labelMultishotValue.Location = new Point(173, 22);
            labelMultishotValue.Name = "labelMultishotValue";
            labelMultishotValue.Size = new Size(115, 20);
            labelMultishotValue.TabIndex = 26;
            // 
            // labelFireRateValue
            // 
            labelFireRateValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFireRateValue.CausesValidation = false;
            labelFireRateValue.Location = new Point(173, 1);
            labelFireRateValue.Name = "labelFireRateValue";
            labelFireRateValue.Size = new Size(115, 20);
            labelFireRateValue.TabIndex = 25;
            // 
            // labelAverageCritical
            // 
            labelAverageCritical.AutoSize = true;
            labelAverageCritical.Location = new Point(4, 211);
            labelAverageCritical.Name = "labelAverageCritical";
            labelAverageCritical.Size = new Size(144, 15);
            labelAverageCritical.TabIndex = 8;
            labelAverageCritical.Text = "Average Critical Multiplier";
            // 
            // labelCriticalDamage
            // 
            labelCriticalDamage.AutoSize = true;
            labelCriticalDamage.Location = new Point(4, 190);
            labelCriticalDamage.Name = "labelCriticalDamage";
            labelCriticalDamage.Size = new Size(91, 15);
            labelCriticalDamage.TabIndex = 7;
            labelCriticalDamage.Text = "Critical Damage";
            // 
            // labelCriticalChance
            // 
            labelCriticalChance.AutoSize = true;
            labelCriticalChance.Location = new Point(4, 169);
            labelCriticalChance.Name = "labelCriticalChance";
            labelCriticalChance.Size = new Size(87, 15);
            labelCriticalChance.TabIndex = 6;
            labelCriticalChance.Text = "Critical Chance";
            // 
            // labelReload
            // 
            labelReload.AutoSize = true;
            labelReload.Location = new Point(4, 106);
            labelReload.Name = "labelReload";
            labelReload.Size = new Size(72, 15);
            labelReload.TabIndex = 5;
            labelReload.Text = "Reload Time";
            // 
            // labelMagazine
            // 
            labelMagazine.AutoSize = true;
            labelMagazine.Location = new Point(4, 43);
            labelMagazine.Name = "labelMagazine";
            labelMagazine.Size = new Size(58, 15);
            labelMagazine.TabIndex = 4;
            labelMagazine.Text = "Magazine";
            // 
            // labelMultishot
            // 
            labelMultishot.AutoSize = true;
            labelMultishot.Location = new Point(4, 22);
            labelMultishot.Name = "labelMultishot";
            labelMultishot.Size = new Size(58, 15);
            labelMultishot.TabIndex = 3;
            labelMultishot.Text = "Multishot";
            // 
            // labelFireRate
            // 
            labelFireRate.AutoSize = true;
            labelFireRate.Location = new Point(4, 1);
            labelFireRate.Name = "labelFireRate";
            labelFireRate.Size = new Size(52, 15);
            labelFireRate.TabIndex = 1;
            labelFireRate.Text = "Fire Rate";
            // 
            // labelDPSSustained
            // 
            labelDPSSustained.AutoSize = true;
            labelDPSSustained.Location = new Point(4, 274);
            labelDPSSustained.Name = "labelDPSSustained";
            labelDPSSustained.Size = new Size(90, 15);
            labelDPSSustained.TabIndex = 11;
            labelDPSSustained.Text = "DPS (Sustained)";
            // 
            // labelDPSBurst
            // 
            labelDPSBurst.AutoSize = true;
            labelDPSBurst.Location = new Point(4, 253);
            labelDPSBurst.Name = "labelDPSBurst";
            labelDPSBurst.Size = new Size(66, 15);
            labelDPSBurst.TabIndex = 10;
            labelDPSBurst.Text = "DPS (Burst)";
            // 
            // labelAmmoEfficiency
            // 
            labelAmmoEfficiency.AutoSize = true;
            labelAmmoEfficiency.Location = new Point(4, 64);
            labelAmmoEfficiency.Name = "labelAmmoEfficiency";
            labelAmmoEfficiency.Size = new Size(98, 15);
            labelAmmoEfficiency.TabIndex = 13;
            labelAmmoEfficiency.Text = "Ammo Efficiency";
            // 
            // labelAmmoEfficiencyValue
            // 
            labelAmmoEfficiencyValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAmmoEfficiencyValue.CausesValidation = false;
            labelAmmoEfficiencyValue.Location = new Point(173, 64);
            labelAmmoEfficiencyValue.Name = "labelAmmoEfficiencyValue";
            labelAmmoEfficiencyValue.Size = new Size(115, 20);
            labelAmmoEfficiencyValue.TabIndex = 36;
            // 
            // labelStatusProjectile
            // 
            labelStatusProjectile.AutoSize = true;
            labelStatusProjectile.Location = new Point(4, 127);
            labelStatusProjectile.Name = "labelStatusProjectile";
            labelStatusProjectile.Size = new Size(111, 15);
            labelStatusProjectile.TabIndex = 12;
            labelStatusProjectile.Text = "Status Per Projectile";
            labelStatusProjectile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelStatus
            // 
            labelStatus.Location = new Point(4, 148);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(128, 20);
            labelStatus.TabIndex = 9;
            labelStatus.Text = "Status Per Second";
            // 
            // labelStatusProjectileValue
            // 
            labelStatusProjectileValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelStatusProjectileValue.CausesValidation = false;
            labelStatusProjectileValue.Location = new Point(173, 127);
            labelStatusProjectileValue.Name = "labelStatusProjectileValue";
            labelStatusProjectileValue.Size = new Size(115, 20);
            labelStatusProjectileValue.TabIndex = 32;
            // 
            // labelStatusPerSecondValue
            // 
            labelStatusPerSecondValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelStatusPerSecondValue.CausesValidation = false;
            labelStatusPerSecondValue.Location = new Point(173, 148);
            labelStatusPerSecondValue.Name = "labelStatusPerSecondValue";
            labelStatusPerSecondValue.Size = new Size(115, 20);
            labelStatusPerSecondValue.TabIndex = 33;
            // 
            // labelDamage
            // 
            labelDamage.AutoSize = true;
            labelDamage.Location = new Point(4, 232);
            labelDamage.Name = "labelDamage";
            labelDamage.Size = new Size(138, 15);
            labelDamage.TabIndex = 24;
            labelDamage.Text = "Average Damage Per Tap";
            // 
            // labelDamageValue
            // 
            labelDamageValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDamageValue.CausesValidation = false;
            labelDamageValue.Location = new Point(173, 232);
            labelDamageValue.Name = "labelDamageValue";
            labelDamageValue.Size = new Size(115, 20);
            labelDamageValue.TabIndex = 48;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(4, 442);
            label19.Name = "label19";
            label19.Size = new Size(128, 15);
            label19.TabIndex = 20;
            label19.Text = "DPS (Radial, Sustained)";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(4, 421);
            label18.Name = "label18";
            label18.Size = new Size(104, 15);
            label18.TabIndex = 19;
            label18.Text = "DPS (Radial, Burst)";
            // 
            // labelRadialDPSSustainedValue
            // 
            labelRadialDPSSustainedValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialDPSSustainedValue.CausesValidation = false;
            labelRadialDPSSustainedValue.Location = new Point(173, 442);
            labelRadialDPSSustainedValue.Name = "labelRadialDPSSustainedValue";
            labelRadialDPSSustainedValue.Size = new Size(115, 20);
            labelRadialDPSSustainedValue.TabIndex = 43;
            // 
            // labelRadialDPSBurstValue
            // 
            labelRadialDPSBurstValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialDPSBurstValue.CausesValidation = false;
            labelRadialDPSBurstValue.Location = new Point(173, 421);
            labelRadialDPSBurstValue.Name = "labelRadialDPSBurstValue";
            labelRadialDPSBurstValue.Size = new Size(115, 20);
            labelRadialDPSBurstValue.TabIndex = 42;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(4, 295);
            label16.Name = "label16";
            label16.Size = new Size(82, 15);
            label16.TabIndex = 17;
            label16.Text = "Status (Radial)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(4, 316);
            label17.Name = "label17";
            label17.Size = new Size(144, 15);
            label17.TabIndex = 18;
            label17.Text = "Status Per Second (Radial)";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(4, 400);
            label.Name = "label";
            label.Size = new Size(140, 15);
            label.TabIndex = 49;
            label.Text = "Average Damage (Radial)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(4, 337);
            label13.Name = "label13";
            label13.Size = new Size(130, 15);
            label13.TabIndex = 14;
            label13.Text = "Critical Chance (Radial)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(4, 358);
            label14.Name = "label14";
            label14.Size = new Size(134, 15);
            label14.TabIndex = 15;
            label14.Text = "Critical Damage (Radial)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(4, 379);
            label15.Name = "label15";
            label15.Size = new Size(143, 15);
            label15.TabIndex = 16;
            label15.Text = "Average Crit Mult (Radial)";
            // 
            // labelRadialCriticalChanceValue
            // 
            labelRadialCriticalChanceValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialCriticalChanceValue.CausesValidation = false;
            labelRadialCriticalChanceValue.Location = new Point(173, 337);
            labelRadialCriticalChanceValue.Name = "labelRadialCriticalChanceValue";
            labelRadialCriticalChanceValue.Size = new Size(115, 20);
            labelRadialCriticalChanceValue.TabIndex = 37;
            // 
            // labelRadialStatusValue
            // 
            labelRadialStatusValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialStatusValue.CausesValidation = false;
            labelRadialStatusValue.Location = new Point(173, 295);
            labelRadialStatusValue.Name = "labelRadialStatusValue";
            labelRadialStatusValue.Size = new Size(115, 20);
            labelRadialStatusValue.TabIndex = 40;
            // 
            // labelRadialStatusMultishotValue
            // 
            labelRadialStatusMultishotValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialStatusMultishotValue.CausesValidation = false;
            labelRadialStatusMultishotValue.Location = new Point(173, 316);
            labelRadialStatusMultishotValue.Name = "labelRadialStatusMultishotValue";
            labelRadialStatusMultishotValue.Size = new Size(115, 20);
            labelRadialStatusMultishotValue.TabIndex = 41;
            // 
            // labelRadialDamageValue
            // 
            labelRadialDamageValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialDamageValue.CausesValidation = false;
            labelRadialDamageValue.Location = new Point(173, 400);
            labelRadialDamageValue.Name = "labelRadialDamageValue";
            labelRadialDamageValue.Size = new Size(115, 20);
            labelRadialDamageValue.TabIndex = 50;
            // 
            // labelRadialCriticalMultiplierValue
            // 
            labelRadialCriticalMultiplierValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialCriticalMultiplierValue.CausesValidation = false;
            labelRadialCriticalMultiplierValue.Location = new Point(173, 358);
            labelRadialCriticalMultiplierValue.Name = "labelRadialCriticalMultiplierValue";
            labelRadialCriticalMultiplierValue.Size = new Size(115, 20);
            labelRadialCriticalMultiplierValue.TabIndex = 38;
            // 
            // labelRadialAverageCritMultValue
            // 
            labelRadialAverageCritMultValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialAverageCritMultValue.CausesValidation = false;
            labelRadialAverageCritMultValue.Location = new Point(173, 379);
            labelRadialAverageCritMultValue.Name = "labelRadialAverageCritMultValue";
            labelRadialAverageCritMultValue.Size = new Size(115, 20);
            labelRadialAverageCritMultValue.TabIndex = 39;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(4, 505);
            label21.Name = "label21";
            label21.Size = new Size(144, 15);
            label21.TabIndex = 22;
            label21.Text = "DPS (Summed, Sustained)";
            // 
            // labelSummedDPSSustainedValue
            // 
            labelSummedDPSSustainedValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSummedDPSSustainedValue.CausesValidation = false;
            labelSummedDPSSustainedValue.Location = new Point(173, 505);
            labelSummedDPSSustainedValue.Name = "labelSummedDPSSustainedValue";
            labelSummedDPSSustainedValue.Size = new Size(115, 20);
            labelSummedDPSSustainedValue.TabIndex = 45;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(4, 484);
            label20.Name = "label20";
            label20.Size = new Size(120, 15);
            label20.TabIndex = 21;
            label20.Text = "DPS (Summed, Burst)";
            // 
            // labelSummedDPSBurstValue
            // 
            labelSummedDPSBurstValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSummedDPSBurstValue.CausesValidation = false;
            labelSummedDPSBurstValue.Location = new Point(173, 484);
            labelSummedDPSBurstValue.Name = "labelSummedDPSBurstValue";
            labelSummedDPSBurstValue.Size = new Size(115, 20);
            labelSummedDPSBurstValue.TabIndex = 44;
            // 
            // labelWeaponName
            // 
            labelWeaponName.AutoSize = true;
            labelWeaponName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWeaponName.Location = new Point(6, 23);
            labelWeaponName.Name = "labelWeaponName";
            labelWeaponName.Size = new Size(157, 25);
            labelWeaponName.TabIndex = 0;
            labelWeaponName.Text = "[Weapon Name]";
            // 
            // comboBoxFireMode
            // 
            comboBoxFireMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFireMode.FormattingEnabled = true;
            comboBoxFireMode.Location = new Point(12, 51);
            comboBoxFireMode.Name = "comboBoxFireMode";
            comboBoxFireMode.Size = new Size(292, 23);
            comboBoxFireMode.TabIndex = 2;
            comboBoxFireMode.DropDown += comboBoxFireModeTooltipShow_Event;
            comboBoxFireMode.SelectedIndexChanged += comboBoxFireMode_SelectedIndexChanged;
            comboBoxFireMode.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(comboBoxArchgunArcane, 0, 0);
            tableLayoutPanel2.Controls.Add(comboBoxMiscEffect12, 1, 14);
            tableLayoutPanel2.Controls.Add(comboBoxMiscEffect11, 0, 14);
            tableLayoutPanel2.Controls.Add(comboBoxMiscEffect10, 1, 13);
            tableLayoutPanel2.Controls.Add(comboBoxMiscEffect9, 0, 13);
            tableLayoutPanel2.Controls.Add(comboBoxMiscEffect8, 1, 12);
            tableLayoutPanel2.Controls.Add(comboBoxMiscEffect7, 0, 12);
            tableLayoutPanel2.Controls.Add(comboBoxMiscEffect6, 1, 11);
            tableLayoutPanel2.Controls.Add(comboBoxMiscEffect5, 0, 11);
            tableLayoutPanel2.Controls.Add(comboBoxMiscEffect4, 1, 10);
            tableLayoutPanel2.Controls.Add(comboBoxMiscEffect3, 0, 10);
            tableLayoutPanel2.Controls.Add(comboBoxMiscEffect2, 1, 9);
            tableLayoutPanel2.Controls.Add(comboBoxMiscEffect1, 0, 9);
            tableLayoutPanel2.Controls.Add(label3, 0, 8);
            tableLayoutPanel2.Controls.Add(comboBoxMod8, 1, 7);
            tableLayoutPanel2.Controls.Add(comboBoxMod7, 0, 7);
            tableLayoutPanel2.Controls.Add(comboBoxMod6, 1, 6);
            tableLayoutPanel2.Controls.Add(comboBoxMod5, 0, 6);
            tableLayoutPanel2.Controls.Add(comboBoxMod4, 1, 5);
            tableLayoutPanel2.Controls.Add(comboBoxMod3, 0, 5);
            tableLayoutPanel2.Controls.Add(comboBoxMod2, 1, 4);
            tableLayoutPanel2.Controls.Add(label2, 0, 3);
            tableLayoutPanel2.Controls.Add(comboBoxWeaponArcane, 0, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(comboBoxMod1, 0, 4);
            tableLayoutPanel2.Location = new Point(333, 81);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 15;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(455, 398);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // comboBoxArchgunArcane
            // 
            comboBoxArchgunArcane.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.SetColumnSpan(comboBoxArchgunArcane, 2);
            comboBoxArchgunArcane.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxArchgunArcane.FormattingEnabled = true;
            comboBoxArchgunArcane.Location = new Point(3, 3);
            comboBoxArchgunArcane.Name = "comboBoxArchgunArcane";
            comboBoxArchgunArcane.Size = new Size(449, 23);
            comboBoxArchgunArcane.TabIndex = 24;
            comboBoxArchgunArcane.Visible = false;
            comboBoxArchgunArcane.DropDown += comboBoxTooltipShow_Event;
            comboBoxArchgunArcane.SelectedIndexChanged += comboBoxWeaponArcane_SelectedIndexChanged;
            comboBoxArchgunArcane.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMiscEffect12
            // 
            comboBoxMiscEffect12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMiscEffect12.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiscEffect12.FormattingEnabled = true;
            comboBoxMiscEffect12.Location = new Point(228, 371);
            comboBoxMiscEffect12.Margin = new Padding(1);
            comboBoxMiscEffect12.Name = "comboBoxMiscEffect12";
            comboBoxMiscEffect12.Size = new Size(226, 23);
            comboBoxMiscEffect12.TabIndex = 23;
            comboBoxMiscEffect12.DropDown += comboBoxTooltipShow_Event;
            comboBoxMiscEffect12.SelectedIndexChanged += comboBoxMisc_SelectedIndexChanged;
            comboBoxMiscEffect12.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMiscEffect11
            // 
            comboBoxMiscEffect11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMiscEffect11.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiscEffect11.FormattingEnabled = true;
            comboBoxMiscEffect11.Location = new Point(1, 371);
            comboBoxMiscEffect11.Margin = new Padding(1);
            comboBoxMiscEffect11.Name = "comboBoxMiscEffect11";
            comboBoxMiscEffect11.Size = new Size(225, 23);
            comboBoxMiscEffect11.TabIndex = 22;
            comboBoxMiscEffect11.DropDown += comboBoxTooltipShow_Event;
            comboBoxMiscEffect11.SelectedIndexChanged += comboBoxMisc_SelectedIndexChanged;
            comboBoxMiscEffect11.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMiscEffect10
            // 
            comboBoxMiscEffect10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMiscEffect10.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiscEffect10.FormattingEnabled = true;
            comboBoxMiscEffect10.Location = new Point(228, 346);
            comboBoxMiscEffect10.Margin = new Padding(1);
            comboBoxMiscEffect10.Name = "comboBoxMiscEffect10";
            comboBoxMiscEffect10.Size = new Size(226, 23);
            comboBoxMiscEffect10.TabIndex = 21;
            comboBoxMiscEffect10.DropDown += comboBoxTooltipShow_Event;
            comboBoxMiscEffect10.SelectedIndexChanged += comboBoxMisc_SelectedIndexChanged;
            comboBoxMiscEffect10.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMiscEffect9
            // 
            comboBoxMiscEffect9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMiscEffect9.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiscEffect9.FormattingEnabled = true;
            comboBoxMiscEffect9.Location = new Point(1, 346);
            comboBoxMiscEffect9.Margin = new Padding(1);
            comboBoxMiscEffect9.Name = "comboBoxMiscEffect9";
            comboBoxMiscEffect9.Size = new Size(225, 23);
            comboBoxMiscEffect9.TabIndex = 20;
            comboBoxMiscEffect9.DropDown += comboBoxTooltipShow_Event;
            comboBoxMiscEffect9.SelectedIndexChanged += comboBoxMisc_SelectedIndexChanged;
            comboBoxMiscEffect9.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMiscEffect8
            // 
            comboBoxMiscEffect8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMiscEffect8.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiscEffect8.FormattingEnabled = true;
            comboBoxMiscEffect8.Location = new Point(228, 321);
            comboBoxMiscEffect8.Margin = new Padding(1);
            comboBoxMiscEffect8.Name = "comboBoxMiscEffect8";
            comboBoxMiscEffect8.Size = new Size(226, 23);
            comboBoxMiscEffect8.TabIndex = 19;
            comboBoxMiscEffect8.DropDown += comboBoxTooltipShow_Event;
            comboBoxMiscEffect8.SelectedIndexChanged += comboBoxMisc_SelectedIndexChanged;
            comboBoxMiscEffect8.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMiscEffect7
            // 
            comboBoxMiscEffect7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMiscEffect7.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiscEffect7.FormattingEnabled = true;
            comboBoxMiscEffect7.Location = new Point(1, 321);
            comboBoxMiscEffect7.Margin = new Padding(1);
            comboBoxMiscEffect7.Name = "comboBoxMiscEffect7";
            comboBoxMiscEffect7.Size = new Size(225, 23);
            comboBoxMiscEffect7.TabIndex = 18;
            comboBoxMiscEffect7.DropDown += comboBoxTooltipShow_Event;
            comboBoxMiscEffect7.SelectedIndexChanged += comboBoxMisc_SelectedIndexChanged;
            comboBoxMiscEffect7.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMiscEffect6
            // 
            comboBoxMiscEffect6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMiscEffect6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiscEffect6.FormattingEnabled = true;
            comboBoxMiscEffect6.Location = new Point(228, 296);
            comboBoxMiscEffect6.Margin = new Padding(1);
            comboBoxMiscEffect6.Name = "comboBoxMiscEffect6";
            comboBoxMiscEffect6.Size = new Size(226, 23);
            comboBoxMiscEffect6.TabIndex = 17;
            comboBoxMiscEffect6.DropDown += comboBoxTooltipShow_Event;
            comboBoxMiscEffect6.SelectedIndexChanged += comboBoxMisc_SelectedIndexChanged;
            comboBoxMiscEffect6.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMiscEffect5
            // 
            comboBoxMiscEffect5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMiscEffect5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiscEffect5.FormattingEnabled = true;
            comboBoxMiscEffect5.Location = new Point(1, 296);
            comboBoxMiscEffect5.Margin = new Padding(1);
            comboBoxMiscEffect5.Name = "comboBoxMiscEffect5";
            comboBoxMiscEffect5.Size = new Size(225, 23);
            comboBoxMiscEffect5.TabIndex = 16;
            comboBoxMiscEffect5.DropDown += comboBoxTooltipShow_Event;
            comboBoxMiscEffect5.SelectedIndexChanged += comboBoxMisc_SelectedIndexChanged;
            comboBoxMiscEffect5.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMiscEffect4
            // 
            comboBoxMiscEffect4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMiscEffect4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiscEffect4.FormattingEnabled = true;
            comboBoxMiscEffect4.Location = new Point(228, 271);
            comboBoxMiscEffect4.Margin = new Padding(1);
            comboBoxMiscEffect4.Name = "comboBoxMiscEffect4";
            comboBoxMiscEffect4.Size = new Size(226, 23);
            comboBoxMiscEffect4.TabIndex = 15;
            comboBoxMiscEffect4.DropDown += comboBoxTooltipShow_Event;
            comboBoxMiscEffect4.SelectedIndexChanged += comboBoxMisc_SelectedIndexChanged;
            comboBoxMiscEffect4.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMiscEffect3
            // 
            comboBoxMiscEffect3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMiscEffect3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiscEffect3.FormattingEnabled = true;
            comboBoxMiscEffect3.Location = new Point(1, 271);
            comboBoxMiscEffect3.Margin = new Padding(1);
            comboBoxMiscEffect3.Name = "comboBoxMiscEffect3";
            comboBoxMiscEffect3.Size = new Size(225, 23);
            comboBoxMiscEffect3.TabIndex = 14;
            comboBoxMiscEffect3.DropDown += comboBoxTooltipShow_Event;
            comboBoxMiscEffect3.SelectedIndexChanged += comboBoxMisc_SelectedIndexChanged;
            comboBoxMiscEffect3.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMiscEffect2
            // 
            comboBoxMiscEffect2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMiscEffect2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiscEffect2.FormattingEnabled = true;
            comboBoxMiscEffect2.Location = new Point(228, 246);
            comboBoxMiscEffect2.Margin = new Padding(1);
            comboBoxMiscEffect2.Name = "comboBoxMiscEffect2";
            comboBoxMiscEffect2.Size = new Size(226, 23);
            comboBoxMiscEffect2.TabIndex = 13;
            comboBoxMiscEffect2.DropDown += comboBoxTooltipShow_Event;
            comboBoxMiscEffect2.SelectedIndexChanged += comboBoxMisc_SelectedIndexChanged;
            comboBoxMiscEffect2.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMiscEffect1
            // 
            comboBoxMiscEffect1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMiscEffect1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiscEffect1.FormattingEnabled = true;
            comboBoxMiscEffect1.Location = new Point(1, 246);
            comboBoxMiscEffect1.Margin = new Padding(1);
            comboBoxMiscEffect1.Name = "comboBoxMiscEffect1";
            comboBoxMiscEffect1.Size = new Size(225, 23);
            comboBoxMiscEffect1.TabIndex = 12;
            comboBoxMiscEffect1.DropDown += comboBoxTooltipShow_Event;
            comboBoxMiscEffect1.SelectedIndexChanged += comboBoxMisc_SelectedIndexChanged;
            comboBoxMiscEffect1.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label3, 2);
            label3.Location = new Point(3, 216);
            label3.Name = "label3";
            label3.Size = new Size(449, 29);
            label3.TabIndex = 11;
            label3.Text = "Warframe Arcane/Buffs/Misc Effects";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxMod8
            // 
            comboBoxMod8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMod8.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMod8.FormattingEnabled = true;
            comboBoxMod8.Location = new Point(228, 192);
            comboBoxMod8.Margin = new Padding(1);
            comboBoxMod8.Name = "comboBoxMod8";
            comboBoxMod8.Size = new Size(226, 23);
            comboBoxMod8.TabIndex = 10;
            comboBoxMod8.DropDown += comboBoxTooltipShow_Event;
            comboBoxMod8.SelectedIndexChanged += comboBoxMod_SelectedIndexChanged;
            comboBoxMod8.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMod7
            // 
            comboBoxMod7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMod7.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMod7.FormattingEnabled = true;
            comboBoxMod7.Location = new Point(1, 192);
            comboBoxMod7.Margin = new Padding(1);
            comboBoxMod7.Name = "comboBoxMod7";
            comboBoxMod7.Size = new Size(225, 23);
            comboBoxMod7.TabIndex = 9;
            comboBoxMod7.DropDown += comboBoxTooltipShow_Event;
            comboBoxMod7.SelectedIndexChanged += comboBoxMod_SelectedIndexChanged;
            comboBoxMod7.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMod6
            // 
            comboBoxMod6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMod6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMod6.FormattingEnabled = true;
            comboBoxMod6.Location = new Point(228, 167);
            comboBoxMod6.Margin = new Padding(1);
            comboBoxMod6.Name = "comboBoxMod6";
            comboBoxMod6.Size = new Size(226, 23);
            comboBoxMod6.TabIndex = 8;
            comboBoxMod6.DropDown += comboBoxTooltipShow_Event;
            comboBoxMod6.SelectedIndexChanged += comboBoxMod_SelectedIndexChanged;
            comboBoxMod6.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMod5
            // 
            comboBoxMod5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMod5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMod5.FormattingEnabled = true;
            comboBoxMod5.Location = new Point(1, 167);
            comboBoxMod5.Margin = new Padding(1);
            comboBoxMod5.Name = "comboBoxMod5";
            comboBoxMod5.Size = new Size(225, 23);
            comboBoxMod5.TabIndex = 7;
            comboBoxMod5.DropDown += comboBoxTooltipShow_Event;
            comboBoxMod5.SelectedIndexChanged += comboBoxMod_SelectedIndexChanged;
            comboBoxMod5.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMod4
            // 
            comboBoxMod4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMod4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMod4.FormattingEnabled = true;
            comboBoxMod4.Location = new Point(228, 142);
            comboBoxMod4.Margin = new Padding(1);
            comboBoxMod4.Name = "comboBoxMod4";
            comboBoxMod4.Size = new Size(226, 23);
            comboBoxMod4.TabIndex = 6;
            comboBoxMod4.DropDown += comboBoxTooltipShow_Event;
            comboBoxMod4.SelectedIndexChanged += comboBoxMod_SelectedIndexChanged;
            comboBoxMod4.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMod3
            // 
            comboBoxMod3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMod3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMod3.FormattingEnabled = true;
            comboBoxMod3.Location = new Point(1, 142);
            comboBoxMod3.Margin = new Padding(1);
            comboBoxMod3.Name = "comboBoxMod3";
            comboBoxMod3.Size = new Size(225, 23);
            comboBoxMod3.TabIndex = 5;
            comboBoxMod3.DropDown += comboBoxTooltipShow_Event;
            comboBoxMod3.SelectedIndexChanged += comboBoxMod_SelectedIndexChanged;
            comboBoxMod3.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // comboBoxMod2
            // 
            comboBoxMod2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMod2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMod2.FormattingEnabled = true;
            comboBoxMod2.Location = new Point(228, 117);
            comboBoxMod2.Margin = new Padding(1);
            comboBoxMod2.Name = "comboBoxMod2";
            comboBoxMod2.Size = new Size(226, 23);
            comboBoxMod2.TabIndex = 4;
            comboBoxMod2.DropDown += comboBoxTooltipShow_Event;
            comboBoxMod2.SelectedIndexChanged += comboBoxMod_SelectedIndexChanged;
            comboBoxMod2.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label2, 2);
            label2.Location = new Point(3, 87);
            label2.Name = "label2";
            label2.Size = new Size(449, 29);
            label2.TabIndex = 2;
            label2.Text = "Weapon Mods";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxWeaponArcane
            // 
            comboBoxWeaponArcane.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.SetColumnSpan(comboBoxWeaponArcane, 2);
            comboBoxWeaponArcane.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWeaponArcane.FormattingEnabled = true;
            comboBoxWeaponArcane.Location = new Point(3, 61);
            comboBoxWeaponArcane.Name = "comboBoxWeaponArcane";
            comboBoxWeaponArcane.Size = new Size(449, 23);
            comboBoxWeaponArcane.TabIndex = 1;
            comboBoxWeaponArcane.DropDown += comboBoxTooltipShow_Event;
            comboBoxWeaponArcane.SelectedIndexChanged += comboBoxWeaponArcane_SelectedIndexChanged;
            comboBoxWeaponArcane.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label1, 2);
            label1.Location = new Point(3, 29);
            label1.Name = "label1";
            label1.Size = new Size(449, 29);
            label1.TabIndex = 0;
            label1.Text = "Weapon Arcane";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxMod1
            // 
            comboBoxMod1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxMod1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMod1.FormattingEnabled = true;
            comboBoxMod1.Location = new Point(1, 117);
            comboBoxMod1.Margin = new Padding(1);
            comboBoxMod1.Name = "comboBoxMod1";
            comboBoxMod1.Size = new Size(225, 23);
            comboBoxMod1.TabIndex = 3;
            comboBoxMod1.DropDown += comboBoxTooltipShow_Event;
            comboBoxMod1.SelectedIndexChanged += comboBoxMod_SelectedIndexChanged;
            comboBoxMod1.DropDownClosed += comboBoxTooltipHide_Event;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "cfg";
            saveFileDialog1.Filter = "cfg|*.cfg";
            saveFileDialog1.Title = "Buildframe - Save Build To File";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "cfg|*.cfg";
            openFileDialog1.Title = "Buildframe - Load Build From File";
            // 
            // toolTipMods
            // 
            toolTipMods.UseAnimation = false;
            toolTipMods.UseFading = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1045, 746);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(comboBoxFireMode);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip1);
            Controls.Add(labelWeaponName);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "Buildframe";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelWeaponName;
        private Label labelFireRate;
        private Label labelDamage;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label labelAmmoEfficiency;
        private Label labelStatusProjectile;
        private Label labelDPSBurst;
        private Label labelStatus;
        private Label labelAverageCritical;
        private Label labelCriticalDamage;
        private Label labelCriticalChance;
        private Label labelReload;
        private Label labelMagazine;
        private Label labelMultishot;
        private ComboBox comboBoxFireMode;
        private Label labelSummedDPSSustainedValue;
        private Label labelSummedDPSBurstValue;
        private Label labelRadialDPSSustainedValue;
        private Label labelRadialDPSBurstValue;
        private Label labelRadialStatusMultishotValue;
        private Label labelRadialStatusValue;
        private Label labelRadialAverageCritMultValue;
        private Label labelRadialCriticalMultiplierValue;
        private Label labelRadialCriticalChanceValue;
        private Label labelAmmoEfficiencyValue;
        private Label labelDPSBurstValue;
        private Label labelStatusPerSecondValue;
        private Label labelStatusProjectileValue;
        private Label labelAverageCriticalValue;
        private Label labelCriticalDamageValue;
        private Label labelCriticalChanceValue;
        private Label labelReloadValue;
        private Label labelMagazineValue;
        private Label labelMultishotValue;
        private Label labelFireRateValue;
        private Label labelDPSSustainedValue;
        private Label labelDPSSustained;
        private Label labelDamageValue;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private ComboBox comboBoxWeaponArcane;
        private Label label2;
        private ComboBox comboBoxMod8;
        private ComboBox comboBoxMod7;
        private ComboBox comboBoxMod6;
        private ComboBox comboBoxMod5;
        private ComboBox comboBoxMod4;
        private ComboBox comboBoxMod3;
        private ComboBox comboBoxMod2;
        private ComboBox comboBoxMod1;
        private Label label3;
        private ComboBox comboBoxMiscEffect1;
        private ComboBox comboBoxMiscEffect8;
        private ComboBox comboBoxMiscEffect7;
        private ComboBox comboBoxMiscEffect6;
        private ComboBox comboBoxMiscEffect5;
        private ComboBox comboBoxMiscEffect4;
        private ComboBox comboBoxMiscEffect3;
        private ComboBox comboBoxMiscEffect2;
        private Label labelRadialDamageValue;
        private Label label;
        private Label labelSummedDamageValue;
        private Label label5;
        private ComboBox comboBoxMiscEffect12;
        private ComboBox comboBoxMiscEffect11;
        private ComboBox comboBoxMiscEffect10;
        private ComboBox comboBoxMiscEffect9;
        private ToolStripDropDownButton toolStripDropDownButtonSaveLoad;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripDropDownButton toolStripDropDownButtonCreationWizards;
        private ToolStripMenuItem createFireModeOrBuffToolStripMenuItem;
        private ToolStripMenuItem createWeaponToolStripMenuItem;
        private ToolStripButton toolStripButtonSelectWeapon;
        private ToolStripButton toolStripButtonInfo;
        private ComboBox comboBoxArchgunArcane;
        private Label labelFireTimeValue;
        private Label labelFireTime;
        private ToolTip toolTipMods;
    }
}
