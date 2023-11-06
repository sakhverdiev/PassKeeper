using PassKeeperPages.Database;
using PassKeeperPages.UserClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PassKeeperPages.Pages;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace PassKeeperPages.Pages
{

    public partial class Landing1 : Page, INotifyPropertyChanged
    {


        public ObservableCollection<Account> accounts { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;

        public string? UserImage { get; set; }
        public Landing1()
        {
            InitializeComponent();
            accounts = new(Users.user.Accounts);
            UserImage = Users.user.Image ?? @"\MyImages\ProfilePhoto.png";
            DataContext = this;
        }




        private void combobox_dropdownopened_click(object sender, EventArgs e)
        {

        }

        private void combobox_dropdownclosed_click(object sender, EventArgs e)
        {


        }

        private void profImage_click(object sender, MouseButtonEventArgs e)
        {

            NavigationService.Navigate(ManagmentPages.Pages.LandingProfile = new());
        }

        private void btn_trash_click(object sender, RoutedEventArgs e)
        {
            var item = (((Button)sender).DataContext) as Account;
            accounts.Remove(item);
            Users.user.Accounts = new(accounts);
            Users.UpdateDatabase();
        }

        private void btn_edit_click(object sender, RoutedEventArgs e)
        {
            LandingEdit.account = (((Button)sender).DataContext) as Account;

            NavigationService.Navigate(ManagmentPages.Pages.LandingEdit = new());
        }

        private void btn_add_click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(ManagmentPages.Pages.LandingAdd = new());
        }

        private void serached(object sender, TextChangedEventArgs e)
        {
            if (textbox_search.Text.ToString() == "")
            {
                accounts = new(Users.user.Accounts);
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(accounts)));
            }
            else
            {
                accounts.Clear();
                foreach (var account in Users.user.Accounts)
                {
                    if (account.SocialNetworkName.ToLower().Contains(textbox_search.Text.ToString().ToLower()))
                        accounts.Add(account);
                }
            }
        }
    }
}
