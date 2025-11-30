namespace EjemploDataSet
{
    partial class LecturaFormcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblDistrito = new Label();
            lblPoblacion = new Label();
            txtNombre = new TextBox();
            txtDistrito = new TextBox();
            txtPoblacion = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(65, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblDistrito
            // 
            lblDistrito.AutoSize = true;
            lblDistrito.Location = new Point(71, 109);
            lblDistrito.Name = "lblDistrito";
            lblDistrito.Size = new Size(58, 20);
            lblDistrito.TabIndex = 1;
            lblDistrito.Text = "Distrito";
            lblDistrito.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPoblacion
            // 
            lblPoblacion.AutoSize = true;
            lblPoblacion.Location = new Point(55, 152);
            lblPoblacion.Name = "lblPoblacion";
            lblPoblacion.Size = new Size(74, 20);
            lblPoblacion.TabIndex = 2;
            lblPoblacion.Text = "Poblacion";
            lblPoblacion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(167, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(217, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtDistrito
            // 
            txtDistrito.Enabled = false;
            txtDistrito.Location = new Point(167, 106);
            txtDistrito.Name = "txtDistrito";
            txtDistrito.ReadOnly = true;
            txtDistrito.Size = new Size(217, 27);
            txtDistrito.TabIndex = 4;
            // 
            // txtPoblacion
            // 
            txtPoblacion.Enabled = false;
            txtPoblacion.Location = new Point(167, 149);
            txtPoblacion.Name = "txtPoblacion";
            txtPoblacion.ReadOnly = true;
            txtPoblacion.Size = new Size(217, 27);
            txtPoblacion.TabIndex = 5;
            // 
            // LecturaFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(555, 256);
            Controls.Add(txtPoblacion);
            Controls.Add(txtDistrito);
            Controls.Add(txtNombre);
            Controls.Add(lblPoblacion);
            Controls.Add(lblDistrito);
            Controls.Add(lblNombre);
            Name = "LecturaFormcs";
            Text = "LecturaFormcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblDistrito;
        private Label lblPoblacion;
        private TextBox txtNombre;
        private TextBox txtDistrito;
        private TextBox txtPoblacion;
    }
}