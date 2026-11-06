namespace WinFormsApp
{
    partial class FrmIzmeniOsobe
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
            dgvOsobe = new DataGridView();
            btnSacuvaj = new Button();
            btnObrisi = new Button();
            btnDodaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOsobe).BeginInit();
            SuspendLayout();
            // 
            // dgvOsobe
            // 
            dgvOsobe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOsobe.Location = new Point(36, 54);
            dgvOsobe.Name = "dgvOsobe";
            dgvOsobe.Size = new Size(728, 353);
            dgvOsobe.TabIndex = 7;
            dgvOsobe.CellEndEdit += dgvOsobe_CellEndEdit;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(676, 413);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(88, 23);
            btnSacuvaj.TabIndex = 6;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(143, 15);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(75, 23);
            btnObrisi.TabIndex = 5;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(36, 15);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // FrmIzmeniOsobe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvOsobe);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodaj);
            Name = "FrmIzmeniOsobe";
            Text = "FrmIzmeniOsobe";
            ((System.ComponentModel.ISupportInitialize)dgvOsobe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOsobe;
        private Button btnSacuvaj;
        private Button btnObrisi;
        private Button btnDodaj;
    }
}