using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using ConstConfig;

namespace dt071g_assignment4
{
    public partial class App : Xamarin.Forms.Application
    {
        public App()
        {
            var navigationPage = new Xamarin.Forms.NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex(Const.SecondaryColor),
                BarTextColor = Color.FromHex(Const.TextColor)
            };

            navigationPage.On<iOS>().SetPrefersLargeTitles(true);

            MainPage = navigationPage;
        }
    }
}
