using CourseProject.Classes;
using CourseProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CourseProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool vis = false;
        public int widht;
        
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MainPage());
            Navig.MainFrame = MainFrame;
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            
            if (vis == false)
            {
                LMenu.Visibility = Visibility.Hidden;
                Menu.Width = 40;
                
                vis = true;
                return;
            }

            if(vis == true)
            {
                LMenu.Visibility = Visibility.Visible;
                vis = false;
                Menu.Width = 90;
                //SplViev.Background = Color.;
                return;
            }
        }
        
    }
}
