using Xamarin.Forms;
using ConstConfig;
using dt071g_assignment4.ViewModels;

namespace dt071g_assignment4.Views
{
    public class CountdownPage : ContentPage
    {
        public CountdownPage(CountdownPageViewModel viewModel)
        {
            BindingContext = viewModel;

            Title = "Days until Christmas";

            BackgroundColor = Color.FromHex(Const.BackupColor);

            var textLabel = new Label
            {
                Text = "This is a test for CountdownPage",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.FromHex(Const.TextColor),
                FontSize = 16
            };
            // textLabel.SetBinding(Label.TextProperty, nameof(CountdownPageViewModel.[[[[Method to show the countdown timer goes here from the CountdownPageViewModel]]]]));

            var exitButton = new Button
            {
                Text = "Go Back",
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(20),
                BackgroundColor = Color.FromHex(Const.ButtonColor),
                FontSize = 20
            };
            exitButton.SetBinding(Button.CommandProperty, nameof(CountdownPageViewModel.ExitCommand));

        }
    }
}
