namespace EjercicioSieteResponsive
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
            btnButton1 = new Button();
            btnButton2 = new Button();
            panel1 = new Panel();
            txtBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnButton1
            // 
            btnButton1.BackColor = Color.LightPink;
            btnButton1.Location = new Point(12, 12);
            btnButton1.Name = "btnButton1";
            btnButton1.Size = new Size(186, 206);
            btnButton1.TabIndex = 0;
            btnButton1.Text = "button1";
            btnButton1.UseVisualStyleBackColor = false;
            // 
            // btnButton2
            // 
            btnButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnButton2.BackColor = Color.Pink;
            btnButton2.Location = new Point(602, 12);
            btnButton2.Name = "btnButton2";
            btnButton2.Size = new Size(186, 206);
            btnButton2.TabIndex = 1;
            btnButton2.Text = "button2";
            btnButton2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PaleGreen;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtBox1);
            panel1.Location = new Point(270, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 426);
            panel1.TabIndex = 2;
            // 
            // txtBox1
            // 
            txtBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBox1.Location = new Point(15, 17);
            txtBox1.Multiline = true;
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(229, 252);
            txtBox1.TabIndex = 0;
            txtBox1.TextChanged += txtBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnButton2);
            Controls.Add(btnButton1);
            MinimumSize = new Size(818, 497);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnButton1;
        private Button btnButton2;
        private Panel panel1;
        private TextBox txtBox1;
    }
}
