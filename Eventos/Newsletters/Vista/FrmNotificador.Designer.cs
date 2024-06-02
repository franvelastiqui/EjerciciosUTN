namespace Vista
{
    partial class FrmNotificador
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
            btnTecnologia = new Button();
            btnFinanzas = new Button();
            SuspendLayout();
            // 
            // btnTecnologia
            // 
            btnTecnologia.Location = new Point(12, 12);
            btnTecnologia.Name = "btnTecnologia";
            btnTecnologia.Size = new Size(181, 61);
            btnTecnologia.TabIndex = 0;
            btnTecnologia.Text = "Enviar Newsletter Tecnología";
            btnTecnologia.UseVisualStyleBackColor = true;
            // 
            // btnFinanzas
            // 
            btnFinanzas.Location = new Point(206, 12);
            btnFinanzas.Name = "btnFinanzas";
            btnFinanzas.Size = new Size(181, 61);
            btnFinanzas.TabIndex = 1;
            btnFinanzas.Text = "Enviar Newsletter Finanzas";
            btnFinanzas.UseVisualStyleBackColor = true;
            // 
            // FrmNotificador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 97);
            Controls.Add(btnFinanzas);
            Controls.Add(btnTecnologia);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmNotificador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notificador";
            Load += FrmNotificador_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTecnologia;
        private Button btnFinanzas;
    }
}