namespace EjercicioUno
{
    /// <summary>
    /// Este es la pantalla principal que se ve, hereda de la clase Form
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            ///Cuando se lanza este metodo va a darle a las propiedades un valor!
            InitializeComponent();
            this.Text = "Hellou kiti";
            btnPulsame.Text = "Helo kiti";
        }

        private void btnPulsameClick(object sender, EventArgs e)
        {

        }
    }
}
