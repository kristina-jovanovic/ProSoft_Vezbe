//Console.WriteLine("Hello, World!");

using DbBroker;
using Domain;
using Microsoft.Data.SqlClient;

Osoba p = new Osoba
{
    ImeIPrezime = "Pera Peric",
    DatumRodjenja = new DateTime(1990, 9, 10),
    Pol = Pol.Muski,
    Grad = new Grad(11000, "Beograd")
};


Osoba p1 = new Osoba
{
    ImeIPrezime = "Mika Mikić",
    DatumRodjenja = new DateTime(2000, 5, 5),
    Pol = Pol.Muski,
    Grad = new Grad(21000, "Novi Sad")
};
//Console.WriteLine(p); // Sta se ispisuje? Sta treba da uradimo da bi se ispisali pravi podaci te osobe?

try
{
    #region ubacivanje osobe i ispis svih osoba iz baze
    //Broker.OtvoriKonekciju();
    //Broker.UbaciOsobu(p);
    //List<Osoba> sveOsobe = Broker.VratiSveOsobe();
    //foreach (var osoba in sveOsobe)
    //{
    //    Console.WriteLine(osoba);
    //}
    #endregion

    #region ispis svih gradova iz baze uz koriscenje transakcije
    //Broker.OtvoriKonekciju();
    //Broker.ZapocniTransakciju();
    //List<Grad> sviGradovi = Broker.VratiSveGradove();
    //foreach (var grad in sviGradovi)
    //{
    //    Console.WriteLine(grad);
    //}
    //Broker.Commit(); //Da li je ovde neophdono koristiti transakciju i commit (u slucaju citanja gradova)? Sta ce se desiti ako se ne pozove commit?
    //Sta commit radi? 
    #endregion

    #region ubacivanje osobe i ispis svih osoba iz baze uz koriscenje transakcije
    Broker.OtvoriKonekciju();
    Broker.ZapocniTransakciju();
    int noviId = Broker.UbaciOsobu(p1);
    List<Osoba> sveOsobe = Broker.VratiSveOsobe();
    foreach (var osoba in sveOsobe)
    {
        Console.WriteLine(osoba);
    }
    #region DOMACI
    //p1.ImeIPrezime= "Mihajlo Mikić";
    //Broker.IzmeniOsobu(p1); 
    //DOMACI - sada imamo id novounete osobe koji je generisala baza (noviId), pa mozemo da je izmenimo
    //Testirati IzmeniGrad() metodu.
    //Napisati metodu ObrisiOsobu() i testirati.
    //Napisati metodu ObrisiSveMaloletneOsobe() i testirati. Filtriranje je potrebno vrsiti direktno nad podacima iz baze (u okviru upita)
    #endregion

    Broker.Commit();
    #endregion

    //Uocavamo ustaljeni obrazac izvrsavanja - otvaranje konekcije, zapocinjanje transakcije,
    //izvrsavanje upita, commit ili rollback i zatvaranje konekcije.
    //U narednim nedeljama cemo se baviti mehanizmima koji ce nam omoguciti da ovo izvrsavanje upita i transakcija bude automatizovano i da ne moramo da pamtimo da li smo pozvali commit ili rollback.
    //Na taj nacin gradimo konacnu arhitekturu sistema koju cete koristiti prilikom izrade seminarskih radova.

}
catch (SqlException ex)
{
    Console.WriteLine(ex.Message);
    Broker.Rollback();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Broker.Rollback();
}
finally
{
    Broker.ZatvoriKonekciju();
}

