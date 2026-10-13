using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmPretragaOsoba : Form
    {

        public List<Osoba> osobe = new List<Osoba> {
        new Osoba
        {
            Id = 1,
            ImeIPrezime = "Pera Peric",
            DatumRodjenja = new DateTime(1999,2,2),
            Pol = Pol.Muski
        },
        new Osoba
        {
            Id = 2,
            ImeIPrezime = "Zika Zikic",
            DatumRodjenja = new DateTime(2005,12,23),
            Pol = Pol.Muski
        },
        new Osoba
        {
            Id = 3,
            ImeIPrezime = "Ana Anic",
            DatumRodjenja = new DateTime(2008,1,1),
            Pol = Pol.Zenski
        }
        };
        public FrmPretragaOsoba()
        {
            InitializeComponent();
            dgvOsobe.DataSource = new BindingList<Osoba>(osobe);

            dgvOsobe.Columns["Id"].Visible = false;


        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (dgvOsobe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo vas odaberite osobu!");
                return;
            }

            Osoba o = (Osoba)dgvOsobe.SelectedRows[0].DataBoundItem;
            MessageBox.Show($"Odabrali ste osobu {o}");
        }

        private void txtKriterijumPretrage_TextChanged(object sender, EventArgs e)
        {
            string kriterijum = txtKriterijumPretrage.Text;
            var pretrazeneOsobe = osobe.Where(o => o.ImeIPrezime.Contains(kriterijum, StringComparison.OrdinalIgnoreCase) || o.DatumRodjenja.ToString().Contains(kriterijum, StringComparison.OrdinalIgnoreCase) || o.Pol.ToString().Contains(kriterijum, StringComparison.OrdinalIgnoreCase)).ToList();
            dgvOsobe.DataSource = new BindingList<Osoba>(pretrazeneOsobe);
        }
    }
}
