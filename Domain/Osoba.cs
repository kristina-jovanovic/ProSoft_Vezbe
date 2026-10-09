namespace Domain
{
    public class Osoba
    {
        public int Id { get; set; }
        public string ImeIPrezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Pol { get; set; }

        public override string? ToString()
        {
            return $"Osoba: {ImeIPrezime}, datum rodjenja: {DatumRodjenja}, pol: {Pol}";
        }
    }
}
