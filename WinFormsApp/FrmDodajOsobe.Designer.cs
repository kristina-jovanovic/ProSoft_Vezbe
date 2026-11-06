namespace WinFormsApp
{
    partial class FrmDodajOsobe
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
            btnDodaj = new Button();
            btnObrisi = new Button();
            btnSacuvaj = new Button();
            dgvOsobe = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOsobe).BeginInit();
            SuspendLayout();
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(43, 17);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 0;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(150, 17);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(75, 23);
            btnObrisi.TabIndex = 1;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(683, 415);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(88, 23);
            btnSacuvaj.TabIndex = 2;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // dgvOsobe
            // 
            dgvOsobe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOsobe.Location = new Point(43, 56);
            dgvOsobe.Name = "dgvOsobe";
            dgvOsobe.Size = new Size(728, 353);
            dgvOsobe.TabIndex = 3;
            // 
            // FrmDodajOsobe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvOsobe);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodaj);
            Name = "FrmDodajOsobe";
            Text = "FrmDodajOsobe";
            ((System.ComponentModel.ISupportInitialize)dgvOsobe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDodaj;
        private Button btnObrisi;
        private Button btnSacuvaj;
        private DataGridView dgvOsobe;
    }
}