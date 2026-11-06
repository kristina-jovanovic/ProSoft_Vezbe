using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void kreirajOsobuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void pretragaOsobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPretragaOsoba frmPretragaOsoba = new FrmPretragaOsoba();
            frmPretragaOsoba.ShowDialog();
        }

        private void dodajOsobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDodajOsobe osobe = new FrmDodajOsobe();
            osobe.ShowDialog();
        }

        private void izmeniOsobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzmeniOsobe izmena = new FrmIzmeniOsobe();
            izmena.ShowDialog();
        }
    }
}
