namespace EjercicioDos
{
    public partial class Form1 : Form
    {
        private bool tamano = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Hola Mundo";
        }
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.LightCyan;
            
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.LightPink;
        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            MessageBox.Show("ehh, no puedes arrastrar eso aqui");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (tamano == false)
            {
                WindowState = (FormWindowState)2;
                tamano = true;
            }
            else
            {
                WindowState = (FormWindowState)0;
                tamano = false;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Random aleatorio = new Random();
            Height = aleatorio.Next(600, 801);
            Width = aleatorio.Next(700, 1001);
        }
    }
}
