using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InterfazPokedex
{
    partial class FrmAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlta));
            txtNombre = new TextBox();
            nupId = new NumericUpDown();
            lblId = new Label();
            lblNombre = new Label();
            lblTipo = new Label();
            cmbTipos = new ComboBox();
            lblEntrnador = new Label();
            lblImagen = new Label();
            btnBuscar = new Button();
            txtDireccionImagen = new TextBox();
            btnConfirmar = new Button();
            txtEntrenador = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nupId).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Silver;
            txtNombre.Location = new Point(52, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 23);
            txtNombre.TabIndex = 1;
            // 
            // nupId
            // 
            nupId.BackColor = Color.Silver;
            nupId.Location = new Point(215, 30);
            nupId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nupId.Name = "nupId";
            nupId.Size = new Size(58, 23);
            nupId.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.ForeColor = Color.Yellow;
            lblId.Location = new Point(52, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(33, 28);
            lblId.TabIndex = 5;
            lblId.Text = "ID";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Yellow;
            lblNombre.Location = new Point(52, 76);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.ForeColor = Color.Yellow;
            lblTipo.Location = new Point(52, 154);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(54, 28);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo";
            // 
            // cmbTipos
            // 
            cmbTipos.BackColor = Color.Silver;
            cmbTipos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipos.FormattingEnabled = true;
            cmbTipos.Location = new Point(52, 202);
            cmbTipos.Name = "cmbTipos";
            cmbTipos.Size = new Size(221, 23);
            cmbTipos.TabIndex = 9;
            // 
            // lblEntrnador
            // 
            lblEntrnador.AutoSize = true;
            lblEntrnador.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblEntrnador.ForeColor = Color.Yellow;
            lblEntrnador.Location = new Point(52, 243);
            lblEntrnador.Name = "lblEntrnador";
            lblEntrnador.Size = new Size(117, 28);
            lblEntrnador.TabIndex = 10;
            lblEntrnador.Text = "Entrenador";
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblImagen.ForeColor = Color.Yellow;
            lblImagen.Location = new Point(52, 327);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(82, 28);
            lblImagen.TabIndex = 13;
            lblImagen.Text = "Imagen";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 183, 3);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.FromArgb(0, 53, 102);
            btnBuscar.Location = new Point(156, 327);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(117, 31);
            btnBuscar.TabIndex = 51;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtDireccionImagen
            // 
            txtDireccionImagen.BackColor = Color.Silver;
            txtDireccionImagen.Location = new Point(52, 375);
            txtDireccionImagen.Name = "txtDireccionImagen";
            txtDireccionImagen.ReadOnly = true;
            txtDireccionImagen.Size = new Size(221, 23);
            txtDireccionImagen.TabIndex = 53;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(138, 201, 38);
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.FromArgb(0, 53, 102);
            btnConfirmar.Location = new Point(52, 425);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(221, 48);
            btnConfirmar.TabIndex = 54;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtEntrenador
            // 
            txtEntrenador.BackColor = Color.Silver;
            txtEntrenador.Location = new Point(52, 283);
            txtEntrenador.Name = "txtEntrenador";
            txtEntrenador.ReadOnly = true;
            txtEntrenador.Size = new Size(221, 23);
            txtEntrenador.TabIndex = 55;
            // 
            // FrmAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(324, 485);
            Controls.Add(txtEntrenador);
            Controls.Add(btnConfirmar);
            Controls.Add(txtDireccionImagen);
            Controls.Add(btnBuscar);
            Controls.Add(lblImagen);
            Controls.Add(lblEntrnador);
            Controls.Add(cmbTipos);
            Controls.Add(lblTipo);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(nupId);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAlta";
            Text = "FrmAlta";
            Load += FrmAlta_Load;
            ((System.ComponentModel.ISupportInitialize)nupId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nupId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.Label lblEntrnador;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDireccionImagen;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtEntrenador;
    }
}