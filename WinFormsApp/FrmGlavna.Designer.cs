namespace WinFormsApp
{
    partial class FrmGlavna
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
            menuStrip1 = new MenuStrip();
            osobeToolStripMenuItem = new ToolStripMenuItem();
            kreirajOsobuToolStripMenuItem = new ToolStripMenuItem();
            pretragaOsobaToolStripMenuItem = new ToolStripMenuItem();
            dodajOsobeToolStripMenuItem = new ToolStripMenuItem();
            izmeniOsobeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { osobeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // osobeToolStripMenuItem
            // 
            osobeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kreirajOsobuToolStripMenuItem, pretragaOsobaToolStripMenuItem, dodajOsobeToolStripMenuItem, izmeniOsobeToolStripMenuItem });
            osobeToolStripMenuItem.Name = "osobeToolStripMenuItem";
            osobeToolStripMenuItem.Size = new Size(53, 20);
            osobeToolStripMenuItem.Text = "Osobe";
            // 
            // kreirajOsobuToolStripMenuItem
            // 
            kreirajOsobuToolStripMenuItem.Name = "kreirajOsobuToolStripMenuItem";
            kreirajOsobuToolStripMenuItem.Size = new Size(180, 22);
            kreirajOsobuToolStripMenuItem.Text = "Kreiraj osobu";
            kreirajOsobuToolStripMenuItem.Click += kreirajOsobuToolStripMenuItem_Click;
            // 
            // pretragaOsobaToolStripMenuItem
            // 
            pretragaOsobaToolStripMenuItem.Name = "pretragaOsobaToolStripMenuItem";
            pretragaOsobaToolStripMenuItem.Size = new Size(180, 22);
            pretragaOsobaToolStripMenuItem.Text = "Pretraga osoba";
            pretragaOsobaToolStripMenuItem.Click += pretragaOsobaToolStripMenuItem_Click;
            // 
            // dodajOsobeToolStripMenuItem
            // 
            dodajOsobeToolStripMenuItem.Name = "dodajOsobeToolStripMenuItem";
            dodajOsobeToolStripMenuItem.Size = new Size(180, 22);
            dodajOsobeToolStripMenuItem.Text = "Dodaj osobe";
            dodajOsobeToolStripMenuItem.Click += dodajOsobeToolStripMenuItem_Click;
            // 
            // izmeniOsobeToolStripMenuItem
            // 
            izmeniOsobeToolStripMenuItem.Name = "izmeniOsobeToolStripMenuItem";
            izmeniOsobeToolStripMenuItem.Size = new Size(180, 22);
            izmeniOsobeToolStripMenuItem.Text = "Izmeni osobe";
            izmeniOsobeToolStripMenuItem.Click += izmeniOsobeToolStripMenuItem_Click;
            // 
            // FrmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmGlavna";
            Text = "FrmGlavna";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem osobeToolStripMenuItem;
        private ToolStripMenuItem kreirajOsobuToolStripMenuItem;
        private ToolStripMenuItem pretragaOsobaToolStripMenuItem;
        private ToolStripMenuItem dodajOsobeToolStripMenuItem;
        private ToolStripMenuItem izmeniOsobeToolStripMenuItem;
    }
}