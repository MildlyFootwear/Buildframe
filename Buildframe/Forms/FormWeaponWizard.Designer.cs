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
            label1 = new Label();
            comboBoxPrimary = new ComboBox();
            label2 = new Label();
            comboBoxSecondary = new ComboBox();
            label3 = new Label();
            comboBoxPrimaryRadial = new ComboBox();
            label4 = new Label();
            comboBoxSecondaryRadial = new ComboBox();
            buttonCreate = new Button();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel2.Controls.Add(textBoxDescription, 1, 4);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(label78, 0, 3);
            tableLayoutPanel2.Controls.Add(textBoxName, 1, 2);
            tableLayoutPanel2.Controls.Add(label26, 0, 2);
            tableLayoutPanel2.Controls.Add(label25, 0, 1);
            tableLayoutPanel2.Controls.Add(textBoxID, 1, 1);
            tableLayoutPanel2.Controls.Add(textBoxTags, 1, 3);
            tableLayoutPanel2.Controls.Add(label82, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.Size = new Size(372, 193);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescription.Location = new Point(50, 145);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(318, 44);
            textBoxDescription.TabIndex = 25;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(4, 142);
            label5.Name = "label5";
            label5.Size = new Size(32, 50);
            label5.TabIndex = 24;
            label5.Text = "Desc";
            label5.TextAlign = ContentAlignment.MiddleCenter;
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
            textBoxID.TextChanged += textBoxID_TextChanged;
            textBoxID.Leave += textBoxID_Leave;
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
            label82.Text = "This is for information and behavior within this application.\r\nSeperate tags with spaces, they will be used for sorting within the UI.\r\nIf Radial is not applicable, leave it set to None.";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBoxPrimary, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(comboBoxSecondary, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBoxPrimaryRadial, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(comboBoxSecondaryRadial, 1, 3);
            tableLayoutPanel1.Location = new Point(3, 183);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(380, 121);
            tableLayoutPanel1.TabIndex = 2;
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
            comboBoxPrimary.Size = new Size(303, 23);
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
            comboBoxSecondary.Size = new Size(303, 23);
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
            comboBoxPrimaryRadial.Size = new Size(303, 23);
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
            comboBoxSecondaryRadial.Size = new Size(303, 23);
            comboBoxSecondaryRadial.TabIndex = 7;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(3, 298);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // FormWeaponWizard
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreate);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
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
    }
}