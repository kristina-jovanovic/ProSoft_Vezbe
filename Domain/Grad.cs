namespace Domain
{
    public class Grad
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
    }
}
