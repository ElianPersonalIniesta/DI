namespace Ejercicio2Clase
{
    public partial class Form1 : Form
    {
        private List<Coche> coches;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*for(int i = 0; i<listBox1.Items.Count; i++)
            {
                comboBox1.Items.Add(listBox1.Items[i].ToString());
            }
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            listBox1.Items.Add("Mazda");
            listBox1.SelectedIndex = listBox1.Items.Count - 1;*/

            coches = new List<Coche>();
            coches.Add(new Coche("Mercedes", "Clase A"));
            coches.Add(new Coche("Audi", "Q A"));
            coches.Add(new Coche("Opel", "Astra"));
            coches.Add(new Coche("Seat", "Leon"));

            listBox1.DataSource = coches;
            comboBox1.DataSource = coches;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblResolucion_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Rdb640x480(object sender, EventArgs e)
        {
            if (chbVentana2.Checked)
            {

            }
            else if (rdbResolucion1.Checked)
            {
                this.Size = new Size(640, 480);
            }
        }

        private void Rdb800x600(object sender, EventArgs e)
        {
            if (chbVentana2.Checked)
            {

            }
            else if (rdbResolucion2.Checked)
            {
                this.Size = new Size(800, 600);
            }
        }
        private void Rdb1024x768(object sender, EventArgs e)
        {
            if (chbVentana2.Checked)
            {

            }
            else if (rdbResolucion3.Checked)
            {
                this.Size = new Size(1024, 768);
            }
        }
        /*
         private void rdbResolution1_CheckedChange(Object sender, EventArgs e)
        {
            RadiuButton rdbPulsado = (RadioButton) sender;
            switch(rdbPulsado.TabIndex)
            {
                case 0:
                    MessageBox.Show("Se ha cambiado el estado de radiobutton"+rdbPulsado.Text+" al valor" rdbPulsado.algo);
                    if(rdbButton.isChecked()
                    {
                        this.Size = 640,480
                    }

                    break;

                case 1:
                    MessageBox.Show("Se ha cambiado el estado de radiobutton"+rdbPulsado.Text+" al valor" rdbPulsado.algo);
                    if(rdbButton.isChecked()
                    {
                        this.Width = 800;
                        this.Heigh = 600;
                    }
                    break;

                case 2:
                    MessageBox.Show("Se ha cambiado el estado de radiobutton"+rdbPulsado.Text+" al valor" rdbPulsado.algo);
                    if(rdbButton.isChecked()
                    {
                        this.Size = aaaa;
                    }
                    break;
            }

        }
         */

        private void chbVentana_Max(object sender, EventArgs e)
        {
            CheckBox chkSent = (CheckBox)sender;
            if (chkSent.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
