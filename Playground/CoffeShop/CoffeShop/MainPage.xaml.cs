using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System;


namespace CoffeShop
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog message = new MessageDialog("Customer added!");

            await message.ShowAsync();
        }

        private void DeleteCustomer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeSide_Click(object sender, RoutedEventArgs e)
        {
            int column = Grid.GetColumn(CustomersList);

            int currentColumn = 0;
            if (column == 0)
            {
                currentColumn = 2;
            }

            Grid.SetColumn(CustomersList, currentColumn);

            if (currentColumn == 0)
            {
                ChangeButton.Symbol = Symbol.Forward;
            }
            else if (currentColumn == 2)
            {
                ChangeButton.Symbol = Symbol.Back;
            }
        }
    }
}
