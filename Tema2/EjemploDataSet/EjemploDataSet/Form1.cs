namespace EjemploDataSet
{
    public partial class Form1 : Form
    {
        private BBDD baseDeDatos;
        private String valorCodigo;
        public Form1()
        {
            InitializeComponent();
            baseDeDatos = new BBDD();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) txtContraseña.PasswordChar = '\0';
            else txtContraseña.PasswordChar = '*';
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            if (baseDeDatos.Conectar(txtIPServidor.Text, txtPuerto.Text, txtUsuario.Text, txtContraseña.Text))
            {
                MessageBox.Show("se ha conectau");

                dataGridView1.DataSource = baseDeDatos.obtenerGrid();
            }
            if (txtUsuario.Text.Equals("Peter"))
            {
                peter peterForm = new peter();
                peterForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("NO VA");
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ///SI EL VALOR CLICKEADO (RECIBE COMO PARAM E, POR ESO SE USA E)
            if (e.RowIndex >= 0)
            {
                /// OBTENEMOS EL VALOR DE LA FILA (ROW) SOBRE LA QUE SE HA HECHO CLICK
                DataGridViewRow filaClick = dataGridView1.Rows[e.RowIndex];

                ///Pillamos el valor de la primera celda, en este caso al ser array seria 0
                String valorCodigo = filaClick.Cells[0].Value.ToString();

                ///MODIFGICAMOS EL VALOR DE dataGridView2

                dataGridView2.DataSource = baseDeDatos.obtenerDatos(valorCodigo);
                ///Devolvemos este valor :p
                ///
                ////V2 NO SE PUJEDE MODIFICAR EL EVENTO, TIENE QUE SER VOID SI O SI!!!!
                //return valorCodigo;
            }
            //MessageBox.Show(temp);
            //return null; /// ojo cuidao con abusar con null.
        }
    }
}
