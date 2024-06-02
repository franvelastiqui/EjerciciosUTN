namespace InterfazPokedex
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            rdbAsh = new RadioButton();
            rdbBrock = new RadioButton();
            rdbMisty = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 183, 3);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.FromArgb(0, 53, 102);
            btnLogin.Location = new Point(139, 174);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(127, 38);
            btnLogin.TabIndex = 56;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(27, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 74);
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(151, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 74);
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(271, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(93, 74);
            pictureBox3.TabIndex = 59;
            pictureBox3.TabStop = false;
            // 
            // rdbAsh
            // 
            rdbAsh.AutoSize = true;
            rdbAsh.Checked = true;
            rdbAsh.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            rdbAsh.ForeColor = Color.FromArgb(255, 183, 3);
            rdbAsh.Location = new Point(40, 120);
            rdbAsh.Name = "rdbAsh";
            rdbAsh.Size = new Size(62, 29);
            rdbAsh.TabIndex = 60;
            rdbAsh.TabStop = true;
            rdbAsh.Text = "Ash";
            rdbAsh.UseVisualStyleBackColor = true;
            // 
            // rdbBrock
            // 
            rdbBrock.AutoSize = true;
            rdbBrock.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            rdbBrock.ForeColor = Color.FromArgb(255, 183, 3);
            rdbBrock.Location = new Point(161, 120);
            rdbBrock.Name = "rdbBrock";
            rdbBrock.Size = new Size(79, 29);
            rdbBrock.TabIndex = 61;
            rdbBrock.TabStop = true;
            rdbBrock.Text = "Brock";
            rdbBrock.UseVisualStyleBackColor = true;
            // 
            // rdbMisty
            // 
            rdbMisty.AutoSize = true;
            rdbMisty.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            rdbMisty.ForeColor = Color.FromArgb(255, 183, 3);
            rdbMisty.Location = new Point(283, 120);
            rdbMisty.Name = "rdbMisty";
            rdbMisty.Size = new Size(77, 29);
            rdbMisty.TabIndex = 62;
            rdbMisty.TabStop = true;
            rdbMisty.Text = "Misty";
            rdbMisty.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(396, 240);
            Controls.Add(rdbMisty);
            Controls.Add(rdbBrock);
            Controls.Add(rdbAsh);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton rdbAsh;
        private System.Windows.Forms.RadioButton rdbBrock;
        private System.Windows.Forms.RadioButton rdbMisty;
    }
}