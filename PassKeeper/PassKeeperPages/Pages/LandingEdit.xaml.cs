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

namespace PassKeeperPages.Pages
{
    /// <summary>
    /// Interaction logic for LandingEdit.xaml
    /// </summary>
    public partial class LandingEdit : Page
    {
        static public Account? account { get; set; }
        private Account? tempAccount = new();
        public LandingEdit()
        {
            InitializeComponent();
            tempAccount = account;
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Account? ac = Users.user.Accounts.FirstOrDefault(ac => ac == tempAccount);
            ac = tempAccount;
            Users.UpdateDatabase();
        }
    }
}
