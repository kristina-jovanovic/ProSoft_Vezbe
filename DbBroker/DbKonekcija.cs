using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Konfiguracija;
using Microsoft.Data.SqlClient;

namespace DbBroker
{
    public class DbKonekcija
    {
        private SqlConnection konekcija;
        private SqlTransaction transakcija;

        public DbKonekcija()
        {
            konekcija = new SqlConnection(Podaci.UcitajPodatke().KonekcioniString);
        }

        public void OtvoriKonekciju()
        {
            konekcija?.Open();
        }

        public void ZatvoriKonekciju()
        {
            konekcija?.Close();
        }

        public void ZapocniTransakciju()
        {
            transakcija = konekcija.BeginTransaction();
        }

        public void Commit()
        {
            transakcija?.Commit();
        }

        public void Rollback()
        {
            transakcija?.Rollback();
        }

        public SqlCommand KreirajKomandu()
        {
            return new SqlCommand("", konekcija, transakcija);
        }
    }
}
