namespace Forms
{
    partial class FrmLlamador
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
            txtNroDestino = new TextBox();
            btn1 = new Button();
            grpPanel = new GroupBox();
            btnNum = new Button();
            btn0 = new Button();
            ntmAst = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btnLlamar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtNroOrigen = new TextBox();
            cmbFranja = new ComboBox();
            grpPanel.SuspendLayout();
            SuspendLayout();
            // 
            // txtNroDestino
            // 
            txtNroDestino.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtNroDestino.Location = new Point(12, 12);
            txtNroDestino.Name = "txtNroDestino";
            txtNroDestino.PlaceholderText = "Nro Destino";
            txtNroDestino.ReadOnly = true;
            txtNroDestino.Size = new Size(251, 36);
            txtNroDestino.TabIndex = 0;
            txtNroDestino.TextChanged += txtNroDestino_TextChanged;
            // 
            // btn1
            // 
            btn1.Location = new Point(6, 22);
            btn1.Name = "btn1";
            btn1.Size = new Size(30, 30);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // grpPanel
            // 
            grpPanel.Controls.Add(btnNum);
            grpPanel.Controls.Add(btn0);
            grpPanel.Controls.Add(ntmAst);
            grpPanel.Controls.Add(btn9);
            grpPanel.Controls.Add(btn8);
            grpPanel.Controls.Add(btn7);
            grpPanel.Controls.Add(btn6);
            grpPanel.Controls.Add(btn5);
            grpPanel.Controls.Add(btn4);
            grpPanel.Controls.Add(btn3);
            grpPanel.Controls.Add(btn2);
            grpPanel.Controls.Add(btn1);
            grpPanel.Location = new Point(12, 67);
            grpPanel.Name = "grpPanel";
            grpPanel.Size = new Size(118, 173);
            grpPanel.TabIndex = 2;
            grpPanel.TabStop = false;
            grpPanel.Text = "Panel";
            // 
            // btnNum
            // 
            btnNum.Location = new Point(78, 130);
            btnNum.Name = "btnNum";
            btnNum.Size = new Size(30, 30);
            btnNum.TabIndex = 12;
            btnNum.Text = "#";
            btnNum.UseVisualStyleBackColor = true;
            btnNum.Click += btnNum_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(42, 130);
            btn0.Name = "btn0";
            btn0.Size = new Size(30, 30);
            btn0.TabIndex = 11;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // ntmAst
            // 
            ntmAst.Location = new Point(6, 130);
            ntmAst.Name = "ntmAst";
            ntmAst.Size = new Size(30, 30);
            ntmAst.TabIndex = 10;
            ntmAst.Text = "*";
            ntmAst.UseVisualStyleBackColor = true;
            ntmAst.Click += ntmAst_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(78, 94);
            btn9.Name = "btn9";
            btn9.Size = new Size(30, 30);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(42, 94);
            btn8.Name = "btn8";
            btn8.Size = new Size(30, 30);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(6, 94);
            btn7.Name = "btn7";
            btn7.Size = new Size(30, 30);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(78, 58);
            btn6.Name = "btn6";
            btn6.Size = new Size(30, 30);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(42, 58);
            btn5.Name = "btn5";
            btn5.Size = new Size(30, 30);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(6, 58);
            btn4.Name = "btn4";
            btn4.Size = new Size(30, 30);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(78, 22);
            btn3.Name = "btn3";
            btn3.Size = new Size(30, 30);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(42, 22);
            btn2.Name = "btn2";
            btn2.Size = new Size(30, 30);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btnLlamar
            // 
            btnLlamar.Location = new Point(136, 89);
            btnLlamar.Name = "btnLlamar";
            btnLlamar.Size = new Size(127, 30);
            btnLlamar.TabIndex = 3;
            btnLlamar.Text = "Llamar";
            btnLlamar.UseVisualStyleBackColor = true;
            btnLlamar.Click += btnLlamar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(136, 125);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(127, 30);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(136, 197);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(127, 30);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtNroOrigen
            // 
            txtNroOrigen.Location = new Point(136, 166);
            txtNroOrigen.Name = "txtNroOrigen";
            txtNroOrigen.PlaceholderText = "Nro Origen";
            txtNroOrigen.Size = new Size(127, 23);
            txtNroOrigen.TabIndex = 6;
            // 
            // cmbFranja
            // 
            cmbFranja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFranja.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFranja.FormattingEnabled = true;
            cmbFranja.Location = new Point(12, 246);
            cmbFranja.Name = "cmbFranja";
            cmbFranja.Size = new Size(251, 29);
            cmbFranja.TabIndex = 7;
            // 
            // FrmLlamador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 289);
            Controls.Add(cmbFranja);
            Controls.Add(txtNroOrigen);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnLlamar);
            Controls.Add(grpPanel);
            Controls.Add(txtNroDestino);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmLlamador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Llamador";
            Load += FrmLlamador_Load;
            grpPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNroDestino;
        private Button btn1;
        private GroupBox grpPanel;
        private Button btnNum;
        private Button btn0;
        private Button ntmAst;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btnLlamar;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtNroOrigen;
        private ComboBox cmbFranja;
    }
}