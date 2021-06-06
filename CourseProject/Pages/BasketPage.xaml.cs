using CourseProject.Base;
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
    /// Логика взаимодействия для BasketPage.xaml
    /// </summary>
    public partial class BasketPage : Page
    {
        public BasketPage()
        {
            InitializeComponent();
            SaleComponentsEntities1 db = new SaleComponentsEntities1();
            List<Basket> users = db.Basket.ToList();
            List<List_Purchase> list_s = db.List_Purchase.ToList();
            

        }

        private void DeleteProd_Click(object sender, RoutedEventArgs e)
        {
            var basketForRemoving = BasketView.SelectedItems.Cast<Basket>().ToList();
            var purchForRemoving = BasketView.SelectedItems.Cast<List_Purchase>().ToList();
            
            if (MessageBox.Show($"Вы точно хотите удалить этот элемент?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    SaleComponentsEntities1.getContext().Basket.RemoveRange(basketForRemoving);
                    SaleComponentsEntities1.getContext().List_Purchase.RemoveRange(purchForRemoving);
                   
                    SaleComponentsEntities1.getContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    BasketView.ItemsSource = SaleComponentsEntities1.getContext().Basket.ToList();
                    BasketView.ItemsSource = SaleComponentsEntities1.getContext().List_Purchase.ToList();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
