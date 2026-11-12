using System.Text.Json;

namespace Konfiguracija
{
    public class Podaci
    {
        public string KonekcioniString { get; set; }

        public static Podaci UcitajPodatke()
        {
            // kada se napravi fajl konfiguracija treba selektovati fajl, kliknuti f4 ili
            // otvoriti properties prozor i selektovali Copy To Output Directory - Copy Always!
            // Tako da datoteka bude zajedno sa kompajliranom aplikacijom u folderu, jer koristimo relativnu putanju
            return JsonSerializer.Deserialize<Podaci>(File.ReadAllText("konfiguracija.json"));
        }
    }
}
