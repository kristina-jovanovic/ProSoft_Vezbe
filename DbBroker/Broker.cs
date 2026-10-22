using System.Diagnostics;
using Domain;
using Microsoft.Data.SqlClient;

namespace DbBroker
{
    public class Broker
    {
        private static SqlConnection konekcija = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ps_2026/27;Integrated Security=True;");

        public static void OtvoriKonekciju()
        {
            konekcija.Open();
            Console.WriteLine("Konekcija otvorena.");
        }

        public static void ZatvoriKonekciju()
        {
            konekcija.Close();
            Console.WriteLine("Konekcija zatvorena.");
        }

        public static void UbaciOsobu(Osoba o)
        {
            string upit = "INSERT INTO Osoba (ImeIPrezime, DatumRodjenja, Pol, Grad) " +
                "VALUES (@ImeIPrezime, @DatumRodjenja, @Pol, @Grad)";
            using (SqlCommand cmd = new SqlCommand(upit, konekcija))
            {
                cmd.Parameters.AddWithValue("@ImeIPrezime", o.ImeIPrezime);
                cmd.Parameters.AddWithValue("@DatumRodjenja", o.DatumRodjenja);
                cmd.Parameters.AddWithValue("@Pol", o.Pol.ToString());
                cmd.Parameters.AddWithValue("@Grad", o.Grad.Ptt);
                Console.WriteLine("///" + cmd.CommandText);

                int brojRedova = cmd.ExecuteNonQuery();
                Debug.WriteLine($"Ubačeno {brojRedova} redova.");

            }
        }


        public static List<Osoba> VratiSveOsobe()
        {
            List<Osoba> osobe = new List<Osoba>();
            string upit = "SELECT o.Id, o.ImeIPrezime, o.DatumRodjenja, o.Pol, g.Ptt, g.Naziv FROM Osoba o JOIN Grad g ON o.Grad = g.Ptt";
            using (SqlCommand cmd = new SqlCommand(upit, konekcija))
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
    }
}
