using dt071g_assignment4.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace dt071g_assignment4.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            CountdownPageCommand = new Command(async () => {

                var CountdownPageViewModel = new CountdownPageViewModel
                {

                };

                await Application.Current.MainPage.Navigation.PushAsync(new CountdownPage(CountdownPageViewModel));
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public Command CountdownPageCommand { get; }
    }

}
