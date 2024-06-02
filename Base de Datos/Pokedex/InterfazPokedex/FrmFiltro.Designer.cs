namespace InterfazPokedex
{
    partial class FrmFiltro
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
            cmbFiltro = new ComboBox();
            btnConfirmar = new Button();
            nupDesde = new NumericUpDown();
            nupHasta = new NumericUpDown();
            txtQuery = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nupDesde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupHasta).BeginInit();
            SuspendLayout();
            // 
            // cmbFiltro
            // 
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(26, 37);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(229, 23);
            cmbFiltro.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(255, 183, 3);
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.FromArgb(0, 53, 102);
            btnConfirmar.Location = new Point(78, 90);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(127, 38);
            btnConfirmar.TabIndex = 55;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // nupDesde
            // 
            nupDesde.Location = new Point(26, 37);
            nupDesde.Name = "nupDesde";
            nupDesde.Size = new Size(82, 23);
            nupDesde.TabIndex = 56;
            nupDesde.Visible = false;
            // 
            // nupHasta
            // 
            nupHasta.Location = new Point(173, 37);
            nupHasta.Maximum = new decimal(new int[] { 1500, 0, 0, 0 });
            nupHasta.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupHasta.Name = "nupHasta";
            nupHasta.Size = new Size(82, 23);
            nupHasta.TabIndex = 57;
            nupHasta.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nupHasta.Visible = false;
            // 
            // txtQuery
            // 
            txtQuery.Location = new Point(26, 37);
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(229, 23);
            txtQuery.TabIndex = 58;
            txtQuery.Visible = false;
            // 
            // FrmFiltro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(282, 173);
            Controls.Add(txtQuery);
            Controls.Add(nupHasta);
            Controls.Add(nupDesde);
            Controls.Add(btnConfirmar);
            Controls.Add(cmbFiltro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFiltro";
            Text = "Filtro";
            Load += FrmFiltro_Load;
            ((System.ComponentModel.ISupportInitialize)nupDesde).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupHasta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.NumericUpDown nupDesde;
        private System.Windows.Forms.NumericUpDown nupHasta;
        private System.Windows.Forms.TextBox txtQuery;
    }
}