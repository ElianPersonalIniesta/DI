using System.Collections;

namespace EjercicioSeis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnAleman = new Button();
            btnTIKITIKI = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Silver;
            listBox1.ForeColor = SystemColors.WindowFrame;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(228, 102);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(188, 164);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(198, 297);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(336, 297);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAleman
            // 
            btnAleman.Location = new Point(198, 343);
            btnAleman.Name = "btnAleman";
            btnAleman.Size = new Size(94, 29);
            btnAleman.TabIndex = 0;
            btnAleman.Text = "Aleman";
            btnAleman.UseVisualStyleBackColor = true;
            // 
            // btnTIKITIKI
            // 
            btnTIKITIKI.Location = new Point(336, 343);
            btnTIKITIKI.Name = "btnTIKITIKI";
            btnTIKITIKI.Size = new Size(94, 29);
            btnTIKITIKI.TabIndex = 0;
            btnTIKITIKI.Text = "TIKITIKI";
            btnTIKITIKI.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(618, 499);
            Controls.Add(btnTIKITIKI);
            Controls.Add(btnAleman);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximumSize = new Size(640, 550);
            MinimumSize = new Size(640, 550);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnAleman;
        private Button btnTIKITIKI;
    }
}
