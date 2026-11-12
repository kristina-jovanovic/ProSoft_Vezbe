using Microsoft.Data.SqlClient;

namespace Domain
{
    public class Grad : IEntity
    {
        public Grad()
        {

        }
        public Grad(int ptt, string naziv)
        {
            Ptt = ptt;
            Naziv = naziv;
        }

        public int Ptt { get; set; }
        public string Naziv { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Grad grad &&
                   Ptt == grad.Ptt &&
                   Naziv == grad.Naziv;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Ptt, Naziv);
        }

        public override string? ToString()
        {
            return $"{Ptt}: {Naziv}";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> gradovi = new List<IEntity>();
            while (reader.Read())
            {
                Grad g = new Grad
                {
                    Ptt = (int)reader["ptt"],
                    Naziv = (string)reader["naziv"]
                };
                gradovi.Add(g);
            }
            return gradovi;
        }

        //public Grad Self { get { return this; } }
        //public Grad Self { get => this; }
        public Grad Self => this;

        public string TableName => "Grad";

        public string Values => $"{Ptt}, '{Naziv}'";

        public string Join => "";
    }
}
