using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDataSet
{
    public partial class peter : Form
    {
        public peter()
        {
            InitializeComponent();
        }

        private void peter_Load(object sender, EventArgs e)
        {
            SoundPlayer musica = new SoundPlayer(Properties.Resources.sonidoCecilio1);
            musica.Play();
        }
    }
}
