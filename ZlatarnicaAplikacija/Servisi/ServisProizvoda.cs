using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ZlatarnicaAplikacija.Modeli;

namespace ZlatarnicaAplikacija.Servisi;

public static class ServisProizvoda
{
    public static List<Proizvod> DohvatiProizvode() => new()
    {
        new Proizvod { Naziv = "Zlatni prsten", Opis = "Elegantni prsten od 18k zlata.", Cijena = 1299.99m, Slika = "prsten.jpg" },
        new Proizvod { Naziv = "Zlatna ogrlica", Opis = "Klasična ogrlica s privjeskom.", Cijena = 1899.00m, Slika = "ogrlica.jpg" },
        new Proizvod { Naziv = "Sat s kožnim remenom", Opis = "Luksuzni ručni sat.", Cijena = 2599.50m, Slika = "sat.jpg" }
    };
}
