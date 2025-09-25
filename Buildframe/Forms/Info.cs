using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Buildframe
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/MildlyFootwear/Buildframe");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://next.nexusmods.com/profile/MildlyShoey/about-me");
        }

        private void Info_Load(object sender, EventArgs e)
        {
            label1.Width = linkLabel1.Width;
            label3.Width = linkLabel1.Width;
            label4.Width = linkLabel1.Width;
            label4.Text = Settings.Default.Version;

            void Close(object sender, EventArgs e)
            {
                this.Close();
            }

            Button cancel = new();
            cancel.Click += Close;
            this.CancelButton = cancel;
        }

        private void linkLabel1_Resize(object sender, EventArgs e)
        { 

        }
    }
}
