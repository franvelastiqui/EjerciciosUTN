namespace FormCotizador
{
    partial class frmConversor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversor));
            lblEuroA = new Label();
            lblCotizacion = new Label();
            txtEuro = new TextBox();
            txtDolar = new TextBox();
            lblDolarA = new Label();
            txtPeso = new TextBox();
            lblPesoA = new Label();
            btnEuroA = new Button();
            btnDolarA = new Button();
            btnPesoA = new Button();
            txtCotEuro = new TextBox();
            txtCotDolar = new TextBox();
            lblEuro = new Label();
            txtEuroEuro = new TextBox();
            txtDolarEuro = new TextBox();
            txtPesoEuro = new TextBox();
            lblDolar = new Label();
            txtEuroDolar = new TextBox();
            txtDolarDolar = new TextBox();
            txtPesoDolar = new TextBox();
            label1 = new Label();
            txtEuroPeso = new TextBox();
            txtDolarPeso = new TextBox();
            txtPesoPeso = new TextBox();
            btnCotizador = new Button();
            imagenes = new ImageList(components);
            txtCotPeso = new TextBox();
            SuspendLayout();
            // 
            // lblEuroA
            // 
            lblEuroA.AutoSize = true;
            lblEuroA.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEuroA.Location = new Point(12, 73);
            lblEuroA.Name = "lblEuroA";
            lblEuroA.Size = new Size(39, 19);
            lblEuroA.TabIndex = 0;
            lblEuroA.Text = "Euro";
            // 
            // lblCotizacion
            // 
            lblCotizacion.AutoSize = true;
            lblCotizacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCotizacion.Location = new Point(85, 21);
            lblCotizacion.Name = "lblCotizacion";
            lblCotizacion.Size = new Size(79, 19);
            lblCotizacion.TabIndex = 1;
            lblCotizacion.Text = "Cotización";
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(85, 72);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(100, 23);
            txtEuro.TabIndex = 2;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(85, 104);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(100, 23);
            txtDolar.TabIndex = 4;
            // 
            // lblDolarA
            // 
            lblDolarA.AutoSize = true;
            lblDolarA.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDolarA.Location = new Point(12, 105);
            lblDolarA.Name = "lblDolarA";
            lblDolarA.Size = new Size(46, 19);
            lblDolarA.TabIndex = 3;
            lblDolarA.Text = "Dólar";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(85, 138);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 6;
            // 
            // lblPesoA
            // 
            lblPesoA.AutoSize = true;
            lblPesoA.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPesoA.Location = new Point(12, 139);
            lblPesoA.Name = "lblPesoA";
            lblPesoA.Size = new Size(41, 19);
            lblPesoA.TabIndex = 5;
            lblPesoA.Text = "Peso";
            // 
            // btnEuroA
            // 
            btnEuroA.Location = new Point(191, 71);
            btnEuroA.Name = "btnEuroA";
            btnEuroA.Size = new Size(75, 23);
            btnEuroA.TabIndex = 7;
            btnEuroA.Text = "->";
            btnEuroA.UseVisualStyleBackColor = true;
            btnEuroA.Click += btnEuroA_Click;
            // 
            // btnDolarA
            // 
            btnDolarA.Location = new Point(191, 103);
            btnDolarA.Name = "btnDolarA";
            btnDolarA.Size = new Size(75, 23);
            btnDolarA.TabIndex = 8;
            btnDolarA.Text = "->";
            btnDolarA.UseVisualStyleBackColor = true;
            btnDolarA.Click += btnDolarA_Click;
            // 
            // btnPesoA
            // 
            btnPesoA.Location = new Point(191, 138);
            btnPesoA.Name = "btnPesoA";
            btnPesoA.Size = new Size(75, 23);
            btnPesoA.TabIndex = 9;
            btnPesoA.Text = "->";
            btnPesoA.UseVisualStyleBackColor = true;
            btnPesoA.Click += btnPesoA_Click;
            // 
            // txtCotEuro
            // 
            txtCotEuro.Location = new Point(290, 19);
            txtCotEuro.Name = "txtCotEuro";
            txtCotEuro.Size = new Size(100, 23);
            txtCotEuro.TabIndex = 11;
            txtCotEuro.TextChanged += txtCotEuro_TextChanged;
            // 
            // txtCotDolar
            // 
            txtCotDolar.Location = new Point(396, 19);
            txtCotDolar.Name = "txtCotDolar";
            txtCotDolar.Size = new Size(100, 23);
            txtCotDolar.TabIndex = 12;
            txtCotDolar.Leave += txtCotDolar_Leave;
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEuro.Location = new Point(317, 49);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(39, 19);
            lblEuro.TabIndex = 14;
            lblEuro.Text = "Euro";
            // 
            // txtEuroEuro
            // 
            txtEuroEuro.Location = new Point(290, 71);
            txtEuroEuro.Name = "txtEuroEuro";
            txtEuroEuro.Size = new Size(100, 23);
            txtEuroEuro.TabIndex = 15;
            // 
            // txtDolarEuro
            // 
            txtDolarEuro.Location = new Point(290, 104);
            txtDolarEuro.Name = "txtDolarEuro";
            txtDolarEuro.Size = new Size(100, 23);
            txtDolarEuro.TabIndex = 16;
            // 
            // txtPesoEuro
            // 
            txtPesoEuro.Location = new Point(290, 138);
            txtPesoEuro.Name = "txtPesoEuro";
            txtPesoEuro.Size = new Size(100, 23);
            txtPesoEuro.TabIndex = 17;
            // 
            // lblDolar
            // 
            lblDolar.AutoSize = true;
            lblDolar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDolar.Location = new Point(419, 49);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(46, 19);
            lblDolar.TabIndex = 18;
            lblDolar.Text = "Dólar";
            // 
            // txtEuroDolar
            // 
            txtEuroDolar.Location = new Point(396, 71);
            txtEuroDolar.Name = "txtEuroDolar";
            txtEuroDolar.Size = new Size(100, 23);
            txtEuroDolar.TabIndex = 19;
            // 
            // txtDolarDolar
            // 
            txtDolarDolar.Location = new Point(396, 104);
            txtDolarDolar.Name = "txtDolarDolar";
            txtDolarDolar.Size = new Size(100, 23);
            txtDolarDolar.TabIndex = 20;
            // 
            // txtPesoDolar
            // 
            txtPesoDolar.Location = new Point(396, 138);
            txtPesoDolar.Name = "txtPesoDolar";
            txtPesoDolar.Size = new Size(100, 23);
            txtPesoDolar.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(529, 49);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 22;
            label1.Text = "Peso";
            // 
            // txtEuroPeso
            // 
            txtEuroPeso.Location = new Point(502, 71);
            txtEuroPeso.Name = "txtEuroPeso";
            txtEuroPeso.Size = new Size(100, 23);
            txtEuroPeso.TabIndex = 23;
            // 
            // txtDolarPeso
            // 
            txtDolarPeso.Location = new Point(502, 104);
            txtDolarPeso.Name = "txtDolarPeso";
            txtDolarPeso.Size = new Size(100, 23);
            txtDolarPeso.TabIndex = 24;
            // 
            // txtPesoPeso
            // 
            txtPesoPeso.Location = new Point(502, 138);
            txtPesoPeso.Name = "txtPesoPeso";
            txtPesoPeso.Size = new Size(100, 23);
            txtPesoPeso.TabIndex = 25;
            // 
            // btnCotizador
            // 
            btnCotizador.ImageIndex = 0;
            btnCotizador.ImageList = imagenes;
            btnCotizador.Location = new Point(191, 21);
            btnCotizador.Name = "btnCotizador";
            btnCotizador.Size = new Size(75, 23);
            btnCotizador.TabIndex = 26;
            btnCotizador.UseVisualStyleBackColor = true;
            btnCotizador.Click += btnCotizador_Click;
            // 
            // imagenes
            // 
            imagenes.ColorDepth = ColorDepth.Depth8Bit;
            imagenes.ImageStream = (ImageListStreamer)resources.GetObject("imagenes.ImageStream");
            imagenes.TransparentColor = Color.Transparent;
            imagenes.Images.SetKeyName(0, "cerrado.png");
            imagenes.Images.SetKeyName(1, "abierto.png");
            // 
            // txtCotPeso
            // 
            txtCotPeso.Location = new Point(502, 19);
            txtCotPeso.Name = "txtCotPeso";
            txtCotPeso.Size = new Size(100, 23);
            txtCotPeso.TabIndex = 27;
            txtCotPeso.TextChanged += txtCotPeso_TextChanged;
            // 
            // frmConversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 175);
            Controls.Add(txtCotPeso);
            Controls.Add(btnCotizador);
            Controls.Add(txtPesoPeso);
            Controls.Add(txtDolarPeso);
            Controls.Add(txtEuroPeso);
            Controls.Add(label1);
            Controls.Add(txtPesoDolar);
            Controls.Add(txtDolarDolar);
            Controls.Add(txtEuroDolar);
            Controls.Add(lblDolar);
            Controls.Add(txtPesoEuro);
            Controls.Add(txtDolarEuro);
            Controls.Add(txtEuroEuro);
            Controls.Add(lblEuro);
            Controls.Add(txtCotDolar);
            Controls.Add(txtCotEuro);
            Controls.Add(btnPesoA);
            Controls.Add(btnDolarA);
            Controls.Add(btnEuroA);
            Controls.Add(txtPeso);
            Controls.Add(lblPesoA);
            Controls.Add(txtDolar);
            Controls.Add(lblDolarA);
            Controls.Add(txtEuro);
            Controls.Add(lblCotizacion);
            Controls.Add(lblEuroA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConversor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor";
            Load += frmConversor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEuroA;
        private Label lblCotizacion;
        private TextBox txtEuro;
        private TextBox txtDolar;
        private Label lblDolarA;
        private TextBox txtPeso;
        private Label lblPesoA;
        private Button btnEuroA;
        private Button btnDolarA;
        private Button btnPesoA;
        private TextBox txtCotEuro;
        private TextBox txtCotDolar;
        private Label lblEuro;
        private TextBox txtEuroEuro;
        private TextBox txtDolarEuro;
        private TextBox txtPesoEuro;
        private Label lblDolar;
        private TextBox txtEuroDolar;
        private TextBox txtDolarDolar;
        private TextBox txtPesoDolar;
        private Label label1;
        private TextBox txtEuroPeso;
        private TextBox txtDolarPeso;
        private TextBox txtPesoPeso;
        private Button btnCotizador;
        private ImageList imagenes;
        private TextBox txtCotPeso;
    }
}