using EjemploDataSet;
using FormularioEstudiantesEMSA.Modelo;

namespace FormularioEstudiantesEMSA
{
    public partial class Form1 : Form
    {
        private BBDD baseDatos = new BBDD();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            if (baseDatos.Conectar())
            {
                btnActualizar.Enabled = true;
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;
                //dataGridView1.DataSource = baseDatos.obtenerGrid();
                mostrarBBDD();
            }
            else
            {
                MessageBox.Show("Nao");
            }
        }
        private void mostrarBBDD()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = baseDatos.leerBBDD();
        }

        private void agregarBixo()
        {
            baseDatos.Agregar(txtNombre.Text, txtApellidos.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("")||txtApellidos.Text.Equals(""))
            {
                MessageBox.Show("Su primico tiene k salir");
            }
            else
            {
                agregarBixo();
            }
            mostrarBBDD();
        }
    }
}
