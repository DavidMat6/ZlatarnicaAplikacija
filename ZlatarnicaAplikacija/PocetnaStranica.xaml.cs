using ZlatarnicaAplikacija.Modeli;
using ZlatarnicaAplikacija.Servisi;

namespace ZlatarnicaAplikacija;

public partial class PocetnaStranica : ContentPage
{
    public PocetnaStranica()
    {
        InitializeComponent();
        PopisProizvoda.ItemsSource = ServisProizvoda.DohvatiProizvode();
        ToolbarItems.Add(new ToolbarItem("Košarica", null, async () => await Navigation.PushAsync(new KosaricaStranica())));
    }

    private async void Odabrano(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Proizvod odabrani)
        {
            await Navigation.PushAsync(new DetaljiProizvodaStranica(odabrani));
            PopisProizvoda.SelectedItem = null;
        }
    }
}