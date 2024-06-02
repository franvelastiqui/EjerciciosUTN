namespace Registrate
{
    partial class frmRegistro
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
            lblNombre = new Label();
            lblDireccion = new Label();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            lblEdad = new Label();
            nupEdad = new NumericUpDown();
            gbDatosUsuario = new GroupBox();
            gbGenero = new GroupBox();
            rbNonB = new RadioButton();
            rbFem = new RadioButton();
            rbMasc = new RadioButton();
            gbCursos = new GroupBox();
            cbJavaScript = new CheckBox();
            cbCsharp = new CheckBox();
            cbCplusplus = new CheckBox();
            lstbPaises = new ListBox();
            lblPais = new Label();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)nupEdad).BeginInit();
            gbDatosUsuario.SuspendLayout();
            gbGenero.SuspendLayout();
            gbCursos.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(15, 59);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Dirección";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(74, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(74, 56);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(120, 23);
            txtDireccion.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(15, 94);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            // 
            // nupEdad
            // 
            nupEdad.Location = new Point(74, 92);
            nupEdad.Name = "nupEdad";
            nupEdad.Size = new Size(120, 23);
            nupEdad.TabIndex = 5;
            // 
            // gbDatosUsuario
            // 
            gbDatosUsuario.Controls.Add(lblNombre);
            gbDatosUsuario.Controls.Add(nupEdad);
            gbDatosUsuario.Controls.Add(lblDireccion);
            gbDatosUsuario.Controls.Add(txtDireccion);
            gbDatosUsuario.Controls.Add(lblEdad);
            gbDatosUsuario.Controls.Add(txtNombre);
            gbDatosUsuario.Location = new Point(27, 23);
            gbDatosUsuario.Name = "gbDatosUsuario";
            gbDatosUsuario.Size = new Size(216, 131);
            gbDatosUsuario.TabIndex = 6;
            gbDatosUsuario.TabStop = false;
            gbDatosUsuario.Text = "Detalles del usuario";
            // 
            // gbGenero
            // 
            gbGenero.Controls.Add(rbNonB);
            gbGenero.Controls.Add(rbFem);
            gbGenero.Controls.Add(rbMasc);
            gbGenero.Location = new Point(287, 23);
            gbGenero.Name = "gbGenero";
            gbGenero.Size = new Size(132, 109);
            gbGenero.TabIndex = 7;
            gbGenero.TabStop = false;
            gbGenero.Text = "Género";
            // 
            // rbNonB
            // 
            rbNonB.AutoSize = true;
            rbNonB.Location = new Point(17, 72);
            rbNonB.Name = "rbNonB";
            rbNonB.Size = new Size(81, 19);
            rbNonB.TabIndex = 2;
            rbNonB.TabStop = true;
            rbNonB.Text = "No binario";
            rbNonB.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            rbFem.AutoSize = true;
            rbFem.Location = new Point(17, 47);
            rbFem.Name = "rbFem";
            rbFem.Size = new Size(78, 19);
            rbFem.TabIndex = 1;
            rbFem.TabStop = true;
            rbFem.Text = "Femenino";
            rbFem.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            rbMasc.AutoSize = true;
            rbMasc.Location = new Point(17, 22);
            rbMasc.Name = "rbMasc";
            rbMasc.Size = new Size(80, 19);
            rbMasc.TabIndex = 0;
            rbMasc.TabStop = true;
            rbMasc.Text = "Masculino";
            rbMasc.UseVisualStyleBackColor = true;
            // 
            // gbCursos
            // 
            gbCursos.Controls.Add(cbJavaScript);
            gbCursos.Controls.Add(cbCsharp);
            gbCursos.Controls.Add(cbCplusplus);
            gbCursos.Location = new Point(287, 149);
            gbCursos.Name = "gbCursos";
            gbCursos.Size = new Size(132, 109);
            gbCursos.TabIndex = 8;
            gbCursos.TabStop = false;
            gbCursos.Text = "Cursos";
            // 
            // cbJavaScript
            // 
            cbJavaScript.AutoSize = true;
            cbJavaScript.Location = new Point(20, 72);
            cbJavaScript.Name = "cbJavaScript";
            cbJavaScript.Size = new Size(78, 19);
            cbJavaScript.TabIndex = 2;
            cbJavaScript.Text = "JavaScript";
            cbJavaScript.UseVisualStyleBackColor = true;
            // 
            // cbCsharp
            // 
            cbCsharp.AutoSize = true;
            cbCsharp.Location = new Point(20, 23);
            cbCsharp.Name = "cbCsharp";
            cbCsharp.Size = new Size(41, 19);
            cbCsharp.TabIndex = 0;
            cbCsharp.Text = "C#";
            cbCsharp.UseVisualStyleBackColor = true;
            // 
            // cbCplusplus
            // 
            cbCplusplus.AutoSize = true;
            cbCplusplus.Location = new Point(20, 47);
            cbCplusplus.Name = "cbCplusplus";
            cbCplusplus.Size = new Size(50, 19);
            cbCplusplus.TabIndex = 1;
            cbCplusplus.Text = "C++";
            cbCplusplus.UseVisualStyleBackColor = true;
            // 
            // lstbPaises
            // 
            lstbPaises.FormattingEnabled = true;
            lstbPaises.ItemHeight = 15;
            lstbPaises.Location = new Point(27, 193);
            lstbPaises.Name = "lstbPaises";
            lstbPaises.Size = new Size(216, 109);
            lstbPaises.TabIndex = 9;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(27, 175);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 10;
            lblPais.Text = "País";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(304, 279);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(115, 23);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 325);
            Controls.Add(btnIngresar);
            Controls.Add(lblPais);
            Controls.Add(lstbPaises);
            Controls.Add(gbCursos);
            Controls.Add(gbGenero);
            Controls.Add(gbDatosUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += frmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)nupEdad).EndInit();
            gbDatosUsuario.ResumeLayout(false);
            gbDatosUsuario.PerformLayout();
            gbGenero.ResumeLayout(false);
            gbGenero.PerformLayout();
            gbCursos.ResumeLayout(false);
            gbCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblDireccion;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private Label lblEdad;
        private NumericUpDown nupEdad;
        private GroupBox gbDatosUsuario;
        private GroupBox gbGenero;
        private RadioButton rbNonB;
        private RadioButton rbFem;
        private RadioButton rbMasc;
        private GroupBox gbCursos;
        private CheckBox cbJavaScript;
        private CheckBox cbCplusplus;
        private CheckBox cbCsharp;
        private ListBox lstbPaises;
        private Label lblPais;
        private Button btnIngresar;
    }
}