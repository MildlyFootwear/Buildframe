namespace Buildframe
{
    partial class Info
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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(310, 15);
            label1.TabIndex = 0;
            label1.Text = "GitHub";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.Location = new Point(12, 26);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(297, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/MildlyFootwear/Buildframe";
            linkLabel1.TextAlign = ContentAlignment.TopCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel1.Resize += linkLabel1_Resize;
            // 
            // label3
            // 
            label3.Location = new Point(12, 53);
            label3.Name = "label3";
            label3.Size = new Size(310, 15);
            label3.TabIndex = 4;
            label3.Text = "Version";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(12, 70);
            label4.Margin = new Padding(3, 0, 3, 12);
            label4.Name = "label4";
            label4.Size = new Size(310, 15);
            label4.TabIndex = 5;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(9, 9);
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(341, 143);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Info";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Info";
            Load += Info_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label4;
    }
}