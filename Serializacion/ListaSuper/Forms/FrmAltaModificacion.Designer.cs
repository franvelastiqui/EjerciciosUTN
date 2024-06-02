namespace Forms
{
    partial class FrmAltaModificacion
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
            txtObjeto = new TextBox();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // txtObjeto
            // 
            txtObjeto.Location = new Point(12, 12);
            txtObjeto.MaxLength = 50;
            txtObjeto.Name = "txtObjeto";
            txtObjeto.Size = new Size(392, 23);
            txtObjeto.TabIndex = 0;
            txtObjeto.KeyPress += txtObjeto_KeyPress;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(281, 41);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(152, 41);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(123, 23);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmAltaModificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 73);
            ControlBox = false;
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(txtObjeto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmAltaModificacion";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Título";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtObjeto;
        private Button btnCancelar;
        private Button btnConfirmar;
    }
}