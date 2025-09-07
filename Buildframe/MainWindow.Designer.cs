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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            addWeaponToolStripMenuItem = new ToolStripMenuItem();
            loadWeaponToolStripMenuItem = new ToolStripMenuItem();
            toolstripButtonEffectWizard = new ToolStripButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            label35 = new Label();
            label34 = new Label();
            label33 = new Label();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            labelDPSBurstValue = new Label();
            labelStatusMultishotValue = new Label();
            labelStatusProjectileValue = new Label();
            labelAverageCriticalValue = new Label();
            labelCriticalDamageValue = new Label();
            labelCriticalChanceValue = new Label();
            labelReloadValue = new Label();
            labelMagazineValue = new Label();
            labelMultishotValue = new Label();
            labelFireRateValue = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            labelAverageCritical = new Label();
            labelCriticalDamage = new Label();
            labelCriticalChance = new Label();
            labelReload = new Label();
            labelMagazine = new Label();
            labelMultishot = new Label();
            labelFireRate = new Label();
            labelDPSBurst = new Label();
            labelStatus = new Label();
            labelStatusProjectile = new Label();
            labelAmmoEfficiency = new Label();
            labelAmmoEfficiencyValue = new Label();
            labelWeaponName = new Label();
            comboBox1 = new ComboBox();
            labelDPSSustained = new Label();
            labelDPSSustainedValue = new Label();
            toolStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolstripButtonEffectWizard });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1045, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.AutoToolTip = false;
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { addWeaponToolStripMenuItem, loadWeaponToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(64, 22);
            toolStripDropDownButton1.Text = "Weapon";
            toolStripDropDownButton1.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // addWeaponToolStripMenuItem
            // 
            addWeaponToolStripMenuItem.Name = "addWeaponToolStripMenuItem";
            addWeaponToolStripMenuItem.Size = new Size(147, 22);
            addWeaponToolStripMenuItem.Text = "Add Weapon";
            // 
            // loadWeaponToolStripMenuItem
            // 
            loadWeaponToolStripMenuItem.Name = "loadWeaponToolStripMenuItem";
            loadWeaponToolStripMenuItem.Size = new Size(147, 22);
            loadWeaponToolStripMenuItem.Text = "Load Weapon";
            loadWeaponToolStripMenuItem.Click += loadWeaponToolStripMenuItem_Click;
            // 
            // toolstripButtonEffectWizard
            // 
            toolstripButtonEffectWizard.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolstripButtonEffectWizard.Image = (Image)resources.GetObject("toolstripButtonEffectWizard.Image");
            toolstripButtonEffectWizard.ImageTransparentColor = Color.Magenta;
            toolstripButtonEffectWizard.Name = "toolstripButtonEffectWizard";
            toolstripButtonEffectWizard.Size = new Size(78, 22);
            toolstripButtonEffectWizard.Text = "Create Effect";
            toolstripButtonEffectWizard.Click += toolstripButtonEffectWizard_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49F));
            tableLayoutPanel1.Controls.Add(label35, 1, 22);
            tableLayoutPanel1.Controls.Add(label34, 1, 21);
            tableLayoutPanel1.Controls.Add(label33, 1, 20);
            tableLayoutPanel1.Controls.Add(label32, 1, 19);
            tableLayoutPanel1.Controls.Add(label31, 1, 18);
            tableLayoutPanel1.Controls.Add(label30, 1, 17);
            tableLayoutPanel1.Controls.Add(label29, 1, 16);
            tableLayoutPanel1.Controls.Add(label28, 1, 15);
            tableLayoutPanel1.Controls.Add(label27, 1, 14);
            tableLayoutPanel1.Controls.Add(label26, 1, 13);
            tableLayoutPanel1.Controls.Add(label25, 1, 12);
            tableLayoutPanel1.Controls.Add(labelDPSSustainedValue, 1, 11);
            tableLayoutPanel1.Controls.Add(labelDPSBurstValue, 1, 10);
            tableLayoutPanel1.Controls.Add(labelStatusMultishotValue, 1, 9);
            tableLayoutPanel1.Controls.Add(labelStatusProjectileValue, 1, 8);
            tableLayoutPanel1.Controls.Add(labelAverageCriticalValue, 1, 7);
            tableLayoutPanel1.Controls.Add(labelCriticalDamageValue, 1, 6);
            tableLayoutPanel1.Controls.Add(labelCriticalChanceValue, 1, 5);
            tableLayoutPanel1.Controls.Add(labelReloadValue, 1, 4);
            tableLayoutPanel1.Controls.Add(labelMagazineValue, 1, 2);
            tableLayoutPanel1.Controls.Add(labelMultishotValue, 1, 1);
            tableLayoutPanel1.Controls.Add(labelFireRateValue, 1, 0);
            tableLayoutPanel1.Controls.Add(label23, 0, 22);
            tableLayoutPanel1.Controls.Add(label22, 0, 21);
            tableLayoutPanel1.Controls.Add(label21, 0, 20);
            tableLayoutPanel1.Controls.Add(label20, 0, 19);
            tableLayoutPanel1.Controls.Add(label19, 0, 18);
            tableLayoutPanel1.Controls.Add(label18, 0, 17);
            tableLayoutPanel1.Controls.Add(label17, 0, 16);
            tableLayoutPanel1.Controls.Add(label16, 0, 15);
            tableLayoutPanel1.Controls.Add(label15, 0, 14);
            tableLayoutPanel1.Controls.Add(label14, 0, 13);
            tableLayoutPanel1.Controls.Add(label13, 0, 12);
            tableLayoutPanel1.Controls.Add(labelAverageCritical, 0, 7);
            tableLayoutPanel1.Controls.Add(labelCriticalDamage, 0, 6);
            tableLayoutPanel1.Controls.Add(labelCriticalChance, 0, 5);
            tableLayoutPanel1.Controls.Add(labelReload, 0, 4);
            tableLayoutPanel1.Controls.Add(labelMagazine, 0, 2);
            tableLayoutPanel1.Controls.Add(labelMultishot, 0, 1);
            tableLayoutPanel1.Controls.Add(labelFireRate, 0, 0);
            tableLayoutPanel1.Controls.Add(labelDPSSustained, 0, 11);
            tableLayoutPanel1.Controls.Add(labelDPSBurst, 0, 10);
            tableLayoutPanel1.Controls.Add(labelStatus, 0, 9);
            tableLayoutPanel1.Controls.Add(labelStatusProjectile, 0, 8);
            tableLayoutPanel1.Controls.Add(labelAmmoEfficiency, 0, 3);
            tableLayoutPanel1.Controls.Add(labelAmmoEfficiencyValue, 1, 3);
            tableLayoutPanel1.Location = new Point(12, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 23;
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
            tableLayoutPanel1.Size = new Size(290, 495);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(151, 463);
            label35.Name = "label35";
            label35.Size = new Size(0, 15);
            label35.TabIndex = 47;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(151, 442);
            label34.Name = "label34";
            label34.Size = new Size(0, 15);
            label34.TabIndex = 46;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(151, 421);
            label33.Name = "label33";
            label33.Size = new Size(0, 15);
            label33.TabIndex = 45;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(151, 400);
            label32.Name = "label32";
            label32.Size = new Size(0, 15);
            label32.TabIndex = 44;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(151, 379);
            label31.Name = "label31";
            label31.Size = new Size(0, 15);
            label31.TabIndex = 43;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(151, 358);
            label30.Name = "label30";
            label30.Size = new Size(0, 15);
            label30.TabIndex = 42;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(151, 337);
            label29.Name = "label29";
            label29.Size = new Size(0, 15);
            label29.TabIndex = 41;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(151, 316);
            label28.Name = "label28";
            label28.Size = new Size(0, 15);
            label28.TabIndex = 40;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(151, 295);
            label27.Name = "label27";
            label27.Size = new Size(0, 15);
            label27.TabIndex = 39;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(151, 274);
            label26.Name = "label26";
            label26.Size = new Size(0, 15);
            label26.TabIndex = 38;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(151, 253);
            label25.Name = "label25";
            label25.Size = new Size(0, 15);
            label25.TabIndex = 37;
            // 
            // labelDPSBurstValue
            // 
            labelDPSBurstValue.Anchor = AnchorStyles.Right;
            labelDPSBurstValue.AutoSize = true;
            labelDPSBurstValue.Location = new Point(286, 213);
            labelDPSBurstValue.Name = "labelDPSBurstValue";
            labelDPSBurstValue.Size = new Size(0, 15);
            labelDPSBurstValue.TabIndex = 34;
            // 
            // labelStatusMultishotValue
            // 
            labelStatusMultishotValue.Anchor = AnchorStyles.Right;
            labelStatusMultishotValue.AutoSize = true;
            labelStatusMultishotValue.Location = new Point(286, 192);
            labelStatusMultishotValue.Name = "labelStatusMultishotValue";
            labelStatusMultishotValue.Size = new Size(0, 15);
            labelStatusMultishotValue.TabIndex = 33;
            // 
            // labelStatusProjectileValue
            // 
            labelStatusProjectileValue.Anchor = AnchorStyles.Right;
            labelStatusProjectileValue.AutoSize = true;
            labelStatusProjectileValue.Location = new Point(286, 171);
            labelStatusProjectileValue.Name = "labelStatusProjectileValue";
            labelStatusProjectileValue.Size = new Size(0, 15);
            labelStatusProjectileValue.TabIndex = 32;
            // 
            // labelAverageCriticalValue
            // 
            labelAverageCriticalValue.Anchor = AnchorStyles.Right;
            labelAverageCriticalValue.AutoSize = true;
            labelAverageCriticalValue.Location = new Point(286, 150);
            labelAverageCriticalValue.Name = "labelAverageCriticalValue";
            labelAverageCriticalValue.Size = new Size(0, 15);
            labelAverageCriticalValue.TabIndex = 31;
            // 
            // labelCriticalDamageValue
            // 
            labelCriticalDamageValue.Anchor = AnchorStyles.Right;
            labelCriticalDamageValue.AutoSize = true;
            labelCriticalDamageValue.Location = new Point(286, 129);
            labelCriticalDamageValue.Name = "labelCriticalDamageValue";
            labelCriticalDamageValue.Size = new Size(0, 15);
            labelCriticalDamageValue.TabIndex = 30;
            // 
            // labelCriticalChanceValue
            // 
            labelCriticalChanceValue.Anchor = AnchorStyles.Right;
            labelCriticalChanceValue.AutoSize = true;
            labelCriticalChanceValue.Location = new Point(286, 108);
            labelCriticalChanceValue.Name = "labelCriticalChanceValue";
            labelCriticalChanceValue.Size = new Size(0, 15);
            labelCriticalChanceValue.TabIndex = 29;
            // 
            // labelReloadValue
            // 
            labelReloadValue.Anchor = AnchorStyles.Right;
            labelReloadValue.AutoSize = true;
            labelReloadValue.Location = new Point(286, 87);
            labelReloadValue.Name = "labelReloadValue";
            labelReloadValue.Size = new Size(0, 15);
            labelReloadValue.TabIndex = 28;
            // 
            // labelMagazineValue
            // 
            labelMagazineValue.Anchor = AnchorStyles.Right;
            labelMagazineValue.AutoSize = true;
            labelMagazineValue.Location = new Point(286, 45);
            labelMagazineValue.Name = "labelMagazineValue";
            labelMagazineValue.Size = new Size(0, 15);
            labelMagazineValue.TabIndex = 27;
            // 
            // labelMultishotValue
            // 
            labelMultishotValue.Anchor = AnchorStyles.Right;
            labelMultishotValue.AutoSize = true;
            labelMultishotValue.Location = new Point(286, 24);
            labelMultishotValue.Name = "labelMultishotValue";
            labelMultishotValue.Size = new Size(0, 15);
            labelMultishotValue.TabIndex = 26;
            // 
            // labelFireRateValue
            // 
            labelFireRateValue.Anchor = AnchorStyles.Right;
            labelFireRateValue.AutoSize = true;
            labelFireRateValue.Location = new Point(286, 3);
            labelFireRateValue.Name = "labelFireRateValue";
            labelFireRateValue.Size = new Size(0, 15);
            labelFireRateValue.TabIndex = 25;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(4, 463);
            label23.Name = "label23";
            label23.Size = new Size(52, 15);
            label23.TabIndex = 24;
            label23.Text = "Fire Rate";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(4, 442);
            label22.Name = "label22";
            label22.Size = new Size(52, 15);
            label22.TabIndex = 23;
            label22.Text = "Fire Rate";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(4, 421);
            label21.Name = "label21";
            label21.Size = new Size(52, 15);
            label21.TabIndex = 22;
            label21.Text = "Fire Rate";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(4, 400);
            label20.Name = "label20";
            label20.Size = new Size(52, 15);
            label20.TabIndex = 21;
            label20.Text = "Fire Rate";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(4, 379);
            label19.Name = "label19";
            label19.Size = new Size(52, 15);
            label19.TabIndex = 20;
            label19.Text = "Fire Rate";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(4, 358);
            label18.Name = "label18";
            label18.Size = new Size(52, 15);
            label18.TabIndex = 19;
            label18.Text = "Fire Rate";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(4, 337);
            label17.Name = "label17";
            label17.Size = new Size(52, 15);
            label17.TabIndex = 18;
            label17.Text = "Fire Rate";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(4, 316);
            label16.Name = "label16";
            label16.Size = new Size(52, 15);
            label16.TabIndex = 17;
            label16.Text = "Fire Rate";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(4, 295);
            label15.Name = "label15";
            label15.Size = new Size(52, 15);
            label15.TabIndex = 16;
            label15.Text = "Fire Rate";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(4, 274);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 15;
            label14.Text = "Fire Rate";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(4, 253);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 14;
            label13.Text = "Fire Rate";
            // 
            // labelAverageCritical
            // 
            labelAverageCritical.AutoSize = true;
            labelAverageCritical.Location = new Point(4, 148);
            labelAverageCritical.Name = "labelAverageCritical";
            labelAverageCritical.Size = new Size(93, 20);
            labelAverageCritical.TabIndex = 8;
            labelAverageCritical.Text = "Average Critical Multiplier";
            // 
            // labelCriticalDamage
            // 
            labelCriticalDamage.AutoSize = true;
            labelCriticalDamage.Location = new Point(4, 127);
            labelCriticalDamage.Name = "labelCriticalDamage";
            labelCriticalDamage.Size = new Size(91, 15);
            labelCriticalDamage.TabIndex = 7;
            labelCriticalDamage.Text = "Critical Damage";
            // 
            // labelCriticalChance
            // 
            labelCriticalChance.AutoSize = true;
            labelCriticalChance.Location = new Point(4, 106);
            labelCriticalChance.Name = "labelCriticalChance";
            labelCriticalChance.Size = new Size(87, 15);
            labelCriticalChance.TabIndex = 6;
            labelCriticalChance.Text = "Critical Chance";
            // 
            // labelReload
            // 
            labelReload.AutoSize = true;
            labelReload.Location = new Point(4, 85);
            labelReload.Name = "labelReload";
            labelReload.Size = new Size(43, 15);
            labelReload.TabIndex = 5;
            labelReload.Text = "Reload";
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
            labelFireRate.Click += labelFireRate_Click;
            // 
            // labelDPSBurst
            // 
            labelDPSBurst.AutoSize = true;
            labelDPSBurst.Location = new Point(4, 211);
            labelDPSBurst.Name = "labelDPSBurst";
            labelDPSBurst.Size = new Size(66, 15);
            labelDPSBurst.TabIndex = 10;
            labelDPSBurst.Text = "DPS (Burst)";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(4, 190);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(101, 15);
            labelStatus.TabIndex = 9;
            labelStatus.Text = "Status (Multishot)";
            // 
            // labelStatusProjectile
            // 
            labelStatusProjectile.AutoSize = true;
            labelStatusProjectile.Location = new Point(4, 169);
            labelStatusProjectile.Name = "labelStatusProjectile";
            labelStatusProjectile.Size = new Size(39, 15);
            labelStatusProjectile.TabIndex = 12;
            labelStatusProjectile.Text = "Status";
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
            labelAmmoEfficiencyValue.Anchor = AnchorStyles.Right;
            labelAmmoEfficiencyValue.AutoSize = true;
            labelAmmoEfficiencyValue.Location = new Point(286, 66);
            labelAmmoEfficiencyValue.Name = "labelAmmoEfficiencyValue";
            labelAmmoEfficiencyValue.Size = new Size(0, 15);
            labelAmmoEfficiencyValue.TabIndex = 36;
            // 
            // labelWeaponName
            // 
            labelWeaponName.AutoSize = true;
            labelWeaponName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWeaponName.Location = new Point(12, 23);
            labelWeaponName.Name = "labelWeaponName";
            labelWeaponName.Size = new Size(157, 25);
            labelWeaponName.TabIndex = 0;
            labelWeaponName.Text = "[Weapon Name]";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 2;
            // 
            // labelDPSSustained
            // 
            labelDPSSustained.AutoSize = true;
            labelDPSSustained.Location = new Point(4, 232);
            labelDPSSustained.Name = "labelDPSSustained";
            labelDPSSustained.Size = new Size(90, 15);
            labelDPSSustained.TabIndex = 11;
            labelDPSSustained.Text = "DPS (Sustained)";
            // 
            // labelDPSSustainedValue
            // 
            labelDPSSustainedValue.Anchor = AnchorStyles.Right;
            labelDPSSustainedValue.AutoSize = true;
            labelDPSSustainedValue.Location = new Point(286, 234);
            labelDPSSustainedValue.Name = "labelDPSSustainedValue";
            labelDPSSustainedValue.Size = new Size(0, 15);
            labelDPSSustainedValue.TabIndex = 35;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1045, 746);
            Controls.Add(comboBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip1);
            Controls.Add(labelWeaponName);
            Margin = new Padding(2);
            Name = "MainWindow";
            Text = "Buildframe";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem addWeaponToolStripMenuItem;
        private ToolStripMenuItem loadWeaponToolStripMenuItem;
        private ToolStripButton toolstripButtonEffectWizard;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelWeaponName;
        private Label labelFireRate;
        private Label label23;
        private Label label22;
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
        private ComboBox comboBox1;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label labelAmmoEfficiencyValue;
        private Label labelDPSBurstValue;
        private Label labelStatusMultishotValue;
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
    }
}
