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
    public partial class FrmDodajOsobe : Form
    {
        private BindingList<Osoba> noveOsobe = new();
        public FrmDodajOsobe()
        {
            InitializeComponent();
            dgvOsobe.DataSource = noveOsobe;

            dgvOsobe.Columns["Id"].Visible = false;
            dgvOsobe.Columns["Grad"].Visible = false;
            dgvOsobe.Columns["NazivGrada"].Visible = false;
            dgvOsobe.Columns["Pol"].Visible = false;

            DataGridViewComboBoxColumn gradCol = new DataGridViewComboBoxColumn();
            gradCol.DataPropertyName = "Grad"; //property Osobe
            Broker.OtvoriKonekciju();
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Osoba o = new Osoba();
            noveOsobe.Add(o);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvOsobe.SelectedRows.Count > 0)
            {
                Osoba o = (Osoba)dgvOsobe.SelectedRows[0].DataBoundItem;
                noveOsobe.Remove(o);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Broker.OtvoriKonekciju();
            Broker.ZapocniTransakciju();
            try
            {
              
                foreach (var o in noveOsobe)
                {
                    Broker.UbaciOsobu(o);
                }
                Broker.Commit();
                MessageBox.Show("Osobe su uspesno sacuvane!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: "+ex.Message);
                Broker.Rollback();
            }
            finally
            {
                Broker.ZatvoriKonekciju();
            }

        }
    }
}
