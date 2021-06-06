using CourseProject.Base;
using CourseProject.Classes;
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

namespace CourseProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        
        public UserPage()
        {
            InitializeComponent();
            SaleComponentsEntities1 db = new SaleComponentsEntities1();
            List<Users> users = db.Users.ToList();
            List<Privileges> privileges = db.Privileges.ToList();

            ListInfo.ItemsSource = users;
            ListInfo.ItemsSource = privileges;
            NameInfo.ItemsSource = users;


        }

       

        private void EditPhoto_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Находится в разработке", "Техническая ошибка", MessageBoxButton.OK);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Navig.MainFrame.Navigate(new MainPage());
            
        }

        private void EditUser_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
