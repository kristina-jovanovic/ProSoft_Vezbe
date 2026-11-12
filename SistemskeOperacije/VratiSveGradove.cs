using Domain;

namespace SistemskeOperacije
{
    public class VratiSveGradove : ApstraktnaSO
    {
        public List<Grad> Rezultat { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = broker.GetAll(new Grad()).Cast<Grad>().ToList();
        }
    }
}
