using Buildframe.GameData;
using Buildframe.Methods;
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
    public partial class FormWeaponWizard : Form
    {
        public FormWeaponWizard()
        {
            InitializeComponent();
        }

        private void FormWeaponWizard_Load(object sender, EventArgs e)
        {
            textBoxID.Text = "weapon_" + Guid.NewGuid().ToString().Substring(0, 8);
            comboBoxPrimary.Items.Add("None");
            comboBoxPrimaryRadial.Items.Add("None");
            comboBoxSecondary.Items.Add("None");
            comboBoxSecondaryRadial.Items.Add("None");
            comboBoxPrimary.SelectedIndex = 0;
            comboBoxPrimaryRadial.SelectedIndex = 0;
            comboBoxSecondary.SelectedIndex = 0;
            comboBoxSecondaryRadial.SelectedIndex = 0;
            foreach (var wm in CommonVars.fireModeStats)
            {
                comboBoxPrimary.Items.Add(wm.Value);
                comboBoxPrimaryRadial.Items.Add(wm.Value);
                comboBoxSecondary.Items.Add(wm.Value);
                comboBoxSecondaryRadial.Items.Add(wm.Value);
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            foreach (string s in CommonVars.ProhibPathChars)
            {
                id = id.Replace(s, "");
            }
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                string s = c.ToString();
                id = id.Replace(s, "");
            }
            textBoxID.Text = id;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Weapon wpn = new Weapon();

            wpn.id = textBoxID.Text;
            wpn.name = textBoxName.Text;
            wpn.tags = textBoxTags.Text;
            if (comboBoxPrimary.SelectedIndex > 0)
            {
                wpn.fireModes.Add(fireModeStats.Values.ToList()[comboBoxPrimary.SelectedIndex-1]);
            }
            if (comboBoxPrimaryRadial.SelectedIndex > 0 && comboBoxPrimary.SelectedIndex > 0)
            {
                wpn.fireModesRadials.Add(fireModeStats.Values.ToList()[comboBoxPrimary.SelectedIndex - 1].id, fireModeStats.Values.ToList()[comboBoxPrimaryRadial.SelectedIndex - 1]);
            }
            if (comboBoxSecondary.SelectedIndex > 0)
            {
                wpn.fireModes.Add(fireModeStats.Values.ToList()[comboBoxSecondary.SelectedIndex - 1]);
            }
            if (comboBoxSecondaryRadial.SelectedIndex > 0 && comboBoxSecondary.SelectedIndex > 0)
            {
                wpn.fireModesRadials.Add(fireModeStats.Values.ToList()[comboBoxSecondary.SelectedIndex - 1].id, fireModeStats.Values.ToList()[comboBoxSecondaryRadial.SelectedIndex - 1]);
            }

            string fileName = wpn.id + " " + wpn.name + ".cfg";
            foreach (string s in CommonVars.ProhibPathChars)
            {
                fileName = fileName.Replace(s, "");
            }
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                string s = c.ToString();
                fileName = fileName.Replace(s, "");
            }
            string filePath = System.IO.Path.Combine(envAPPLOC, "Data", "Weapons", fileName);
            LoadAndSave.saveWeaponToFile(filePath, wpn);
            Close();
        }
    }
}
