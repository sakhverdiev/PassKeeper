using PassKeeperPages.UserClass;
using System;
using System.Collections.Generic;
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

namespace PassKeeperPages.Pages
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    /// 
    public partial class Register : Page
    {
        static public User ?newUser { get; set; } = new();
        public Register()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(ManagmentPages.Pages.RegisterPassword = new());
        }
    }
}
