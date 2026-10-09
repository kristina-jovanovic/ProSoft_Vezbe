namespace WinFormsApp
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            btnPrikazi = new Button();
            label3 = new Label();
            txtIme = new TextBox();
            txtDatumRodj = new TextBox();
            cbPol = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 38);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "Ime i prezime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 95);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 1;
            label2.Text = "Datum rodjenja:";
            // 
            // btnPrikazi
            // 
            btnPrikazi.Location = new Point(49, 231);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(348, 34);
            btnPrikazi.TabIndex = 2;
            btnPrikazi.Text = "Prikazi podatke";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 156);
            label3.Name = "label3";
            label3.Size = new Size(40, 25);
            label3.TabIndex = 3;
            label3.Text = "Pol:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(215, 35);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(182, 31);
            txtIme.TabIndex = 4;
            // 
            // txtDatumRodj
            // 
            txtDatumRodj.Location = new Point(215, 92);
            txtDatumRodj.Name = "txtDatumRodj";
            txtDatumRodj.Size = new Size(182, 31);
            txtDatumRodj.TabIndex = 5;
            // 
            // cbPol
            // 
            cbPol.FormattingEnabled = true;
            cbPol.Location = new Point(215, 153);
            cbPol.Name = "cbPol";
            cbPol.Size = new Size(182, 33);
            cbPol.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(468, 35);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 348);
            Controls.Add(monthCalendar1);
            Controls.Add(cbPol);
            Controls.Add(txtDatumRodj);
            Controls.Add(txtIme);
            Controls.Add(label3);
            Controls.Add(btnPrikazi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnPrikazi;
        private Label label3;
        private TextBox txtIme;
        private TextBox txtDatumRodj;
        private ComboBox cbPol;
        private MonthCalendar monthCalendar1;
    }
}
