using Plugin.LocalNotification;
using ZlatarnicaAplikacija.Modeli;

namespace ZlatarnicaAplikacija;

public partial class Aplikacija : Application
{
    public static List<StavkaUKosarici> Kosarica { get; set; } = new();

    public Aplikacija()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new PocetnaStranica());
        ZakaziNotifikaciju();
    }

    private void ZakaziNotifikaciju()
    {
        Plugin.LocalNotification.LocalNotificationCenter.Current.Show(new NotificationRequest
        {
            NotificationId = 100,
            Title = "Podsjetnik",
            Description = "Imate proizvode u košarici!",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddMinutes(1),
                RepeatType = NotificationRepeat.No
            }
        });
    }
}