namespace Domain
{
    public class Osoba
    {
        public int Id { get; set; }
        public string ImeIPrezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Pol Pol { get; set; }
        public Grad Grad { get; set; }

        public string NazivGrada => Grad?.Naziv ?? "N/A";

        public override string? ToString()
        {
            return $"Osoba: {ImeIPrezime}, datum rodjenja: {DatumRodjenja}, pol: {Pol}";
        }
    }
}
