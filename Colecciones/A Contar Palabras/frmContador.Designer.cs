namespace A_Contar_Palabras
{
    partial class frmContador
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
            rtbPalabras = new RichTextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // rtbPalabras
            // 
            rtbPalabras.Location = new Point(12, 12);
            rtbPalabras.Name = "rtbPalabras";
            rtbPalabras.Size = new Size(360, 315);
            rtbPalabras.TabIndex = 0;
            rtbPalabras.Text = "";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(297, 340);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmContador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 375);
            Controls.Add(btnCalcular);
            Controls.Add(rtbPalabras);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmContador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contador de Palabras";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbPalabras;
        private Button btnCalcular;
    }
}