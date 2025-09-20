using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buildframe.Forms
{
    public partial class FormWeaponSelection : Form
    {
        public MainWindow mainWindow;

        public FormWeaponSelection()
        {
            InitializeComponent();
        }

        private void FormWeaponSelection_Load(object sender, EventArgs e)
        {
            comboBoxWeaponSelect.Items.Add("None");
            foreach (var w in CommonVars.weaponStats)
            {
                comboBoxWeaponSelect.Items.Add(w.Value);
            }
            comboBoxWeaponSelect.SelectedIndex = 0;
            Button cancel = new Button();
            cancel.Click += (s, ev) => { this.Close(); };
            this.CancelButton = cancel;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxWeaponSelect.SelectedIndex != 0)
            {
                mainWindow.currentWeapon = weaponStats.Values.ToList()[comboBoxWeaponSelect.SelectedIndex - 1];
                WriteLineIfDebug("Selected weapon: " + mainWindow.currentWeapon.name);
            }
            else
            {
                mainWindow.currentWeapon = new();
                WriteLineIfDebug("No weapon selected.");
            }
            this.Close();
        }

        private void comboBoxWeaponSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxWeaponSelect.SelectedIndex < 1)
            {
                label1.Text = "No weapon selected.";
                return;
            }
            label1.Text = weaponStats.Values.ToList()[comboBoxWeaponSelect.SelectedIndex - 1].description;
        }
    }
}
