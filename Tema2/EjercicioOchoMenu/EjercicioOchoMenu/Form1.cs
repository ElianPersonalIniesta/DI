using System.Windows.Forms.VisualStyles;

namespace EjercicioOchoMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            restaToolStripMenuItem.Checked = false;
            sumaToolStripMenuItem.Checked = true;
            divisionToolStripMenuItem.Checked = false;
            multiplicacionToolStripMenuItem.Checked = false;
            button1.Text = "Suma";

        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            sumaToolStripMenuItem.Checked = false;
            divisionToolStripMenuItem.Checked = false;
            multiplicacionToolStripMenuItem.Checked = false;
            restaToolStripMenuItem.Checked = true;
            button1.Text = "Resta";

        }

        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            restaToolStripMenuItem.Checked = false;
            divisionToolStripMenuItem.Checked = false;
            sumaToolStripMenuItem.Checked = false;
            multiplicacionToolStripMenuItem.Checked = true;
            button1.Text = "Multiplicacion";

        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            divisionToolStripMenuItem.Checked = true;
            restaToolStripMenuItem.Checked = false;
            sumaToolStripMenuItem.Checked = false;
            multiplicacionToolStripMenuItem.Checked = false;
            button1.Text = "Division";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///En verdad podria haber puesto un solo try catch
            if (divisionToolStripMenuItem.Checked)
            {
                try
                {

                    var resultado = Int32.Parse(textBox1.Text) / Int32.Parse(textBox2.Text);
                    textBox3.Text = resultado.ToString();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else if (sumaToolStripMenuItem.Checked)
            {
                try
                {
                    var resultado = Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text);
                    textBox3.Text = resultado.ToString();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else if (restaToolStripMenuItem.Checked)
            {
                try
                {
                    var resultado = Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text);
                    textBox3.Text = resultado.ToString();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else if (multiplicacionToolStripMenuItem.Checked)
            {
                try
                {
                    var resultado = Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text);
                    textBox3.Text = resultado.ToString();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
