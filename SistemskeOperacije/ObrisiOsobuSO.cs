using Domain;

namespace SistemskeOperacije
{
    public class ObrisiOsobuSO : ApstraktnaSO
    {
        private Osoba osoba;
        public ObrisiOsobuSO(Osoba o)
        {
            osoba = o;
        }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            //broker.ObrisiOsobu(osoba.Id);
        }
    }
}
