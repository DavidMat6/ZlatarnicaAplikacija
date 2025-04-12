using ZlatarnicaAplikacija.Modeli;

namespace ZlatarnicaAplikacija;

public partial class KosaricaStranica : ContentPage
{
    public KosaricaStranica()
    {
        InitializeComponent();
        PopisKosarice.ItemsSource = Aplikacija.Kosarica;
    }

    private async void ObrisiStavku(object sender, EventArgs e)
    {
        var stavka = (sender as SwipeItem)?.BindingContext as StavkaUKosarici;
        if (stavka != null)
        {
            bool potvrda = await DisplayAlert("Potvrda", $"Obrisati \"{stavka.Proizvod.Naziv}\" iz košarice?", "Da", "Ne");
            if (potvrda)
            {
                Aplikacija.Kosarica.Remove(stavka);
                PopisKosarice.ItemsSource = null;
                PopisKosarice.ItemsSource = Aplikacija.Kosarica;
            }
        }
    }

    private async void DovrsiKupnju(object sender, EventArgs e)
    {
        await DisplayAlert("Hvala!", "Kupnja je uspješno dovršena.", "U redu");
        Aplikacija.Kosarica.Clear();
        PopisKosarice.ItemsSource = null;
    }
}