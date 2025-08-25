namespace Buildframe
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Text = Settings.Default.ToolName + " " + Settings.Default.Version;
        }

        private void loadWeaponToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
