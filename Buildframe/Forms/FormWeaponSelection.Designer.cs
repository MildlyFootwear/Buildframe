namespace Buildframe.Forms
{
    partial class FormWeaponSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxWeaponSelect = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxWeaponSelect
            // 
            comboBoxWeaponSelect.FormattingEnabled = true;
            comboBoxWeaponSelect.Location = new Point(3, 3);
            comboBoxWeaponSelect.Name = "comboBoxWeaponSelect";
            comboBoxWeaponSelect.Size = new Size(256, 23);
            comboBoxWeaponSelect.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(94, 32);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormWeaponSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(368, 107);
            Controls.Add(button1);
            Controls.Add(comboBoxWeaponSelect);
            Name = "FormWeaponSelection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Buildframe - Weapon Select";
            Load += FormWeaponSelection_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxWeaponSelect;
        private Button button1;
    }
}