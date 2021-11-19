using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace dt071g_assignment4.ViewModels
{
    public class CountdownPageViewModel : INotifyPropertyChanged
    {
        public CountdownPageViewModel()
        {
            ExitCommand = new Command(async () => await Application.Current.MainPage.Navigation.PopAsync());
        }

        public event PropertyChangedEventHandler PropertyChanged;


        // Show a countdown timer here until xmas


        public ICommand ExitCommand { get; }
    }

}
