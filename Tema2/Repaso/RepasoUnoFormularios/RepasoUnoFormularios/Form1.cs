using System.Runtime.CompilerServices;

namespace RepasoUnoFormularios
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblNombre = new Label();
            this.label1 = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(68, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(373, 216);
            this.label1.Name = "label1";
            this.label1.Size = new Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // Form1
            // 
            ClientSize = new Size(811, 453);
            Controls.Add(this.label1);
            Controls.Add(lblNombre);
            MinimumSize = new Size(700, 500);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
