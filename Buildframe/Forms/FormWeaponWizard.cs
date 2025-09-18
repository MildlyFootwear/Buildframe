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
        }
    }
}
