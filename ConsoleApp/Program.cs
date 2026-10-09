//Console.WriteLine("Hello, World!");

using Domain;

Osoba p = new Osoba
{
    Id = 1,
    ImeIPrezime = "Pera Peric",
    DatumRodjenja = new DateTime(1990, 9, 10)
};

Console.WriteLine(p); // Sta se ispisuje? Sta treba da uradimo da bi se ispisali pravi podaci te osobe?