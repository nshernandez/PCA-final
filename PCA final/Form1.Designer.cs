namespace PCA_final
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
            buttonEntrar = new Button();
            SuspendLayout();
            // 
            // buttonEntrar
            // 
            buttonEntrar.BackColor = Color.Transparent;
            buttonEntrar.Cursor = Cursors.Hand;
            buttonEntrar.Font = new Font("Constantia", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            buttonEntrar.ForeColor = Color.FromArgb(130, 134, 134);
            buttonEntrar.Location = new Point(211, 424);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(75, 33);
            buttonEntrar.TabIndex = 1;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = false;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(505, 484);
            Controls.Add(buttonEntrar);
            ForeColor = Color.Crimson;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonEntrar;

    }
}
