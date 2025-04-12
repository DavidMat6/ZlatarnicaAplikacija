using ZlatarnicaAplikacija.Modeli;

namespace ZlatarnicaAplikacija;

public partial class DetaljiProizvodaStranica : ContentPage
{
    private Proizvod _proizvod;

    public DetaljiProizvodaStranica(Proizvod proizvod)
    {
        InitializeComponent();
        _proizvod = proizvod;
        NazivProizvoda.Text = proizvod.Naziv;
        OpisProizvoda.Text = proizvod.Opis;
        CijenaProizvoda.Text = proizvod.Cijena.ToString("C");
        SlikaProizvoda.Source = proizvod.Slika;
    }

    private async void DodajUKosaricu(object sender, EventArgs e)
    {
        Aplikacija.Kosarica.Add(new StavkaUKosarici { Proizvod = _proizvod, Kolicina = 1 });
        await DisplayAlert("Dodano", "Proizvod je dodan u košaricu.", "U redu");
    }
}