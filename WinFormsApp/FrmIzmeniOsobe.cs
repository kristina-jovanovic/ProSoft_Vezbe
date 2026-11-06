using DbBroker;
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
    public partial class FrmIzmeniOsobe : Form
    {

        /*
          Domaci: dopunite kod tako da je omogucena izmena osoba putem transakcija.
          Potrebno je da razlikujemo osobe koje smo izmenili, koje smo dodali i koje smo obrisali.
          Ideja: uvesti kod osobe enum Status          
         */

        private BindingList<Osoba> noveOsobe;
        public FrmIzmeniOsobe()
        {
            InitializeComponent();
            Broker.OtvoriKonekciju();
            noveOsobe = new BindingList<Osoba>(Broker.VratiSveOsobe());
            dgvOsobe.DataSource = noveOsobe;

            dgvOsobe.Columns["Id"].Visible = false;
            dgvOsobe.Columns["Grad"].Visible = false;
            dgvOsobe.Columns["NazivGrada"].Visible = false;
            dgvOsobe.Columns["Pol"].Visible = false;

            DataGridViewComboBoxColumn gradCol = new DataGridViewComboBoxColumn();
            gradCol.DataPropertyName = "Grad"; //property Osobe

            gradCol.DataSource = Broker.VratiSveGradove();
            Broker.ZatvoriKonekciju();
            gradCol.DisplayMember = "Naziv"; //prop Grada koji ce biti prikazan u cmb
            gradCol.ValueMember = "Self"; //prop Grada koji ce cmb vratiti
            gradCol.HeaderText = "Izaberite grad:";

            dgvOsobe.Columns.Add(gradCol);

            DataGridViewComboBoxColumn polCol = new DataGridViewComboBoxColumn();
            polCol.HeaderText = "Pol";
            polCol.DataSource = Enum.GetValues<Pol>();
            polCol.DataPropertyName = "Pol";
            dgvOsobe.Columns.Add(polCol);
        }

        private void dgvOsobe_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
            Osoba o = (Osoba)dgvOsobe.Rows[e.RowIndex].DataBoundItem;
            MessageBox.Show(o.ToString());
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Osoba o = new();
            noveOsobe.Add(o);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(dgvOsobe.SelectedRows.Count > 0)
            {
                Osoba o = (Osoba)dgvOsobe.SelectedRows[0].DataBoundItem;
                MessageBox.Show(o.ToString());
                noveOsobe.Remove(o);
            }
        }
    }
}
