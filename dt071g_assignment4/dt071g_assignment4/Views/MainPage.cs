using Xamarin.Forms;
using ConstConfig;
using dt071g_assignment4.ViewModels;

namespace dt071g_assignment4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BackgroundColor = Color.FromHex(Const.PrimaryColor);

            var appImage = new Image
            {
                Source = "santa_hat"
            };

            var countdownButton = new Button
            {
                Text = "Time until Xmas!",
                TextColor = Color.FromHex(Const.TextColor),
                BackgroundColor = Color.FromHex(Const.ButtonColor),
                Margin = new Thickness(10)
            };
            countdownButton.SetBinding(Button.CommandProperty, nameof(MainPageViewModel.CountdownPageCommand));

            var grid = new Grid
            {
                Margin = new Thickness(20, 40),

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                },
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1.0, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1.5, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1.5, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(2.0, GridUnitType.Star) },
                }
            };

            grid.Children.Add(appImage, 0, 0);
            Grid.SetColumnSpan(appImage, 2);

            grid.Children.Add(countdownButton, 0, 1);
            Grid.SetColumnSpan(countdownButton, 2);

            Content = grid;
        }
    }
}
