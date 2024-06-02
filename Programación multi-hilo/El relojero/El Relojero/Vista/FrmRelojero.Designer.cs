namespace Vista
{
    partial class FrmRelojero
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
            richTextBox1 = new RichTextBox();
            lblHora = new Label();
            btnIniciar = new Button();
            btnDetener = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(12, 40);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(577, 223);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.Location = new Point(12, 9);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(217, 28);
            lblHora.TabIndex = 1;
            lblHora.Text = "dd/MM/YYYY hh:mm:ss";
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIniciar.Location = new Point(316, 9);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(133, 23);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar reloj";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDetener.Location = new Point(455, 9);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(133, 23);
            btnDetener.TabIndex = 3;
            btnDetener.Text = "Detener reloj";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // FrmRelojero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 275);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(lblHora);
            Controls.Add(richTextBox1);
            Name = "FrmRelojero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relojero";
            Load += FrmRelojero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label lblHora;
        private Button btnIniciar;
        private Button btnDetener;
    }
}