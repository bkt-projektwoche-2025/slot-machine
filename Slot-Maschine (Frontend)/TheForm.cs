using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WinFormsApp1
{
    public partial class TheForm : Form
    {
        public TheForm()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            Einloggen einloggen = new Einloggen();

            this.Size = einloggen.Size;
            einloggen.Dock = DockStyle.Fill;
            einloggen.TopLevel = false;
            this.Controls.Clear();
            this.Controls.Add(einloggen);
            einloggen.Show();
            einloggen.Focus();
        }
    }
}
