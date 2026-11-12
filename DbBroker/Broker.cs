using System.Diagnostics;
using Domain;
using Konfiguracija;
using Microsoft.Data.SqlClient;

namespace DbBroker
{
    public class Broker
    {
        private SqlConnection konekcija = new SqlConnection(Podaci.UcitajPodatke().KonekcioniString);

        public void OtvoriKonekciju()
        {
            konekcija.Open();
            Console.WriteLine("Konekcija otvorena.");
        }

        public void ZatvoriKonekciju()
        {
            konekcija.Close();
            Console.WriteLine("Konekcija zatvorena.");
        }

        public int UbaciOsobu(Osoba o)
        {
            string upit = "INSERT INTO Osoba (ImeIPrezime, DatumRodjenja, Pol, Grad) " +
                "OUTPUT INSERTED.Id " +
                "VALUES (@ImeIPrezime, @DatumRodjenja, @Pol, @Grad)";
            using (SqlCommand cmd = new SqlCommand(upit, konekcija, transakcija))
            {
                cmd.Parameters.AddWithValue("@ImeIPrezime", o.ImeIPrezime);
                cmd.Parameters.AddWithValue("@DatumRodjenja", o.DatumRodjenja);
                cmd.Parameters.AddWithValue("@Pol", o.Pol.ToString());
                cmd.Parameters.AddWithValue("@Grad", o.Grad.Ptt);
                //Console.WriteLine("///" + cmd.CommandText);

                //int brojRedova = cmd.ExecuteNonQuery();
                //Debug.WriteLine($"Ubačeno {brojRedova} redova.");

                int noviId = (int)cmd.ExecuteScalar();
                return noviId;
            }
        }

        public List<Osoba> VratiSveOsobe()
        {
            List<Osoba> osobe = new List<Osoba>();
            string upit = "SELECT o.Id, o.ImeIPrezime, o.DatumRodjenja, o.Pol, g.Ptt, g.Naziv FROM Osoba o JOIN Grad g ON o.Grad = g.Ptt";
            using (SqlCommand cmd = new SqlCommand(upit, konekcija,transakcija))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Osoba o = new Osoba
                        {
                            Id = reader.GetInt32(0),
                            ImeIPrezime = (string)reader["ImeIPrezime"],
                            DatumRodjenja = (DateTime)reader[2],
                            Pol = Enum.Parse<Pol>(reader.GetString(3)),
                            Grad = new Grad(reader.GetInt32(4), reader.GetString(5))
                        };
                        osobe.Add(o);
                    }
                }
            }
            return osobe;
        }

        ////////// VEZBE 05

        public List<Grad> VratiSveGradove()
        {
            List<Grad> gradovi = new List<Grad>();
            string upit = "SELECT * FROM Grad";
            using (SqlCommand cmd = new SqlCommand(upit, konekcija, transakcija))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Grad g = new Grad(reader.GetInt32(0), reader.GetString(1));
                        gradovi.Add(g);
                    }
                }
            }
            return gradovi;
        }

        public void IzmeniGrad(Grad grad)
        {
            string upit = "UPDATE Grad SET Naziv = @Naziv WHERE Ptt = @Ptt";
            using (SqlCommand cmd = new SqlCommand(upit, konekcija, transakcija))
            {
                cmd.Parameters.AddWithValue("@Naziv", grad.Naziv);
                cmd.Parameters.AddWithValue("@Ptt", grad.Ptt);
                int brojRedova = cmd.ExecuteNonQuery();
                Debug.WriteLine($"Izmenjeno {brojRedova} redova.");
            }
        }

        public void ObrisiOsobu(int id)
        {
            string upit = "DELETE FROM Osoba WHERE Id = @Id";
            using (SqlCommand cmd = new SqlCommand(upit, konekcija, transakcija))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                int brojRedova = cmd.ExecuteNonQuery();
                Debug.WriteLine($"Obrisano {brojRedova} redova.");
            }
        }
        //Da li mozemo da obrisemo neki grad? U kom slucaju ce to biti problematicno? Zasto?

        //TRANSAKCIJE 
        //NAPOMENA: sada je potrebno u metodama prilikom kreiranja SqlCommand objekta proslediti i transakciju

        private SqlTransaction transakcija;


        public void ZapocniTransakciju()
        {
            transakcija = konekcija.BeginTransaction();
            Console.WriteLine("Transakcija započeta.");
        }

        public void Commit()
        {
            transakcija.Commit();
            Console.WriteLine("Transakcija potvrđena.");
        }

        public void Rollback()
        {
            transakcija.Rollback();
            Console.WriteLine("Transakcija poništena.");

        }
    }
}
