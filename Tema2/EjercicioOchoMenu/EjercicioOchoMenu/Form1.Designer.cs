namespace EjercicioOchoMenu
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
            components = new System.ComponentModel.Container();
            listaMenu = new MenuStrip();
            menuOpcionesSalir = new ToolStripMenuItem();
            opcionSalir = new ToolStripMenuItem();
            opcionGuardar = new ToolStripMenuItem();
            menuOpcionesOpciones = new ToolStripMenuItem();
            sumaToolStripMenuItem = new ToolStripMenuItem();
            restaToolStripMenuItem = new ToolStripMenuItem();
            multiplicacionToolStripMenuItem = new ToolStripMenuItem();
            divisionToolStripMenuItem = new ToolStripMenuItem();
            menuOpcionesAyuda = new ToolStripMenuItem();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            listaMenu.SuspendLayout();
            SuspendLayout();
            // 
            // listaMenu
            // 
            listaMenu.BackColor = Color.LightPink;
            listaMenu.ImageScalingSize = new Size(20, 20);
            listaMenu.Items.AddRange(new ToolStripItem[] { menuOpcionesSalir, menuOpcionesOpciones, menuOpcionesAyuda });
            listaMenu.Location = new Point(0, 0);
            listaMenu.Name = "listaMenu";
            listaMenu.Size = new Size(800, 28);
            listaMenu.TabIndex = 0;
            listaMenu.Text = "menuStrip1";
            // 
            // menuOpcionesSalir
            // 
            menuOpcionesSalir.DropDownItems.AddRange(new ToolStripItem[] { opcionSalir, opcionGuardar });
            menuOpcionesSalir.Name = "menuOpcionesSalir";
            menuOpcionesSalir.Size = new Size(73, 24);
            menuOpcionesSalir.Text = "Archivo";
            // 
            // opcionSalir
            // 
            opcionSalir.BackColor = Color.LightPink;
            opcionSalir.Name = "opcionSalir";
            opcionSalir.Size = new Size(145, 26);
            opcionSalir.Text = "Salir";
            // 
            // opcionGuardar
            // 
            opcionGuardar.BackColor = Color.LightPink;
            opcionGuardar.Name = "opcionGuardar";
            opcionGuardar.Size = new Size(145, 26);
            opcionGuardar.Text = "Guardar";
            // 
            // menuOpcionesOpciones
            // 
            menuOpcionesOpciones.DropDownItems.AddRange(new ToolStripItem[] { sumaToolStripMenuItem, restaToolStripMenuItem, multiplicacionToolStripMenuItem, divisionToolStripMenuItem });
            menuOpcionesOpciones.Name = "menuOpcionesOpciones";
            menuOpcionesOpciones.Size = new Size(85, 24);
            menuOpcionesOpciones.Text = "Opciones";
            // 
            // sumaToolStripMenuItem
            // 
            sumaToolStripMenuItem.BackColor = Color.LightPink;
            sumaToolStripMenuItem.CheckOnClick = true;
            sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            sumaToolStripMenuItem.Size = new Size(186, 26);
            sumaToolStripMenuItem.Text = "Suma";
            sumaToolStripMenuItem.Click += sumaToolStripMenuItem_Click;
            // 
            // restaToolStripMenuItem
            // 
            restaToolStripMenuItem.BackColor = Color.LightPink;
            restaToolStripMenuItem.CheckOnClick = true;
            restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            restaToolStripMenuItem.Size = new Size(186, 26);
            restaToolStripMenuItem.Text = "Resta";
            restaToolStripMenuItem.Click += restaToolStripMenuItem_Click;
            // 
            // multiplicacionToolStripMenuItem
            // 
            multiplicacionToolStripMenuItem.BackColor = Color.LightPink;
            multiplicacionToolStripMenuItem.CheckOnClick = true;
            multiplicacionToolStripMenuItem.Name = "multiplicacionToolStripMenuItem";
            multiplicacionToolStripMenuItem.Size = new Size(186, 26);
            multiplicacionToolStripMenuItem.Text = "Multiplicacion";
            multiplicacionToolStripMenuItem.Click += multiplicacionToolStripMenuItem_Click;
            // 
            // divisionToolStripMenuItem
            // 
            divisionToolStripMenuItem.BackColor = Color.LightPink;
            divisionToolStripMenuItem.CheckOnClick = true;
            divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            divisionToolStripMenuItem.Size = new Size(186, 26);
            divisionToolStripMenuItem.Text = "Division";
            divisionToolStripMenuItem.Click += divisionToolStripMenuItem_Click;
            // 
            // menuOpcionesAyuda
            // 
            menuOpcionesAyuda.Name = "menuOpcionesAyuda";
            menuOpcionesAyuda.Size = new Size(65, 24);
            menuOpcionesAyuda.Text = "Ayuda";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(35, 163);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.maxwell_cat;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(229, 56);
            button1.Name = "button1";
            button1.Size = new Size(257, 160);
            button1.TabIndex = 4;
            button1.Text = "OPERACIONES";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 32);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listaMenu);
            DoubleBuffered = true;
            MainMenuStrip = listaMenu;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            listaMenu.ResumeLayout(false);
            listaMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip listaMenu;
        private ToolStripMenuItem menuOpcionesSalir;
        private ToolStripMenuItem opcionSalir;
        private ToolStripMenuItem opcionGuardar;
        private ToolStripMenuItem menuOpcionesOpciones;
        private ToolStripMenuItem sumaToolStripMenuItem;
        private ToolStripMenuItem restaToolStripMenuItem;
        private ToolStripMenuItem multiplicacionToolStripMenuItem;
        private ToolStripMenuItem divisionToolStripMenuItem;
        private ToolStripMenuItem menuOpcionesAyuda;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
    }
}
