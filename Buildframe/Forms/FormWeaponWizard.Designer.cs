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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWeaponWizard));
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxDescription = new TextBox();
            label5 = new Label();
            label78 = new Label();
            textBoxName = new TextBox();
            label26 = new Label();
            label25 = new Label();
            textBoxID = new TextBox();
            textBoxTags = new TextBox();
            label82 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBoxTertiaryRadial = new ComboBox();
            label7 = new Label();
            comboBoxTertiary = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            comboBoxPrimary = new ComboBox();
            label2 = new Label();
            comboBoxSecondary = new ComboBox();
            label3 = new Label();
            comboBoxPrimaryRadial = new ComboBox();
            label4 = new Label();
            comboBoxSecondaryRadial = new ComboBox();
            buttonCreate = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButtonLoad = new ToolStripButton();
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(textBoxDescription, 1, 4);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(label78, 0, 3);
            tableLayoutPanel2.Controls.Add(textBoxName, 1, 2);
            tableLayoutPanel2.Controls.Add(label26, 0, 2);
            tableLayoutPanel2.Controls.Add(label25, 0, 1);
            tableLayoutPanel2.Controls.Add(textBoxID, 1, 1);
            tableLayoutPanel2.Controls.Add(textBoxTags, 1, 3);
            tableLayoutPanel2.Controls.Add(label82, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 0);
            tableLayoutPanel2.Margin = new Padding(3, 0, 3, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.Size = new Size(372, 208);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescription.Location = new Point(50, 149);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(318, 55);
            textBoxDescription.TabIndex = 25;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(4, 146);
            label5.Name = "label5";
            label5.Size = new Size(32, 61);
            label5.TabIndex = 24;
            label5.Text = "Desc";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label78
            // 
            label78.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label78.AutoSize = true;
            label78.Location = new Point(4, 116);
            label78.Name = "label78";
            label78.Size = new Size(30, 29);
            label78.TabIndex = 22;
            label78.Text = "Tags";
            label78.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(50, 89);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(318, 23);
            textBoxName.TabIndex = 18;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label26.AutoSize = true;
            label26.Location = new Point(4, 86);
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
            label25.Location = new Point(4, 56);
            label25.Name = "label25";
            label25.Size = new Size(18, 29);
            label25.TabIndex = 16;
            label25.Text = "ID";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxID
            // 
            textBoxID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxID.Location = new Point(50, 59);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(318, 23);
            textBoxID.TabIndex = 0;
            textBoxID.TextChanged += textBoxID_TextChanged;
            textBoxID.Leave += textBoxID_Leave;
            // 
            // textBoxTags
            // 
            textBoxTags.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTags.Location = new Point(50, 119);
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
            label82.Margin = new Padding(3, 0, 3, 2);
            label82.Name = "label82";
            label82.Size = new Size(364, 52);
            label82.TabIndex = 23;
            label82.Text = resources.GetString("label82.Text");
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(comboBoxTertiaryRadial, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(comboBoxTertiary, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBoxPrimary, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(comboBoxSecondary, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBoxPrimaryRadial, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(comboBoxSecondaryRadial, 1, 3);
            tableLayoutPanel1.Location = new Point(3, 208);
            tableLayoutPanel1.Margin = new Padding(3, 0, 3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(381, 181);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // comboBoxTertiaryRadial
            // 
            comboBoxTertiaryRadial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxTertiaryRadial.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTertiaryRadial.FormattingEnabled = true;
            comboBoxTertiaryRadial.Location = new Point(73, 154);
            comboBoxTertiaryRadial.Name = "comboBoxTertiaryRadial";
            comboBoxTertiaryRadial.Size = new Size(304, 23);
            comboBoxTertiaryRadial.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(4, 151);
            label7.Name = "label7";
            label7.Size = new Size(62, 29);
            label7.TabIndex = 10;
            label7.Text = "Radial";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxTertiary
            // 
            comboBoxTertiary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxTertiary.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTertiary.FormattingEnabled = true;
            comboBoxTertiary.Location = new Point(73, 124);
            comboBoxTertiary.Name = "comboBoxTertiary";
            comboBoxTertiary.Size = new Size(304, 23);
            comboBoxTertiary.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(4, 121);
            label6.Name = "label6";
            label6.Size = new Size(62, 29);
            label6.TabIndex = 8;
            label6.Text = "Tertiary";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(62, 29);
            label1.TabIndex = 0;
            label1.Text = "Primary";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxPrimary
            // 
            comboBoxPrimary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxPrimary.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrimary.FormattingEnabled = true;
            comboBoxPrimary.Location = new Point(73, 4);
            comboBoxPrimary.Name = "comboBoxPrimary";
            comboBoxPrimary.Size = new Size(304, 23);
            comboBoxPrimary.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(4, 61);
            label2.Name = "label2";
            label2.Size = new Size(62, 29);
            label2.TabIndex = 1;
            label2.Text = "Secondary";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxSecondary
            // 
            comboBoxSecondary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSecondary.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSecondary.FormattingEnabled = true;
            comboBoxSecondary.Location = new Point(73, 64);
            comboBoxSecondary.Name = "comboBoxSecondary";
            comboBoxSecondary.Size = new Size(304, 23);
            comboBoxSecondary.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(4, 31);
            label3.Name = "label3";
            label3.Size = new Size(62, 29);
            label3.TabIndex = 2;
            label3.Text = "Radial";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxPrimaryRadial
            // 
            comboBoxPrimaryRadial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxPrimaryRadial.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrimaryRadial.FormattingEnabled = true;
            comboBoxPrimaryRadial.Location = new Point(73, 34);
            comboBoxPrimaryRadial.Name = "comboBoxPrimaryRadial";
            comboBoxPrimaryRadial.Size = new Size(304, 23);
            comboBoxPrimaryRadial.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(4, 91);
            label4.Name = "label4";
            label4.Size = new Size(62, 29);
            label4.TabIndex = 3;
            label4.Text = "Radial";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxSecondaryRadial
            // 
            comboBoxSecondaryRadial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSecondaryRadial.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSecondaryRadial.FormattingEnabled = true;
            comboBoxSecondaryRadial.Location = new Point(73, 94);
            comboBoxSecondaryRadial.Name = "comboBoxSecondaryRadial";
            comboBoxSecondaryRadial.Size = new Size(304, 23);
            comboBoxSecondaryRadial.TabIndex = 7;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(3, 392);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonLoad });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonLoad
            // 
            toolStripButtonLoad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonLoad.Image = (Image)resources.GetObject("toolStripButtonLoad.Image");
            toolStripButtonLoad.ImageTransparentColor = Color.Magenta;
            toolStripButtonLoad.Name = "toolStripButtonLoad";
            toolStripButtonLoad.Size = new Size(84, 22);
            toolStripButtonLoad.Text = "Load Weapon";
            toolStripButtonLoad.Click += toolStripButtonLoad_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonCreate, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel3.Location = new Point(3, 25);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel3.Size = new Size(387, 418);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // FormWeaponWizard
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            Name = "FormWeaponWizard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Buildframe - Weapon Creation Wizard";
            Load += FormWeaponWizard_Load;
            DragDrop += FormWeaponWizard_DragDrop;
            DragEnter += FormWeaponWizard_DragEnter;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxSecondary;
        private ComboBox comboBoxPrimaryRadial;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxPrimary;
        private ComboBox comboBoxSecondaryRadial;
        private Button button1;
        private Button buttonCreate;
        private TextBox textBoxDescription;
        private Label label5;
        private ComboBox comboBoxTertiaryRadial;
        private Label label7;
        private ComboBox comboBoxTertiary;
        private Label label6;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonLoad;
        private OpenFileDialog openFileDialog1;
        private TableLayoutPanel tableLayoutPanel3;
    }
}