namespace EjercicioSeis
{
    partial class Form2 : Form
    {
        Form1 form;
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
        public Form2(Form1 form)
        {
            this.form = form;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblSegundoApellido = new Label();
            lblPrimerApellido = new Label();
            lblTelefono = new Label();
            txtbxNombre = new TextBox();
            txtBPrimerApellido = new TextBox();
            txtBSegundoApellido = new TextBox();
            txtBTelefono = new TextBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.ImageAlign = ContentAlignment.MiddleRight;
            lblNombre.Location = new Point(94, 72);
            lblNombre.Margin = new Padding(3, 0, 3, 3);
            lblNombre.Name = "lblNombre";
            lblNombre.Padding = new Padding(0, 0, 0, 3);
            lblNombre.RightToLeft = RightToLeft.No;
            lblNombre.Size = new Size(87, 33);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.BorderStyle = BorderStyle.FixedSingle;
            lblSegundoApellido.Font = new Font("Segoe UI", 12F);
            lblSegundoApellido.ImageAlign = ContentAlignment.MiddleRight;
            lblSegundoApellido.Location = new Point(9, 183);
            lblSegundoApellido.Margin = new Padding(3, 0, 3, 3);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Padding = new Padding(0, 0, 0, 3);
            lblSegundoApellido.RightToLeft = RightToLeft.No;
            lblSegundoApellido.Size = new Size(172, 33);
            lblSegundoApellido.TabIndex = 1;
            lblSegundoApellido.Text = "Segundo Apellido";
            lblSegundoApellido.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.BorderStyle = BorderStyle.FixedSingle;
            lblPrimerApellido.Font = new Font("Segoe UI", 12F);
            lblPrimerApellido.ImageAlign = ContentAlignment.MiddleRight;
            lblPrimerApellido.Location = new Point(31, 125);
            lblPrimerApellido.Margin = new Padding(3, 0, 3, 3);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Padding = new Padding(0, 0, 0, 3);
            lblPrimerApellido.RightToLeft = RightToLeft.No;
            lblPrimerApellido.Size = new Size(150, 33);
            lblPrimerApellido.TabIndex = 2;
            lblPrimerApellido.Text = "Primer Apellido";
            lblPrimerApellido.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BorderStyle = BorderStyle.FixedSingle;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.ImageAlign = ContentAlignment.MiddleRight;
            lblTelefono.Location = new Point(93, 240);
            lblTelefono.Margin = new Padding(3, 0, 3, 3);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Padding = new Padding(0, 0, 0, 3);
            lblTelefono.RightToLeft = RightToLeft.No;
            lblTelefono.Size = new Size(88, 33);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono";
            lblTelefono.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbxNombre
            // 
            txtbxNombre.Location = new Point(210, 78);
            txtbxNombre.Name = "txtbxNombre";
            txtbxNombre.Size = new Size(453, 27);
            txtbxNombre.TabIndex = 4;
            // 
            // txtBPrimerApellido
            // 
            txtBPrimerApellido.Location = new Point(210, 130);
            txtBPrimerApellido.Name = "txtBPrimerApellido";
            txtBPrimerApellido.Size = new Size(453, 27);
            txtBPrimerApellido.TabIndex = 5;
            // 
            // txtBSegundoApellido
            // 
            txtBSegundoApellido.Location = new Point(210, 183);
            txtBSegundoApellido.Name = "txtBSegundoApellido";
            txtBSegundoApellido.Size = new Size(453, 27);
            txtBSegundoApellido.TabIndex = 6;
            // 
            // txtBTelefono
            // 
            txtBTelefono.Location = new Point(210, 240);
            txtBTelefono.Name = "txtBTelefono";
            txtBTelefono.Size = new Size(453, 27);
            txtBTelefono.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(210, 344);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(535, 344);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtBTelefono);
            Controls.Add(txtBSegundoApellido);
            Controls.Add(txtBPrimerApellido);
            Controls.Add(txtbxNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblPrimerApellido);
            Controls.Add(lblSegundoApellido);
            Controls.Add(lblNombre);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblSegundoApellido;
        private Label lblPrimerApellido;
        private Label lblTelefono;
        private TextBox txtbxNombre;
        private TextBox txtBPrimerApellido;
        private TextBox txtBSegundoApellido;
        private TextBox txtBTelefono;
        private Button btnAgregar;
        private Button btnCancelar;
    }
}