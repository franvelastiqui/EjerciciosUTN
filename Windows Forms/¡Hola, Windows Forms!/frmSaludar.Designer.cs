namespace _Hola__Windows_Forms_
{
    partial class frmSaludar
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            btnSaludar = new Button();
            lblMateria = new Label();
            cmbMateria = new ComboBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(207, 45);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(207, 18);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(52, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(207, 161);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(100, 23);
            btnSaludar.TabIndex = 4;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMateria.Location = new Point(12, 84);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(97, 15);
            lblMateria.TabIndex = 5;
            lblMateria.Text = "Materia favorita";
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(12, 114);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(295, 23);
            cmbMateria.TabIndex = 6;
            // 
            // frmSaludar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 196);
            Controls.Add(cmbMateria);
            Controls.Add(lblMateria);
            Controls.Add(btnSaludar);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSaludar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¡Hola, Windows Form!";
            Load += frmSaludar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblNombre;
        private Label lblApellido;
        private Button btnSaludar;
        private Label lblMateria;
        private ComboBox cmbMateria;
    }
}