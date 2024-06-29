namespace LN_Editor
{
    partial class form_start
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dateienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menue_info = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menue_laden = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menue_speichern = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menue_speichern_unter = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menue_beenden = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menue_suchen = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateienToolStripMenuItem,
            this.toolStripMenuItem2,
            this.btn_menue_info});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(601, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dateienToolStripMenuItem
            // 
            this.dateienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_menue_laden,
            this.btn_menue_speichern,
            this.btn_menue_speichern_unter,
            this.btn_menue_beenden});
            this.dateienToolStripMenuItem.Name = "dateienToolStripMenuItem";
            this.dateienToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.dateienToolStripMenuItem.Text = "&Dateien";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_menue_suchen});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(75, 20);
            this.toolStripMenuItem2.Text = "Bearbeiten";
            // 
            // btn_menue_info
            // 
            this.btn_menue_info.Name = "btn_menue_info";
            this.btn_menue_info.Size = new System.Drawing.Size(24, 20);
            this.btn_menue_info.Text = "&?";
            // 
            // btn_menue_laden
            // 
            this.btn_menue_laden.Name = "btn_menue_laden";
            this.btn_menue_laden.Size = new System.Drawing.Size(180, 22);
            this.btn_menue_laden.Text = "&Laden";
            this.btn_menue_laden.Click += new System.EventHandler(this.btn_menue_laden_Click);
            // 
            // btn_menue_speichern
            // 
            this.btn_menue_speichern.Name = "btn_menue_speichern";
            this.btn_menue_speichern.Size = new System.Drawing.Size(180, 22);
            this.btn_menue_speichern.Text = "&Speichern";
            this.btn_menue_speichern.Click += new System.EventHandler(this.btn_menue_speichern_Click);
            // 
            // btn_menue_speichern_unter
            // 
            this.btn_menue_speichern_unter.Name = "btn_menue_speichern_unter";
            this.btn_menue_speichern_unter.Size = new System.Drawing.Size(180, 22);
            this.btn_menue_speichern_unter.Text = "&Speichern unter";
            this.btn_menue_speichern_unter.Click += new System.EventHandler(this.btn_menue_speichern_unter_Click);
            // 
            // btn_menue_beenden
            // 
            this.btn_menue_beenden.Name = "btn_menue_beenden";
            this.btn_menue_beenden.Size = new System.Drawing.Size(180, 22);
            this.btn_menue_beenden.Text = "&Beenden";
            this.btn_menue_beenden.Click += new System.EventHandler(this.btn_menue_beenden_Click);
            // 
            // btn_menue_suchen
            // 
            this.btn_menue_suchen.Name = "btn_menue_suchen";
            this.btn_menue_suchen.Size = new System.Drawing.Size(180, 22);
            this.btn_menue_suchen.Text = "&Suchen";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(601, 445);
            this.textBox1.TabIndex = 1;
            // 
            // form_start
            // 
            this.ClientSize = new System.Drawing.Size(601, 469);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "form_start";
            this.Text = "LN_Editor";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suchenToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dateienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_menue_laden;
        private System.Windows.Forms.ToolStripMenuItem btn_menue_speichern;
        private System.Windows.Forms.ToolStripMenuItem btn_menue_speichern_unter;
        private System.Windows.Forms.ToolStripMenuItem btn_menue_beenden;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btn_menue_suchen;
        private System.Windows.Forms.ToolStripMenuItem btn_menue_info;
        private System.Windows.Forms.TextBox textBox1;
    }
}

