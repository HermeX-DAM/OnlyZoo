namespace OnlyZoo_Project
{
    public partial class Vista_Mascotas : Form
    {
        public Vista_Mascotas()
        {
            InitializeComponent();
            SetFullScreen();
        }

        private void SetFullScreen()
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}