namespace EjercicioSieteResponsive
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
            txtBox1.Anchor = AnchorStyles.Left |
            AnchorStyles.Right |
             AnchorStyles.Top |
           AnchorStyles.Bottom;
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
