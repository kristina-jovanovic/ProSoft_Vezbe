using Microsoft.Data.SqlClient;

namespace Domain
{
    public class Osoba : IEntity
    {
        public int Id { get; set; }
        public string ImeIPrezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Pol Pol { get; set; }
        public Grad Grad { get; set; }

        public string NazivGrada => Grad?.Naziv ?? "N/A";

        public string TableName => "Osoba";

        public string Values => $"'{ImeIPrezime}', '{DatumRodjenja.ToString("yyyyMMdd")}', '{Pol.ToString()}', {Grad?.Ptt ?? 0}";

        public string Join => "o JOIN Grad g ON (o.grad = g.ptt)";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> osobe = new List<IEntity>();
            while (reader.Read())
            {
                Osoba o = new Osoba
                {
                    Id = (int)reader["Id"],
                    ImeIPrezime = (string)reader["ImeIPrezime"],
                    DatumRodjenja = (DateTime)reader["DatumRodjenja"],
                    Pol = Enum.Parse<Pol>((string)reader["Pol"]),
                    Grad = new Grad
                    {
                        Ptt = (int)reader["Grad"],
                        Naziv = (string)reader["Naziv"]
                    }
                };
                osobe.Add(o);
            }
            return osobe;
        }

        public override string? ToString()
        {
            return $"Osoba: {ImeIPrezime}, datum rodjenja: {DatumRodjenja}, pol: {Pol}";
        }
    }
}
