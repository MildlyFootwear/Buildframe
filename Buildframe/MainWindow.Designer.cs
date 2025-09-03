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
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolstripButtonEffectWizard });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(560, 25);
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
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(toolStrip1);
            Margin = new Padding(2);
            Name = "MainWindow";
            Text = "Buildframe";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem addWeaponToolStripMenuItem;
        private ToolStripMenuItem loadWeaponToolStripMenuItem;
        private ToolStripButton toolstripButtonEffectWizard;
    }
}
