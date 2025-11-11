namespace EjercicioSeis
{
    public partial class Form1 : Form
    {
        private List<Forestal> listaForestal = new List<Forestal>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = listaForestal;
        }

    }
}
