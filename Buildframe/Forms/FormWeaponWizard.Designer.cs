namespace Buildframe.Forms
{
    partial class FormWeaponWizard
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label78 = new Label();
            textBoxName = new TextBox();
            label26 = new Label();
            label25 = new Label();
            textBoxID = new TextBox();
            textBoxTags = new TextBox();
            label82 = new Label();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(label78, 0, 3);
            tableLayoutPanel2.Controls.Add(textBoxName, 1, 2);
            tableLayoutPanel2.Controls.Add(label26, 0, 2);
            tableLayoutPanel2.Controls.Add(label25, 0, 1);
            tableLayoutPanel2.Controls.Add(textBoxID, 1, 1);
            tableLayoutPanel2.Controls.Add(textBoxTags, 1, 3);
            tableLayoutPanel2.Controls.Add(label82, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(372, 142);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label78
            // 
            label78.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label78.AutoSize = true;
            label78.Location = new Point(4, 112);
            label78.Name = "label78";
            label78.Size = new Size(30, 29);
            label78.TabIndex = 22;
            label78.Text = "Tags";
            label78.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(50, 85);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(318, 23);
            textBoxName.TabIndex = 18;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label26.AutoSize = true;
            label26.Location = new Point(4, 82);
            label26.Name = "label26";
            label26.Size = new Size(39, 29);
            label26.TabIndex = 17;
            label26.Text = "Name";
            label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label25.AutoSize = true;
            label25.Location = new Point(4, 52);
            label25.Name = "label25";
            label25.Size = new Size(18, 29);
            label25.TabIndex = 16;
            label25.Text = "ID";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxID
            // 
            textBoxID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxID.Location = new Point(50, 55);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(318, 23);
            textBoxID.TabIndex = 0;
            // 
            // textBoxTags
            // 
            textBoxTags.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTags.Location = new Point(50, 115);
            textBoxTags.Name = "textBoxTags";
            textBoxTags.Size = new Size(318, 23);
            textBoxTags.TabIndex = 21;
            textBoxTags.Text = "Any";
            // 
            // label82
            // 
            label82.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label82.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label82, 2);
            label82.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label82.Location = new Point(4, 1);
            label82.Name = "label82";
            label82.Size = new Size(364, 50);
            label82.TabIndex = 23;
            label82.Text = "This is for information and behavior within this application.\r\nSeperate tags with spaces, they will be used for sorting within the UI.";
            // 
            // FormWeaponWizard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Name = "FormWeaponWizard";
            Text = "Buildframe - Weapon Creation Wizard";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label78;
        private TextBox textBoxName;
        private Label label26;
        private Label label25;
        private TextBox textBoxID;
        private TextBox textBoxTags;
        private Label label82;
    }
}