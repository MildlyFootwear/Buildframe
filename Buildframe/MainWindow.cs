using Buildframe.GameData;

namespace Buildframe
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Weapon baseWeapon = new Weapon();
        public Weapon currentWeapon = new Weapon();
        public List<Stats> selectedStats = new List<Stats>();
        public List<Stats> fireModesWithAppliedStats = new();

        public void loadWeapon(Weapon weapon)
        {

            foreach (Stats stat in weapon.fireModes)
            {
                List<Stats> stats = new List<Stats>();
                stats.Add(stat);
                stats.AddRange(selectedStats);
                Stats appliedStats = Methods.Calculation.StatMethods.sumStats(stats);
                fireModesWithAppliedStats.Add(appliedStats);
            }

            currentWeapon = weapon;
        }

        public void updateWeaponStats()
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Text = Settings.Default.ToolName + " " + Settings.Default.Version;
            if (Settings.Default.SavedPosition != new Point(1, 1))
                this.Location = Settings.Default.SavedPosition; WriteLineIfDebug("    Set position to " + this.Location);
            if (Settings.Default.SavedSize != new Size(1, 1))
                this.Size = Settings.Default.SavedSize; WriteLineIfDebug("    Set size to " + this.Size);
        }

        private void loadWeaponToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolstripButtonEffectWizard_Click(object sender, EventArgs e)
        {
            Forms.FormStatWizard form = new Forms.FormStatWizard();
            form.ShowDialog();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.SavedPosition = this.Location;
            Settings.Default.SavedSize = this.Size;
            Settings.Default.Save();
        }

        private void labelFireRate_Click(object sender, EventArgs e)
        {

        }
    }
}
