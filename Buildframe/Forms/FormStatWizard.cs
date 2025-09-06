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
    public partial class FormStatWizard : Form
    {
        public FormStatWizard()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            GameData.Stats stats = new GameData.Stats();

            stats.name = textBoxName.Text;
            stats.description = textBoxDescription.Text;
            stats.id = textBoxID.Text;
            stats.incarnon = checkBoxIncarnon.Checked;

            stats.baseDamage = (double)numericUpDownBaseDamage.Value;
            stats.baseAttackSpeed = (double)numericUpDownBaseAttackSpeed.Value;
            stats.baseReloadTime = (double)numericUpDownBaseReloadTime.Value;
            stats.baseAmmoEfficiency = (double)numericUpDownBaseAmmoEfficiency.Value;
            stats.baseMagazine = (double)numericUpDownBaseMagazine.Value;
            stats.baseChargeTime = (double)numericUpDownBaseChargeTime.Value;
            stats.baseImpact = (double)numericUpDownBaseImpact.Value;
            stats.basePuncture = (double)numericUpDownBasePuncture.Value;
            stats.baseSlash = (double)numericUpDownBaseSlash.Value;
            stats.baseFire = (double)numericUpDownBaseFire.Value;
            stats.baseCold = (double)numericUpDownBaseCold.Value;
            stats.baseElectric = (double)numericUpDownBaseElectric.Value;
            stats.baseToxin = (double)numericUpDownBaseToxin.Value;
            stats.baseBlast = (double)numericUpDownBaseBlast.Value;
            stats.baseRadiation = (double)numericUpDownBaseRadiation.Value;
            stats.baseViral = (double)numericUpDownBaseViral.Value;
            stats.baseCorrosive = (double)numericUpDownBaseCorrosive.Value;
            stats.baseMagnetic = (double)numericUpDownBaseMagnetic.Value;
            stats.baseGas = (double)numericUpDownBaseGas.Value;
            stats.baseMultishot = (double)numericUpDownBaseMultishot.Value;
            stats.baseCriticalChance = (double)numericUpDownBaseCriticalChance.Value;
            stats.baseCriticalDamage = (double)numericUpDownBaseCriticalDamage.Value;
            stats.baseStatusChance = (double)numericUpDownBaseStatusChance.Value;
            stats.baseStatusDamage = (double)numericUpDownBaseStatusDamage.Value;

            stats.modDamage = (double)numericUpDownModDamage.Value;
            stats.modDamagePercentage = (double)numericUpDownAbilityWeaponDamage.Value;
            stats.modDamageFaction = (double)numericUpDownModDamageFaction.Value;
            stats.modAttackSpeed = (double)numericUpDownModAttackSpeed.Value;
            stats.modReloadTime = (double)numericUpDownModReloadTime.Value;
            stats.modMagazine = (double)numericUpDownModMagazine.Value;
            stats.modChargeTime = (double)numericUpDownModChargeTime.Value;
            stats.modImpact = (double)numericUpDownModImpact.Value;
            stats.modPuncture = (double)numericUpDownModPuncture.Value;
            stats.modSlash = (double)numericUpDownModSlash.Value;
            stats.modFire = (double)numericUpDownModFire.Value;
            stats.modCold = (double)numericUpDownModCold.Value;
            stats.modElectric = (double)numericUpDownModElectric.Value;
            stats.modToxin = (double)numericUpDownModToxin.Value;
            stats.modBlast = (double)numericUpDownModBlast.Value;
            stats.modRadiation = (double)numericUpDownModRadiation.Value;
            stats.modViral = (double)numericUpDownModViral.Value;
            stats.modCorrosive = (double)numericUpDownModCorrosive.Value;
            stats.modMagnetic = (double)numericUpDownModMagnetic.Value;
            stats.modGas = (double)numericUpDownModGas.Value;
            stats.modMultishot = (double)numericUpDownModMultishot.Value;
            stats.modCriticalChance = (double)numericUpDownModCriticalChance.Value;
            stats.modCriticalDamage = (double)numericUpDownModCriticalDamage.Value;
            stats.modStatusChance = (double)numericUpDownModStatusChance.Value;
            stats.modStatusDamage = (double)numericUpDownModStatusDamage.Value;

            stats.finalDamage = (double)numericUpDownFinalDamage.Value;
            stats.finalAttackSpeed = (double)numericUpDownFinalAttackSpeed.Value;
            stats.finalReloadTime = (double)numericUpDownFinalReloadTime.Value;
            stats.finalMagazine = (double)numericUpDownFinalMagazine.Value;
            stats.finalChargeTime = (double)numericUpDownFinalChargeTime.Value;
            stats.finalImpact = (double)numericUpDownFinalImpact.Value;
            stats.finalPuncture = (double)numericUpDownFinalPuncture.Value;
            stats.finalSlash = (double)numericUpDownFinalSlash.Value;
            stats.finalFire = (double)numericUpDownFinalFire.Value;
            stats.finalCold = (double)numericUpDownFinalCold.Value;
            stats.finalElectric = (double)numericUpDownFinalElectric.Value;
            stats.finalToxin = (double)numericUpDownFinalToxin.Value;
            stats.finalBlast = (double)numericUpDownFinalBlast.Value;
            stats.finalRadiation = (double)numericUpDownFinalRadiation.Value;
            stats.finalViral = (double)numericUpDownFinalViral.Value;
            stats.finalCorrosive = (double)numericUpDownFinalCorrosive.Value;
            stats.finalMagnetic = (double)numericUpDownFinalMagnetic.Value;
            stats.finalGas = (double)numericUpDownFinalGas.Value;
            stats.finalMultishot = (double)numericUpDownFinalMultishot.Value;
            stats.finalCriticalChance = (double)numericUpDownFinalCriticalChance.Value;
            stats.finalCriticalDamage = (double)numericUpDownFinalCriticalDamage.Value;
            stats.finalStatusChance = (double)numericUpDownFinalStatusChance.Value;
            stats.finalStatusDamage = (double)numericUpDownFinalStatusDamage.Value;

            LoadAndSave.saveStatToFile(stats.id+".cfg", stats);
        }

        private void FormStatWizard_Load(object sender, EventArgs e)
        {
            textBoxID.Text = Guid.NewGuid().ToString();
        }
    }
}
