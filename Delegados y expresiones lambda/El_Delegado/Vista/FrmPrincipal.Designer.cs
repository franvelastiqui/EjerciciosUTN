﻿namespace Vista
{
    partial class FrmPrincipal
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
            menu = new MenuStrip();
            altaToolStripMenuItem = new ToolStripMenuItem();
            testDelegadosToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { altaToolStripMenuItem, mostrarToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 24);
            menu.TabIndex = 1;
            menu.Text = "menu";
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testDelegadosToolStripMenuItem, alumnosToolStripMenuItem });
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(40, 20);
            altaToolStripMenuItem.Text = "Alta";
            // 
            // testDelegadosToolStripMenuItem
            // 
            testDelegadosToolStripMenuItem.Name = "testDelegadosToolStripMenuItem";
            testDelegadosToolStripMenuItem.Size = new Size(152, 22);
            testDelegadosToolStripMenuItem.Text = "Test Delegados";
            testDelegadosToolStripMenuItem.Click += testDelegadosToolStripMenuItem_Click;
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(152, 22);
            alumnosToolStripMenuItem.Text = "Alumno";
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(60, 20);
            mostrarToolStripMenuItem.Text = "Mostrar";
            mostrarToolStripMenuItem.Click += mostrarToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menu);
            IsMdiContainer = true;
            MainMenuStrip = menu;
            Name = "FrmPrincipal";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem testDelegadosToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem mostrarToolStripMenuItem;
    }
}