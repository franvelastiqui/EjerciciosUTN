namespace NotepadProyecto
{
    partial class frmNotepad
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
            mnstMenu = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            sstStatus = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            rtbTexto = new RichTextBox();
            mnstMenu.SuspendLayout();
            sstStatus.SuspendLayout();
            SuspendLayout();
            // 
            // mnstMenu
            // 
            mnstMenu.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            mnstMenu.Location = new Point(0, 0);
            mnstMenu.Name = "mnstMenu";
            mnstMenu.Size = new Size(707, 24);
            mnstMenu.TabIndex = 0;
            mnstMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            abrirToolStripMenuItem.Size = new Size(269, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            guardarToolStripMenuItem.Size = new Size(269, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            guardarComoToolStripMenuItem.Size = new Size(269, 22);
            guardarComoToolStripMenuItem.Text = "Guardar como...";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // sstStatus
            // 
            sstStatus.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            sstStatus.Location = new Point(0, 323);
            sstStatus.Name = "sstStatus";
            sstStatus.Size = new Size(707, 22);
            sstStatus.TabIndex = 1;
            sstStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(118, 17);
            toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // rtbTexto
            // 
            rtbTexto.Dock = DockStyle.Fill;
            rtbTexto.Location = new Point(0, 24);
            rtbTexto.Name = "rtbTexto";
            rtbTexto.Size = new Size(707, 299);
            rtbTexto.TabIndex = 2;
            rtbTexto.Text = "";
            rtbTexto.TextChanged += rtbTexto_TextChanged;
            // 
            // frmNotepad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 345);
            Controls.Add(rtbTexto);
            Controls.Add(sstStatus);
            Controls.Add(mnstMenu);
            MainMenuStrip = mnstMenu;
            Name = "frmNotepad";
            Text = "Notepad";
            Load += frmNotepad_Load;
            mnstMenu.ResumeLayout(false);
            mnstMenu.PerformLayout();
            sstStatus.ResumeLayout(false);
            sstStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnstMenu;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private StatusStrip sstStatus;
        private ToolStripStatusLabel toolStripStatusLabel;
        private RichTextBox rtbTexto;
    }
}