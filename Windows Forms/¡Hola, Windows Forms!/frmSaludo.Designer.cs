namespace _Hola__Windows_Forms_
{
    partial class frmSaludo
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
            lblHola = new Label();
            lblNombrePantalla = new Label();
            SuspendLayout();
            // 
            // lblHola
            // 
            lblHola.AutoSize = true;
            lblHola.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHola.Location = new Point(2, 24);
            lblHola.Name = "lblHola";
            lblHola.Size = new Size(78, 25);
            lblHola.TabIndex = 0;
            lblHola.Text = "lblHola";
            // 
            // lblNombrePantalla
            // 
            lblNombrePantalla.AutoSize = true;
            lblNombrePantalla.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombrePantalla.Location = new Point(12, 73);
            lblNombrePantalla.Name = "lblNombrePantalla";
            lblNombrePantalla.Size = new Size(139, 21);
            lblNombrePantalla.TabIndex = 1;
            lblNombrePantalla.Text = "lblNombrePantalla";
            // 
            // frmSaludo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(319, 124);
            Controls.Add(lblNombrePantalla);
            Controls.Add(lblHola);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSaludo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saludo";
            Load += frmSaludo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHola;
        private Label lblNombrePantalla;
    }
}