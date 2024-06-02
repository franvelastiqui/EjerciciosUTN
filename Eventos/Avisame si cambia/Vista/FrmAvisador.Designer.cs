namespace Vista
{
    partial class FrmAvisador
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
            lblNombre = new Label();
            lblApellido = new Label();
            btnCrear = new Button();
            lblNombreCompleto = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(35, 62);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(35, 113);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(35, 178);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(184, 23);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNombreCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreCompleto.Location = new Point(48, 243);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(150, 21);
            lblNombreCompleto.TabIndex = 3;
            lblNombreCompleto.Text = "Nombre completo";
            lblNombreCompleto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(119, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Location = new Point(119, 110);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 5;
            // 
            // FrmAvisador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(245, 300);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombreCompleto);
            Controls.Add(btnCrear);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmAvisador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "El Avisador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Button btnCrear;
        private Label lblNombreCompleto;
        private TextBox txtNombre;
        private TextBox txtApellido;
    }
}