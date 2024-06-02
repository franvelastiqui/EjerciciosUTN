namespace Forms
{
    partial class FrmMenu
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
            btnFacturacionLocal = new Button();
            btnGenerarLlamada = new Button();
            btnFacturacionTotal = new Button();
            acturacionProvincial = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnFacturacionLocal
            // 
            btnFacturacionLocal.Location = new Point(12, 118);
            btnFacturacionLocal.Name = "btnFacturacionLocal";
            btnFacturacionLocal.Size = new Size(199, 47);
            btnFacturacionLocal.TabIndex = 0;
            btnFacturacionLocal.Text = "Facturación Local";
            btnFacturacionLocal.UseVisualStyleBackColor = true;
            btnFacturacionLocal.Click += btnFacturacionLocal_Click;
            // 
            // btnGenerarLlamada
            // 
            btnGenerarLlamada.Location = new Point(12, 12);
            btnGenerarLlamada.Name = "btnGenerarLlamada";
            btnGenerarLlamada.Size = new Size(199, 47);
            btnGenerarLlamada.TabIndex = 1;
            btnGenerarLlamada.Text = "Generar Llamada";
            btnGenerarLlamada.UseVisualStyleBackColor = true;
            btnGenerarLlamada.Click += btnGenerarLlamada_Click;
            // 
            // btnFacturacionTotal
            // 
            btnFacturacionTotal.Location = new Point(12, 65);
            btnFacturacionTotal.Name = "btnFacturacionTotal";
            btnFacturacionTotal.Size = new Size(199, 47);
            btnFacturacionTotal.TabIndex = 2;
            btnFacturacionTotal.Text = "Facturación Total";
            btnFacturacionTotal.UseVisualStyleBackColor = true;
            btnFacturacionTotal.Click += btnFacturacionTotal_Click;
            // 
            // acturacionProvincial
            // 
            acturacionProvincial.Location = new Point(12, 171);
            acturacionProvincial.Name = "acturacionProvincial";
            acturacionProvincial.Size = new Size(199, 47);
            acturacionProvincial.TabIndex = 3;
            acturacionProvincial.Text = "Facturación Provincial";
            acturacionProvincial.UseVisualStyleBackColor = true;
            acturacionProvincial.Click += acturacionProvincial_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 224);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(199, 47);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 282);
            Controls.Add(btnSalir);
            Controls.Add(acturacionProvincial);
            Controls.Add(btnFacturacionTotal);
            Controls.Add(btnGenerarLlamada);
            Controls.Add(btnFacturacionLocal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Central Telefónica";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFacturacionLocal;
        private Button btnGenerarLlamada;
        private Button btnFacturacionTotal;
        private Button acturacionProvincial;
        private Button btnSalir;
    }
}