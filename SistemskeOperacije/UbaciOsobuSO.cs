using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace SistemskeOperacije
{
    public class UbaciOsobuSO : ApstraktnaSO
    {
        public Osoba Osoba { get; private set; }

        public UbaciOsobuSO(Osoba o)
        {
            Osoba = o;
        }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            Osoba = (Osoba)broker.Add(Osoba);
        }

    }
}
