using PassKeeperPages.Database;
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
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void forgotpassword_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ForgotPassSendCode());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Users.user = Users.users.FirstOrDefault(u => u.UserName == textbox_name.Text.ToString() &&
                u.Password == textbox_password.Text.ToString());
             
                NavigationService.Navigate(ManagmentPages.Pages.Landing1 = new());
            }
            catch (Exception)
            {
            }
        }
    }
}
