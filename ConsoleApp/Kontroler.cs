using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DbBroker;
using Domain;
using SistemskeOperacije;

namespace ConsoleApp
{
    public class Kontroler
    {
        private Broker broker;

        //singleton
        private static Kontroler instance;
        public static Kontroler Instance
        {
            get
            {
                if (instance == null) instance = new Kontroler();
                return instance;
            }
        }
        private Kontroler()
        {
            broker = new Broker();
        }

        public int UbaciOsobu(Osoba o)
        {
            #region stari nacin ubacivanja osobe u bazu
            //try
            //{
            //    broker.OtvoriKonekciju();
            //    broker.ZapocniTransakciju();
            //    //konkretna operacija
            //    int noviId = broker.UbaciOsobu(o);
            //    broker.Commit();
            //    return noviId; //finally blok ce se svakako izvrsiti
            //}
            //catch (Exception ex)
            //{
            //    broker.Rollback();
            //    Debug.WriteLine(">>> " + ex.Message);
            //    return -1; //finally blok ce se svakako izvrsiti
            //}
            //finally
            //{
            //    broker.ZatvoriKonekciju();
            //}
            #endregion

            UbaciOsobuSO so = new UbaciOsobuSO(o);
            so.Izvrsi();
            return so.Osoba.Id;
        }

        public List<Osoba> VratiSveOsobe()
        {
            #region stari nacin vracanja osoba iz baze
            //try
            //{
            //    broker.OtvoriKonekciju();
            //    broker.ZapocniTransakciju();
            //    //konkretna operacija
            //    List<Osoba> osobe = broker.VratiSveOsobe();
            //    broker.Commit();
            //    return osobe;
            //}
            //catch (Exception ex)
            //{
            //    broker.Rollback();
            //    Debug.WriteLine(">>> " + ex.Message);
            //    return new List<Osoba>();
            //}
            //finally
            //{
            //    broker.ZatvoriKonekciju();
            //}
            #endregion

            VratiSveOsobe so = new VratiSveOsobe();
            so.Izvrsi();
            return so.Rezultat;
        }

        public void ObrisiOsobu(Osoba o)
        {
            #region stari nacin brisanja osobe iz baze
            //try
            //{
            //    broker.OtvoriKonekciju();
            //    broker.ZapocniTransakciju();
            //    //konkretna operacija
            //    broker.ObrisiOsobu(o.Id);
            //    broker.Commit();
            //}
            //catch (Exception ex)
            //{
            //    broker.Rollback();
            //    Debug.WriteLine(">>> " + ex.Message);
            //}
            //finally
            //{
            //    broker.ZatvoriKonekciju();
            //}
            #endregion

            ObrisiOsobuSO so = new ObrisiOsobuSO(o);
            so.Izvrsi();
        }

        public void IzmeniGrad(Grad grad)
        {
            IzmeniGradSO so = new IzmeniGradSO(grad);
            so.Izvrsi();
        }
    }
}
