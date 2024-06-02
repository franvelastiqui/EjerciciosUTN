namespace Vista
{
    partial class FrmHilos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected async override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            while(!hilos.All(h => h.IsCanceled || h.IsCompleted))
            {
                await Task.Delay(100);
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
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            progressBar2 = new ProgressBar();
            label3 = new Label();
            progressBar3 = new ProgressBar();
            label4 = new Label();
            progressBar4 = new ProgressBar();
            btnCancelar = new Button();
            btnVerInfo = new Button();
            btnReiniciar = new Button();
            btnMostrar = new Button();
            txtMostrar = new TextBox();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(625, 36);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "No iniciado - 0%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 129);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "No iniciado - 0%";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(12, 90);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(625, 36);
            progressBar2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 214);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 5;
            label3.Text = "No iniciado - 0%";
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(12, 175);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(625, 36);
            progressBar3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 297);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 7;
            label4.Text = "No iniciado - 0%";
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(12, 258);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(625, 36);
            progressBar4.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(562, 362);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVerInfo
            // 
            btnVerInfo.Location = new Point(481, 362);
            btnVerInfo.Name = "btnVerInfo";
            btnVerInfo.Size = new Size(75, 23);
            btnVerInfo.TabIndex = 9;
            btnVerInfo.Text = "Ver Info";
            btnVerInfo.UseVisualStyleBackColor = true;
            btnVerInfo.Click += btnVerInfo_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(400, 362);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(75, 23);
            btnReiniciar.TabIndex = 10;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(215, 362);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 11;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // txtMostrar
            // 
            txtMostrar.Location = new Point(12, 362);
            txtMostrar.Name = "txtMostrar";
            txtMostrar.Size = new Size(197, 23);
            txtMostrar.TabIndex = 12;
            // 
            // FrmHilos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 397);
            Controls.Add(txtMostrar);
            Controls.Add(btnMostrar);
            Controls.Add(btnReiniciar);
            Controls.Add(btnVerInfo);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(progressBar4);
            Controls.Add(label3);
            Controls.Add(progressBar3);
            Controls.Add(label2);
            Controls.Add(progressBar2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmHilos";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += FrmHilos_FormClosing;
            Load += FrmHilos_Load;
            Paint += FrmHilos_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar2;
        private Label label3;
        private ProgressBar progressBar3;
        private Label label4;
        private ProgressBar progressBar4;
        private Button btnCancelar;
        private Button btnVerInfo;
        private Button btnReiniciar;
        private Button btnMostrar;
        private TextBox txtMostrar;
    }
}