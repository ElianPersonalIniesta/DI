namespace EjercicioUno
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
            btnPulsame = new Button();
            SuspendLayout();
            // 
            // btnPulsame
            // 
            btnPulsame.Location = new Point(12, 12);
            btnPulsame.Name = "btnPulsame";
            btnPulsame.Size = new Size(94, 29);
            btnPulsame.TabIndex = 0;
            btnPulsame.Text = "button1";
            btnPulsame.UseVisualStyleBackColor = true;
            btnPulsame.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(784, 450);
            Controls.Add(btnPulsame);
            Name = "Form1";
            Text = "Hellou Kiti";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPulsame;
    }
}
