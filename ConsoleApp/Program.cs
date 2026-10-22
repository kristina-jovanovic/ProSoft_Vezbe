//Console.WriteLine("Hello, World!");

using DbBroker;
using Domain;
using Microsoft.Data.SqlClient;

Osoba p = new Osoba
{
    Id = 1,
    ImeIPrezime = "Pera Peric",
    DatumRodjenja = new DateTime(1990, 9, 10),
    Pol = Pol.Muski,
    Grad = new Grad(11000, "Beograd")
};


//Console.WriteLine(p); // Sta se ispisuje? Sta treba da uradimo da bi se ispisali pravi podaci te osobe?

try
{
    Broker.OtvoriKonekciju();
    Broker.UbaciOsobu(p);
    List<Osoba> sveOsobe = Broker.VratiSveOsobe();
    foreach (var osoba in sveOsobe)
    {
        Console.WriteLine(osoba);
    }

}
catch (SqlException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Broker.ZatvoriKonekciju();
}

