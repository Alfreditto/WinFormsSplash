namespace WinFormsSplash
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void opcion1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hola mundo");
        }
    }
}