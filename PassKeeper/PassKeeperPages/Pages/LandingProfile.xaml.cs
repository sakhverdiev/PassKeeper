using Microsoft.Win32;
using PassKeeperPages.Database;
using PassKeeperPages.UserClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
using Path = System.IO.Path;

namespace PassKeeperPages.Pages
{
    public partial class LandingProfile : Page, INotifyPropertyChanged
    {

        public User? user { get; set; } = new();


        public LandingProfile()
        {
            InitializeComponent();
            user = Users.user;
            user.Image = Users.user.Image ?? @"\MyImages\ProfilePhoto.png";
            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public string foo(string name)
        {
            return @"\asd\";
        }
        public void OnPropertyChanged([CallerMemberName] string proName = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(proName));
        }
        private void edit_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == true)
            {
                if (!File.Exists($"..\\..\\..\\MyImages\\{Path.GetFileName(fileDialog.FileName)}"))
                    File.Copy(fileDialog.FileName, $"..\\..\\..\\MyImages\\{Path.GetFileName(fileDialog.FileName)}");

                var update = Users.users.FirstOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);
                string filename = Path.GetFileName(fileDialog.FileName);
                user.Image = $@"\MyImages\{Path.GetFileName(fileDialog.FileName)}";
                update = user;
                Users.UpdateDatabase();
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(user)));
            }

        }
    }
}
