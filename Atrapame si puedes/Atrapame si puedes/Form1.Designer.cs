namespace Atrapame_si_puedes
{
    partial class Form1
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
            txtKilometros = new TextBox();
            txtLitros = new TextBox();
            lblKilometros = new Label();
            lblLitros = new Label();
            btnCalcular = new Button();
            rchCalculador = new RichTextBox();
            SuspendLayout();
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(12, 27);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(119, 23);
            txtKilometros.TabIndex = 0;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(12, 99);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(119, 23);
            txtLitros.TabIndex = 1;
            // 
            // lblKilometros
            // 
            lblKilometros.AutoSize = true;
            lblKilometros.Location = new Point(12, 9);
            lblKilometros.Name = "lblKilometros";
            lblKilometros.Size = new Size(64, 15);
            lblKilometros.TabIndex = 2;
            lblKilometros.Text = "Kilómetros";
            // 
            // lblLitros
            // 
            lblLitros.AutoSize = true;
            lblLitros.Location = new Point(12, 81);
            lblLitros.Name = "lblLitros";
            lblLitros.Size = new Size(36, 15);
            lblLitros.TabIndex = 3;
            lblLitros.Text = "Litros";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 143);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(119, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // rchCalculador
            // 
            rchCalculador.Location = new Point(156, 9);
            rchCalculador.Name = "rchCalculador";
            rchCalculador.ReadOnly = true;
            rchCalculador.Size = new Size(140, 157);
            rchCalculador.TabIndex = 5;
            rchCalculador.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 181);
            Controls.Add(rchCalculador);
            Controls.Add(btnCalcular);
            Controls.Add(lblLitros);
            Controls.Add(lblKilometros);
            Controls.Add(txtLitros);
            Controls.Add(txtKilometros);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculador";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKilometros;
        private TextBox txtLitros;
        private Label lblKilometros;
        private Label lblLitros;
        private Button btnCalcular;
        private RichTextBox rchCalculador;
    }
}