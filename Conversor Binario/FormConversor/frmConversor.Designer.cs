namespace FormConversor
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
            lblBinario = new Label();
            lblDecimal = new Label();
            txtBinarioA = new TextBox();
            txtDecimalA = new TextBox();
            btnBinario = new Button();
            btnDecimalA = new Button();
            txtADecimal = new TextBox();
            txtABinario = new TextBox();
            SuspendLayout();
            // 
            // lblBinario
            // 
            lblBinario.AutoSize = true;
            lblBinario.Location = new Point(12, 30);
            lblBinario.Name = "lblBinario";
            lblBinario.Size = new Size(99, 15);
            lblBinario.TabIndex = 0;
            lblBinario.Text = "Binario a Decimal";
            // 
            // lblDecimal
            // 
            lblDecimal.AutoSize = true;
            lblDecimal.Location = new Point(12, 72);
            lblDecimal.Name = "lblDecimal";
            lblDecimal.Size = new Size(99, 15);
            lblDecimal.TabIndex = 1;
            lblDecimal.Text = "Decimal a Binario";
            // 
            // txtBinarioA
            // 
            txtBinarioA.Location = new Point(117, 27);
            txtBinarioA.Name = "txtBinarioA";
            txtBinarioA.Size = new Size(100, 23);
            txtBinarioA.TabIndex = 2;
            // 
            // txtDecimalA
            // 
            txtDecimalA.Location = new Point(117, 69);
            txtDecimalA.Name = "txtDecimalA";
            txtDecimalA.Size = new Size(100, 23);
            txtDecimalA.TabIndex = 3;
            // 
            // btnBinario
            // 
            btnBinario.Location = new Point(223, 27);
            btnBinario.Name = "btnBinario";
            btnBinario.Size = new Size(75, 23);
            btnBinario.TabIndex = 4;
            btnBinario.Text = "->";
            btnBinario.UseVisualStyleBackColor = true;
            btnBinario.Click += btnBinario_Click;
            // 
            // btnDecimalA
            // 
            btnDecimalA.Location = new Point(223, 69);
            btnDecimalA.Name = "btnDecimalA";
            btnDecimalA.Size = new Size(75, 23);
            btnDecimalA.TabIndex = 5;
            btnDecimalA.Text = "->";
            btnDecimalA.UseVisualStyleBackColor = true;
            btnDecimalA.Click += btnDecimalA_Click;
            // 
            // txtADecimal
            // 
            txtADecimal.Location = new Point(304, 27);
            txtADecimal.Name = "txtADecimal";
            txtADecimal.ReadOnly = true;
            txtADecimal.Size = new Size(100, 23);
            txtADecimal.TabIndex = 6;
            // 
            // txtABinario
            // 
            txtABinario.Location = new Point(304, 69);
            txtABinario.Name = "txtABinario";
            txtABinario.ReadOnly = true;
            txtABinario.Size = new Size(100, 23);
            txtABinario.TabIndex = 7;
            // 
            // frmConversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 110);
            Controls.Add(txtABinario);
            Controls.Add(txtADecimal);
            Controls.Add(btnDecimalA);
            Controls.Add(btnBinario);
            Controls.Add(txtDecimalA);
            Controls.Add(txtBinarioA);
            Controls.Add(lblDecimal);
            Controls.Add(lblBinario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmConversor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor Numérico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBinario;
        private Label lblDecimal;
        private TextBox txtBinarioA;
        private TextBox txtDecimalA;
        private Button btnBinario;
        private Button btnDecimalA;
        private TextBox txtADecimal;
        private TextBox txtABinario;
    }
}