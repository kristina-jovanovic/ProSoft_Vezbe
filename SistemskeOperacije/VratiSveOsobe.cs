using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace SistemskeOperacije
{
    public class VratiSveOsobe : ApstraktnaSO
    {
        public List<Osoba> Rezultat { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = broker.GetAll(new Osoba()).Cast<Osoba>().ToList();
        }
    }
}
