namespace InterfazPokedex
{
    partial class FrmSerializacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerializacion));
            btnConfirmar = new Button();
            txtNombreArchivo = new TextBox();
            rdbJSON = new RadioButton();
            rdbXML = new RadioButton();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(255, 183, 3);
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.FromArgb(0, 53, 102);
            btnConfirmar.Location = new Point(79, 153);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(127, 38);
            btnConfirmar.TabIndex = 56;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtNombreArchivo
            // 
            txtNombreArchivo.Location = new Point(60, 50);
            txtNombreArchivo.Name = "txtNombreArchivo";
            txtNombreArchivo.PlaceholderText = "Nombre del archivo...";
            txtNombreArchivo.Size = new Size(182, 23);
            txtNombreArchivo.TabIndex = 57;
            // 
            // rdbJSON
            // 
            rdbJSON.AutoSize = true;
            rdbJSON.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbJSON.ForeColor = Color.FromArgb(255, 183, 3);
            rdbJSON.Location = new Point(62, 100);
            rdbJSON.Name = "rdbJSON";
            rdbJSON.Size = new Size(55, 19);
            rdbJSON.TabIndex = 58;
            rdbJSON.TabStop = true;
            rdbJSON.Text = "JSON";
            rdbJSON.UseVisualStyleBackColor = true;
            // 
            // rdbXML
            // 
            rdbXML.AutoSize = true;
            rdbXML.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbXML.ForeColor = Color.FromArgb(255, 183, 3);
            rdbXML.Location = new Point(170, 100);
            rdbXML.Name = "rdbXML";
            rdbXML.Size = new Size(50, 19);
            rdbXML.TabIndex = 59;
            rdbXML.TabStop = true;
            rdbXML.Text = "XML";
            rdbXML.UseVisualStyleBackColor = true;
            // 
            // FrmSerializacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(285, 254);
            Controls.Add(rdbXML);
            Controls.Add(rdbJSON);
            Controls.Add(txtNombreArchivo);
            Controls.Add(btnConfirmar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSerializacion";
            Text = "FrmSerializacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.RadioButton rdbJSON;
        private System.Windows.Forms.RadioButton rdbXML;
    }
}