using Domain;

namespace SistemskeOperacije
{
    public class UbaciViseOsobaSO : ApstraktnaSO
    {
        public List<Osoba> Osobe { get; private set; }
        public UbaciViseOsobaSO(List<Osoba> o)
        {
            Osobe = o;
        }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            foreach (Osoba osoba in Osobe)
            {
                broker.Add(osoba);
            }
        }
    }
}
