namespace WinFormsApp
{
    partial class FrmPretragaOsoba
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
            panel1 = new Panel();
            btnPrikazi = new Button();
            panel2 = new Panel();
            dgvOsobe = new DataGridView();
            txtKriterijumPretrage = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOsobe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtKriterijumPretrage);
            panel1.Controls.Add(btnPrikazi);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 0;
            // 
            // btnPrikazi
            // 
            btnPrikazi.Location = new Point(12, 386);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(231, 29);
            btnPrikazi.TabIndex = 0;
            btnPrikazi.Text = "Prikazi detalje";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvOsobe);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 450);
            panel2.TabIndex = 1;
            // 
            // dgvOsobe
            // 
            dgvOsobe.AllowUserToAddRows = false;
            dgvOsobe.AllowUserToDeleteRows = false;
            dgvOsobe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOsobe.Dock = DockStyle.Fill;
            dgvOsobe.Location = new Point(0, 0);
            dgvOsobe.Name = "dgvOsobe";
            dgvOsobe.ReadOnly = true;
            dgvOsobe.RowHeadersWidth = 51;
            dgvOsobe.Size = new Size(550, 450);
            dgvOsobe.TabIndex = 0;
            // 
            // txtKriterijumPretrage
            // 
            txtKriterijumPretrage.Location = new Point(12, 33);
            txtKriterijumPretrage.Name = "txtKriterijumPretrage";
            txtKriterijumPretrage.Size = new Size(231, 27);
            txtKriterijumPretrage.TabIndex = 1;
            txtKriterijumPretrage.TextChanged += txtKriterijumPretrage_TextChanged;
            // 
            // FrmPretragaOsoba
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmPretragaOsoba";
            Text = "FrmPretragaOsoba";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOsobe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvOsobe;
        private Button btnPrikazi;
        private TextBox txtKriterijumPretrage;
    }
}