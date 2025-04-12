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
            bool potvrda = await DisplayAlert("Potvrda", $"Obrisati \"{stavka.Proizvod.Naziv}\" iz ko�arice?", "Da", "Ne");
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
        await DisplayAlert("Hvala!", "Kupnja je uspje�no dovr�ena.", "U redu");
        Aplikacija.Kosarica.Clear();
        PopisKosarice.ItemsSource = null;
    }
}