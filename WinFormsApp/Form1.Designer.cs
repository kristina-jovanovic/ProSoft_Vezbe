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
            cbGrad = new ComboBox();
            label4 = new Label();
            lblOdabraniGrad = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime i prezime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 76);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Datum rodjenja:";
            // 
            // btnPrikazi
            // 
            btnPrikazi.Location = new Point(40, 243);
            btnPrikazi.Margin = new Padding(2);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(278, 27);
            btnPrikazi.TabIndex = 2;
            btnPrikazi.Text = "Prikazi podatke";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 125);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 3;
            label3.Text = "Pol:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(172, 28);
            txtIme.Margin = new Padding(2);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(146, 27);
            txtIme.TabIndex = 4;
            // 
            // txtDatumRodj
            // 
            txtDatumRodj.Location = new Point(172, 74);
            txtDatumRodj.Margin = new Padding(2);
            txtDatumRodj.Name = "txtDatumRodj";
            txtDatumRodj.Size = new Size(146, 27);
            txtDatumRodj.TabIndex = 5;
            // 
            // cbPol
            // 
            cbPol.FormattingEnabled = true;
            cbPol.Location = new Point(172, 122);
            cbPol.Margin = new Padding(2);
            cbPol.Name = "cbPol";
            cbPol.Size = new Size(146, 28);
            cbPol.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(374, 28);
            monthCalendar1.Margin = new Padding(7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // cbGrad
            // 
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(172, 175);
            cbGrad.Margin = new Padding(2);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(146, 28);
            cbGrad.TabIndex = 9;
            cbGrad.SelectedIndexChanged += cbGrad_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 178);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 8;
            label4.Text = "Grad:";
            // 
            // lblOdabraniGrad
            // 
            lblOdabraniGrad.AutoSize = true;
            lblOdabraniGrad.Location = new Point(173, 208);
            lblOdabraniGrad.Name = "lblOdabraniGrad";
            lblOdabraniGrad.Size = new Size(0, 20);
            lblOdabraniGrad.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 326);
            Controls.Add(lblOdabraniGrad);
            Controls.Add(cbGrad);
            Controls.Add(label4);
            Controls.Add(monthCalendar1);
            Controls.Add(cbPol);
            Controls.Add(txtDatumRodj);
            Controls.Add(txtIme);
            Controls.Add(label3);
            Controls.Add(btnPrikazi);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
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
        private ComboBox cbGrad;
        private Label label4;
        private Label lblOdabraniGrad;
    }
}
