namespace Forms
{
    partial class frmPersona
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
            lstPersonas = new ListBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            bntEliminar = new Button();
            btnLeer = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(166, 41);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(35, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(192, 23);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lstPersonas
            // 
            lstPersonas.FormattingEnabled = true;
            lstPersonas.ItemHeight = 15;
            lstPersonas.Location = new Point(12, 103);
            lstPersonas.Name = "lstPersonas";
            lstPersonas.Size = new Size(254, 229);
            lstPersonas.TabIndex = 4;
            lstPersonas.DoubleClick += lstPersonas_DoubleClick;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(318, 103);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(318, 151);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // bntEliminar
            // 
            bntEliminar.Location = new Point(318, 203);
            bntEliminar.Name = "bntEliminar";
            bntEliminar.Size = new Size(75, 23);
            bntEliminar.TabIndex = 7;
            bntEliminar.Text = "Eliminar";
            bntEliminar.UseVisualStyleBackColor = true;
            bntEliminar.Click += bntEliminar_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(318, 253);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(75, 23);
            btnLeer.TabIndex = 8;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // frmPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 353);
            Controls.Add(btnLeer);
            Controls.Add(bntEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(lstPersonas);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblNombre;
        private Label lblApellido;
        private ListBox lstPersonas;
        private Button btnGuardar;
        private Button btnModificar;
        private Button bntEliminar;
        private Button btnLeer;
    }
}