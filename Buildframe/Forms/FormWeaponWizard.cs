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

        string loadedFilePath = "";
        string loadedID = "";

        public void loadFile(string filePath)
        {
            WriteLineIfDebug("Loading weapon from file: " + filePath);
            Weapon wpn = LoadAndSave.loadWeaponFromFile(filePath);
            if (wpn.id != "")
            {
                loadedFilePath = filePath;
                loadedID = wpn.id;

                textBoxDescription.Text = wpn.description;
                textBoxID.Text = wpn.id;
                textBoxName.Text = wpn.name;
                textBoxTags.Text = wpn.tags;
                if (wpn.fireModes.Count > 0)
                {
                    comboBoxPrimary.SelectedIndex = fireModeStats.Values.ToList().IndexOf(wpn.fireModes[0]) + 1;
                    if (wpn.fireModesRadials.ContainsKey(wpn.fireModes[0].id))
                    {
                        comboBoxPrimaryRadial.SelectedIndex = fireModeStats.Values.ToList().IndexOf(wpn.fireModesRadials[wpn.fireModes[0].id]) + 1;
                    }
                    else
                    {
                        comboBoxPrimaryRadial.SelectedIndex = 0;
                    }

                }
                else
                {
                    comboBoxPrimary.SelectedIndex = 0;
                    comboBoxPrimaryRadial.SelectedIndex = 0;
                }
                if (wpn.fireModes.Count > 1)
                {
                    comboBoxSecondary.SelectedIndex = fireModeStats.Values.ToList().IndexOf(wpn.fireModes[1]) + 1;
                    if (wpn.fireModesRadials.ContainsKey(wpn.fireModes[1].id))
                    {
                        comboBoxSecondaryRadial.SelectedIndex = fireModeStats.Values.ToList().IndexOf(wpn.fireModesRadials[wpn.fireModes[1].id]) + 1;
                    }
                    else
                    {
                        comboBoxSecondaryRadial.SelectedIndex = 0;
                    }
                }
                else
                {
                    comboBoxSecondary.SelectedIndex = 0;
                    comboBoxSecondaryRadial.SelectedIndex = 0;
                }
                if (wpn.fireModes.Count > 2)
                {
                    comboBoxTertiary.SelectedIndex = fireModeStats.Values.ToList().IndexOf(wpn.fireModes[2]) + 1;
                    if (wpn.fireModesRadials.ContainsKey(wpn.fireModes[2].id))
                    {
                        comboBoxTertiaryRadial.SelectedIndex = fireModeStats.Values.ToList().IndexOf(wpn.fireModesRadials[wpn.fireModes[2].id]) + 1;
                    }
                    else
                    {
                        comboBoxTertiaryRadial.SelectedIndex = 0;
                    }
                }
                else
                {
                    comboBoxTertiary.SelectedIndex = 0;
                    comboBoxTertiaryRadial.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Failed to load stats from file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormWeaponWizard_Load(object sender, EventArgs e)
        {
            textBoxID.Text = "weapon_" + Guid.NewGuid().ToString().Substring(0, 8);
            comboBoxPrimary.Items.Add("None");
            comboBoxPrimaryRadial.Items.Add("None");
            comboBoxSecondary.Items.Add("None");
            comboBoxSecondaryRadial.Items.Add("None");
            comboBoxTertiary.Items.Add("None");
            comboBoxTertiaryRadial.Items.Add("None");
            comboBoxPrimary.SelectedIndex = 0;
            comboBoxPrimaryRadial.SelectedIndex = 0;
            comboBoxSecondary.SelectedIndex = 0;
            comboBoxSecondaryRadial.SelectedIndex = 0;
            comboBoxTertiary.SelectedIndex = 0;
            comboBoxTertiaryRadial.SelectedIndex = 0;
            foreach (var wm in CommonVars.fireModeStats)
            {
                comboBoxPrimary.Items.Add(wm.Value);
                comboBoxPrimaryRadial.Items.Add(wm.Value);
                comboBoxSecondary.Items.Add(wm.Value);
                comboBoxSecondaryRadial.Items.Add(wm.Value);
                comboBoxTertiary.Items.Add(wm.Value);
                comboBoxTertiaryRadial.Items.Add(wm.Value);
            }
            tableLayoutPanel2.Width = tableLayoutPanel1.Width;

            Button close = new Button();
            close.Click += (s, ev) => { Close(); };
            this.CancelButton = close;
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
            if (id.Trim() == "" || id.Trim() == string.Empty)
            {
                id = "weapon_" + Guid.NewGuid().ToString().Substring(0, 8);
            }
            textBoxID.Text = id;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            if (textBoxTags.Text.Split(' ').Contains("None"))
            {
                MessageBox.Show("The tag 'None' is reserved and will result in all selection boxes being empty if used.", "Buildframe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (textBoxName.Text.Trim() == "" || textBoxName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("A name is required.", "Buildframe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (textBoxID.Text == loadedID)
            {
                if (File.Exists(loadedFilePath))
                {
                    if (MessageBox.Show("You will overwrite the loaded file unless you change the ID.\nContinue?", "Buildframe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        WriteLineIfDebug("Deleting loaded file: " + loadedFilePath);
                        File.Delete(loadedFilePath);
                    }
                }
            }

            Weapon wpn = new Weapon();

            wpn.id = textBoxID.Text;
            wpn.name = textBoxName.Text;
            wpn.description = textBoxDescription.Text;
            wpn.tags = textBoxTags.Text;
            if (comboBoxPrimary.SelectedIndex > 0)
            {
                wpn.fireModes.Add(fireModeStats.Values.ToList()[comboBoxPrimary.SelectedIndex - 1]);
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
            if (comboBoxTertiary.SelectedIndex > 0)
            {
                wpn.fireModes.Add(fireModeStats.Values.ToList()[comboBoxTertiary.SelectedIndex - 1]);
            }
            if (comboBoxTertiaryRadial.SelectedIndex > 0 && comboBoxTertiary.SelectedIndex > 0)
            {
                wpn.fireModesRadials.Add(fireModeStats.Values.ToList()[comboBoxTertiary.SelectedIndex - 1].id, fireModeStats.Values.ToList()[comboBoxTertiaryRadial.SelectedIndex - 1]);
            }

            string fileName = LoadAndSave.cleanFileName(wpn.name + " - " + wpn.id + ".cfg");

            string filePath = System.IO.Path.Combine(envAPPLOC, "Data", "Weapons", fileName);
            LoadAndSave.saveWeaponToFile(filePath, wpn);
            Close();
        }

        private void FormWeaponWizard_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void FormWeaponWizard_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string filePath = files[0];
                    loadFile(filePath);
                }
            }
        }

        private void toolStripButtonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a weapon file to load";
            openFileDialog1.Filter = "Config Files|*.cfg";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = System.IO.Path.Combine(envAPPLOC, "Data", "Weapons");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadFile(openFileDialog1.FileName);
            }
        }
    }
}
