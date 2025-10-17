namespace CajonDeSastre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnHelloKiti = new Button();
            SuspendLayout();
            // 
            // btnHelloKiti
            // 
            btnHelloKiti.BackgroundImage = (Image)resources.GetObject("btnHelloKiti.BackgroundImage");
            btnHelloKiti.Location = new Point(597, 155);
            btnHelloKiti.Name = "btnHelloKiti";
            btnHelloKiti.Size = new Size(94, 29);
            btnHelloKiti.TabIndex = 0;
            btnHelloKiti.Text = "button1";
            btnHelloKiti.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHelloKiti);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHelloKiti;
    }
}
