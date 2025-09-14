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
            labelDamageValue = new Label();
            label35 = new Label();
            label34 = new Label();
            labelSummedDPSSustainedValue = new Label();
            labelSummedDPSBurstValue = new Label();
            labelRadialDPSSustainedValue = new Label();
            labelRadialDPSBurstValue = new Label();
            labelRadialStatusMultishotValue = new Label();
            labelRadialStatusValue = new Label();
            labelRadialAverageCritMultValue = new Label();
            labelRadialCriticalMultiplierValue = new Label();
            labelRadialCriticalChanceValue = new Label();
            labelDPSSustainedValue = new Label();
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
            labelDPSSustained = new Label();
            labelDPSBurst = new Label();
            labelStatus = new Label();
            labelStatusProjectile = new Label();
            labelAmmoEfficiency = new Label();
            labelAmmoEfficiencyValue = new Label();
            labelDamage = new Label();
            labelWeaponName = new Label();
            comboBox1 = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboBox10 = new ComboBox();
            comboBox9 = new ComboBox();
            comboBox8 = new ComboBox();
            comboBox7 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            comboBox3 = new ComboBox();
            toolStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.13149F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.86851F));
            tableLayoutPanel1.Controls.Add(labelDamageValue, 1, 12);
            tableLayoutPanel1.Controls.Add(label35, 1, 23);
            tableLayoutPanel1.Controls.Add(label34, 1, 22);
            tableLayoutPanel1.Controls.Add(labelSummedDPSSustainedValue, 1, 21);
            tableLayoutPanel1.Controls.Add(labelSummedDPSBurstValue, 1, 20);
            tableLayoutPanel1.Controls.Add(labelRadialDPSSustainedValue, 1, 19);
            tableLayoutPanel1.Controls.Add(labelRadialDPSBurstValue, 1, 18);
            tableLayoutPanel1.Controls.Add(labelRadialStatusMultishotValue, 1, 17);
            tableLayoutPanel1.Controls.Add(labelRadialStatusValue, 1, 16);
            tableLayoutPanel1.Controls.Add(labelRadialAverageCritMultValue, 1, 15);
            tableLayoutPanel1.Controls.Add(labelRadialCriticalMultiplierValue, 1, 14);
            tableLayoutPanel1.Controls.Add(labelRadialCriticalChanceValue, 1, 13);
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
            tableLayoutPanel1.Controls.Add(label22, 0, 22);
            tableLayoutPanel1.Controls.Add(label21, 0, 21);
            tableLayoutPanel1.Controls.Add(label20, 0, 20);
            tableLayoutPanel1.Controls.Add(label19, 0, 19);
            tableLayoutPanel1.Controls.Add(label18, 0, 18);
            tableLayoutPanel1.Controls.Add(label17, 0, 17);
            tableLayoutPanel1.Controls.Add(label16, 0, 16);
            tableLayoutPanel1.Controls.Add(label15, 0, 15);
            tableLayoutPanel1.Controls.Add(label14, 0, 14);
            tableLayoutPanel1.Controls.Add(label13, 0, 13);
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
            tableLayoutPanel1.Controls.Add(labelDamage, 0, 12);
            tableLayoutPanel1.Location = new Point(12, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 24;
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
            tableLayoutPanel1.Size = new Size(290, 528);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelDamageValue
            // 
            labelDamageValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDamageValue.AutoSize = true;
            labelDamageValue.Location = new Point(171, 253);
            labelDamageValue.Name = "labelDamageValue";
            labelDamageValue.Size = new Size(115, 20);
            labelDamageValue.TabIndex = 48;
            // 
            // label35
            // 
            label35.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label35.AutoSize = true;
            label35.Location = new Point(171, 484);
            label35.Name = "label35";
            label35.Size = new Size(115, 43);
            label35.TabIndex = 47;
            // 
            // label34
            // 
            label34.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label34.AutoSize = true;
            label34.Location = new Point(171, 463);
            label34.Name = "label34";
            label34.Size = new Size(115, 20);
            label34.TabIndex = 46;
            // 
            // labelSummedDPSSustainedValue
            // 
            labelSummedDPSSustainedValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSummedDPSSustainedValue.AutoSize = true;
            labelSummedDPSSustainedValue.Location = new Point(171, 442);
            labelSummedDPSSustainedValue.Name = "labelSummedDPSSustainedValue";
            labelSummedDPSSustainedValue.Size = new Size(115, 20);
            labelSummedDPSSustainedValue.TabIndex = 45;
            // 
            // labelSummedDPSBurstValue
            // 
            labelSummedDPSBurstValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSummedDPSBurstValue.AutoSize = true;
            labelSummedDPSBurstValue.Location = new Point(171, 421);
            labelSummedDPSBurstValue.Name = "labelSummedDPSBurstValue";
            labelSummedDPSBurstValue.Size = new Size(115, 20);
            labelSummedDPSBurstValue.TabIndex = 44;
            // 
            // labelRadialDPSSustainedValue
            // 
            labelRadialDPSSustainedValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialDPSSustainedValue.AutoSize = true;
            labelRadialDPSSustainedValue.Location = new Point(171, 400);
            labelRadialDPSSustainedValue.Name = "labelRadialDPSSustainedValue";
            labelRadialDPSSustainedValue.Size = new Size(115, 20);
            labelRadialDPSSustainedValue.TabIndex = 43;
            // 
            // labelRadialDPSBurstValue
            // 
            labelRadialDPSBurstValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialDPSBurstValue.AutoSize = true;
            labelRadialDPSBurstValue.Location = new Point(171, 379);
            labelRadialDPSBurstValue.Name = "labelRadialDPSBurstValue";
            labelRadialDPSBurstValue.Size = new Size(115, 20);
            labelRadialDPSBurstValue.TabIndex = 42;
            // 
            // labelRadialStatusMultishotValue
            // 
            labelRadialStatusMultishotValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialStatusMultishotValue.AutoSize = true;
            labelRadialStatusMultishotValue.Location = new Point(171, 358);
            labelRadialStatusMultishotValue.Name = "labelRadialStatusMultishotValue";
            labelRadialStatusMultishotValue.Size = new Size(115, 20);
            labelRadialStatusMultishotValue.TabIndex = 41;
            // 
            // labelRadialStatusValue
            // 
            labelRadialStatusValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialStatusValue.AutoSize = true;
            labelRadialStatusValue.Location = new Point(171, 337);
            labelRadialStatusValue.Name = "labelRadialStatusValue";
            labelRadialStatusValue.Size = new Size(115, 20);
            labelRadialStatusValue.TabIndex = 40;
            // 
            // labelRadialAverageCritMultValue
            // 
            labelRadialAverageCritMultValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialAverageCritMultValue.AutoSize = true;
            labelRadialAverageCritMultValue.Location = new Point(171, 316);
            labelRadialAverageCritMultValue.Name = "labelRadialAverageCritMultValue";
            labelRadialAverageCritMultValue.Size = new Size(115, 20);
            labelRadialAverageCritMultValue.TabIndex = 39;
            // 
            // labelRadialCriticalMultiplierValue
            // 
            labelRadialCriticalMultiplierValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialCriticalMultiplierValue.AutoSize = true;
            labelRadialCriticalMultiplierValue.Location = new Point(171, 295);
            labelRadialCriticalMultiplierValue.Name = "labelRadialCriticalMultiplierValue";
            labelRadialCriticalMultiplierValue.Size = new Size(115, 20);
            labelRadialCriticalMultiplierValue.TabIndex = 38;
            // 
            // labelRadialCriticalChanceValue
            // 
            labelRadialCriticalChanceValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRadialCriticalChanceValue.AutoSize = true;
            labelRadialCriticalChanceValue.Location = new Point(171, 274);
            labelRadialCriticalChanceValue.Name = "labelRadialCriticalChanceValue";
            labelRadialCriticalChanceValue.Size = new Size(115, 20);
            labelRadialCriticalChanceValue.TabIndex = 37;
            // 
            // labelDPSSustainedValue
            // 
            labelDPSSustainedValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDPSSustainedValue.AutoSize = true;
            labelDPSSustainedValue.Location = new Point(171, 232);
            labelDPSSustainedValue.Name = "labelDPSSustainedValue";
            labelDPSSustainedValue.Size = new Size(115, 20);
            labelDPSSustainedValue.TabIndex = 35;
            // 
            // labelDPSBurstValue
            // 
            labelDPSBurstValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDPSBurstValue.AutoSize = true;
            labelDPSBurstValue.Location = new Point(171, 211);
            labelDPSBurstValue.Name = "labelDPSBurstValue";
            labelDPSBurstValue.Size = new Size(115, 20);
            labelDPSBurstValue.TabIndex = 34;
            // 
            // labelStatusMultishotValue
            // 
            labelStatusMultishotValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelStatusMultishotValue.AutoSize = true;
            labelStatusMultishotValue.Location = new Point(171, 190);
            labelStatusMultishotValue.Name = "labelStatusMultishotValue";
            labelStatusMultishotValue.Size = new Size(115, 20);
            labelStatusMultishotValue.TabIndex = 33;
            // 
            // labelStatusProjectileValue
            // 
            labelStatusProjectileValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelStatusProjectileValue.AutoSize = true;
            labelStatusProjectileValue.Location = new Point(171, 169);
            labelStatusProjectileValue.Name = "labelStatusProjectileValue";
            labelStatusProjectileValue.Size = new Size(115, 20);
            labelStatusProjectileValue.TabIndex = 32;
            // 
            // labelAverageCriticalValue
            // 
            labelAverageCriticalValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAverageCriticalValue.AutoSize = true;
            labelAverageCriticalValue.Location = new Point(171, 148);
            labelAverageCriticalValue.Name = "labelAverageCriticalValue";
            labelAverageCriticalValue.Size = new Size(115, 20);
            labelAverageCriticalValue.TabIndex = 31;
            // 
            // labelCriticalDamageValue
            // 
            labelCriticalDamageValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCriticalDamageValue.AutoSize = true;
            labelCriticalDamageValue.Location = new Point(171, 127);
            labelCriticalDamageValue.Name = "labelCriticalDamageValue";
            labelCriticalDamageValue.Size = new Size(115, 20);
            labelCriticalDamageValue.TabIndex = 30;
            // 
            // labelCriticalChanceValue
            // 
            labelCriticalChanceValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCriticalChanceValue.AutoSize = true;
            labelCriticalChanceValue.Location = new Point(171, 106);
            labelCriticalChanceValue.Name = "labelCriticalChanceValue";
            labelCriticalChanceValue.Size = new Size(115, 20);
            labelCriticalChanceValue.TabIndex = 29;
            // 
            // labelReloadValue
            // 
            labelReloadValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelReloadValue.AutoSize = true;
            labelReloadValue.Location = new Point(171, 85);
            labelReloadValue.Name = "labelReloadValue";
            labelReloadValue.Size = new Size(115, 20);
            labelReloadValue.TabIndex = 28;
            // 
            // labelMagazineValue
            // 
            labelMagazineValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelMagazineValue.AutoSize = true;
            labelMagazineValue.Location = new Point(171, 43);
            labelMagazineValue.Name = "labelMagazineValue";
            labelMagazineValue.Size = new Size(115, 20);
            labelMagazineValue.TabIndex = 27;
            // 
            // labelMultishotValue
            // 
            labelMultishotValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelMultishotValue.AutoSize = true;
            labelMultishotValue.Location = new Point(171, 22);
            labelMultishotValue.Name = "labelMultishotValue";
            labelMultishotValue.Size = new Size(115, 20);
            labelMultishotValue.TabIndex = 26;
            // 
            // labelFireRateValue
            // 
            labelFireRateValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelFireRateValue.AutoSize = true;
            labelFireRateValue.Location = new Point(171, 1);
            labelFireRateValue.Name = "labelFireRateValue";
            labelFireRateValue.Size = new Size(115, 20);
            labelFireRateValue.TabIndex = 25;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(4, 463);
            label22.Name = "label22";
            label22.Size = new Size(52, 15);
            label22.TabIndex = 23;
            label22.Text = "Fire Rate";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(4, 442);
            label21.Name = "label21";
            label21.Size = new Size(144, 15);
            label21.TabIndex = 22;
            label21.Text = "DPS (Summed, Sustained)";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(4, 421);
            label20.Name = "label20";
            label20.Size = new Size(120, 15);
            label20.TabIndex = 21;
            label20.Text = "DPS (Summed, Burst)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(4, 400);
            label19.Name = "label19";
            label19.Size = new Size(128, 15);
            label19.TabIndex = 20;
            label19.Text = "DPS (Radial, Sustained)";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(4, 379);
            label18.Name = "label18";
            label18.Size = new Size(104, 15);
            label18.TabIndex = 19;
            label18.Text = "DPS (Radial, Burst)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(4, 358);
            label17.Name = "label17";
            label17.Size = new Size(139, 15);
            label17.TabIndex = 18;
            label17.Text = "Status (Radial, Multishot)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(4, 337);
            label16.Name = "label16";
            label16.Size = new Size(82, 15);
            label16.TabIndex = 17;
            label16.Text = "Status (Radial)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(4, 316);
            label15.Name = "label15";
            label15.Size = new Size(143, 15);
            label15.TabIndex = 16;
            label15.Text = "Average Crit Mult (Radial)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(4, 295);
            label14.Name = "label14";
            label14.Size = new Size(134, 15);
            label14.TabIndex = 15;
            label14.Text = "Critical Damage (Radial)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(4, 274);
            label13.Name = "label13";
            label13.Size = new Size(130, 15);
            label13.TabIndex = 14;
            label13.Text = "Critical Chance (Radial)";
            // 
            // labelAverageCritical
            // 
            labelAverageCritical.AutoSize = true;
            labelAverageCritical.Location = new Point(4, 148);
            labelAverageCritical.Name = "labelAverageCritical";
            labelAverageCritical.Size = new Size(144, 15);
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
            labelFireRate.Click += labelFireRate_Click;
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
            labelAmmoEfficiencyValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAmmoEfficiencyValue.AutoSize = true;
            labelAmmoEfficiencyValue.Location = new Point(171, 64);
            labelAmmoEfficiencyValue.Name = "labelAmmoEfficiencyValue";
            labelAmmoEfficiencyValue.Size = new Size(115, 20);
            labelAmmoEfficiencyValue.TabIndex = 36;
            // 
            // labelDamage
            // 
            labelDamage.AutoSize = true;
            labelDamage.Location = new Point(4, 253);
            labelDamage.Name = "labelDamage";
            labelDamage.Size = new Size(51, 15);
            labelDamage.TabIndex = 24;
            labelDamage.Text = "Damage";
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
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 23);
            comboBox1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(comboBox10, 1, 6);
            tableLayoutPanel2.Controls.Add(comboBox9, 0, 6);
            tableLayoutPanel2.Controls.Add(comboBox8, 1, 5);
            tableLayoutPanel2.Controls.Add(comboBox7, 0, 5);
            tableLayoutPanel2.Controls.Add(comboBox6, 1, 4);
            tableLayoutPanel2.Controls.Add(comboBox5, 0, 4);
            tableLayoutPanel2.Controls.Add(comboBox4, 1, 3);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(comboBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(comboBox3, 0, 3);
            tableLayoutPanel2.Location = new Point(320, 81);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(343, 188);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // comboBox10
            // 
            comboBox10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox10.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox10.FormattingEnabled = true;
            comboBox10.Location = new Point(172, 163);
            comboBox10.Margin = new Padding(1);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(170, 23);
            comboBox10.TabIndex = 10;
            // 
            // comboBox9
            // 
            comboBox9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox9.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox9.FormattingEnabled = true;
            comboBox9.Location = new Point(1, 163);
            comboBox9.Margin = new Padding(1);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(169, 23);
            comboBox9.TabIndex = 9;
            // 
            // comboBox8
            // 
            comboBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox8.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(172, 138);
            comboBox8.Margin = new Padding(1);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(170, 23);
            comboBox8.TabIndex = 8;
            // 
            // comboBox7
            // 
            comboBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(1, 138);
            comboBox7.Margin = new Padding(1);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(169, 23);
            comboBox7.TabIndex = 7;
            // 
            // comboBox6
            // 
            comboBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(172, 113);
            comboBox6.Margin = new Padding(1);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(170, 23);
            comboBox6.TabIndex = 6;
            // 
            // comboBox5
            // 
            comboBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(1, 113);
            comboBox5.Margin = new Padding(1);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(169, 23);
            comboBox5.TabIndex = 5;
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(172, 88);
            comboBox4.Margin = new Padding(1);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(170, 23);
            comboBox4.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label2, 2);
            label2.Location = new Point(3, 58);
            label2.Name = "label2";
            label2.Size = new Size(337, 29);
            label2.TabIndex = 2;
            label2.Text = "Weapon Mods";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.SetColumnSpan(comboBox2, 2);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 32);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(337, 23);
            comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label1, 2);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(337, 29);
            label1.TabIndex = 0;
            label1.Text = "Weapon Arcane";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(1, 88);
            comboBox3.Margin = new Padding(1);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(169, 23);
            comboBox3.TabIndex = 3;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1045, 746);
            Controls.Add(tableLayoutPanel2);
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private Label labelDamage;
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
        private Label labelDamageValue;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox10;
        private ComboBox comboBox9;
        private ComboBox comboBox8;
        private ComboBox comboBox7;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
    }
}
