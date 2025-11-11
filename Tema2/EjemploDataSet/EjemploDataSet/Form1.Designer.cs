namespace EjemploDataSet
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            txtIPServidor = new TextBox();
            txtPuerto = new TextBox();
            checkBox1 = new CheckBox();
            btnConectar = new Button();
            dataGridView1 = new DataGridView();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(14, 64);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(-26, 152);
            label3.Name = "label3";
            label3.Size = new Size(161, 25);
            label3.TabIndex = 2;
            label3.Text = "IP Servidor BBDD";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(14, 189);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 3;
            label4.Text = "Puerto";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(166, 29);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(131, 27);
            txtUsuario.TabIndex = 4;
            txtUsuario.Text = "root";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(166, 64);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(131, 27);
            txtContraseña.TabIndex = 5;
            txtContraseña.Text = "root";
            // 
            // txtIPServidor
            // 
            txtIPServidor.Location = new Point(166, 152);
            txtIPServidor.Name = "txtIPServidor";
            txtIPServidor.Size = new Size(131, 27);
            txtIPServidor.TabIndex = 6;
            txtIPServidor.Text = "127.0.0.1";
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(166, 189);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(131, 27);
            txtPuerto.TabIndex = 7;
            txtPuerto.Text = "3306";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(166, 97);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(147, 21);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Mostrar Contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnConectar
            // 
            btnConectar.BackColor = Color.LightPink;
            btnConectar.Location = new Point(696, 172);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(94, 29);
            btnConectar.TabIndex = 9;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += btnConectar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightPink;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.HighlightText;
            dataGridView1.Location = new Point(12, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 131);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(319, 29);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(174, 124);
            listBox1.TabIndex = 11;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(534, 29);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(174, 124);
            listBox2.TabIndex = 12;
            // 
            // label5
            // 
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(303, 30);
            label5.Name = "label5";
            label5.Size = new Size(190, 25);
            label5.TabIndex = 13;
            label5.Text = "Selecciona Base de Datos";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(527, 30);
            label6.Name = "label6";
            label6.Size = new Size(198, 25);
            label6.TabIndex = 14;
            label6.Text = "Selecciona Base de Datos";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.LightPink;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = SystemColors.HighlightText;
            dataGridView2.Location = new Point(12, 438);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(776, 131);
            dataGridView2.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 683);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnConectar);
            Controls.Add(checkBox1);
            Controls.Add(txtPuerto);
            Controls.Add(txtIPServidor);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private TextBox txtIPServidor;
        private TextBox txtPuerto;
        private CheckBox checkBox1;
        private Button btnConectar;
        private DataGridView dataGridView1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView2;
    }
}
