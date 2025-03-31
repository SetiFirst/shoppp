using shoppp.classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace shoppp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            shop.ItemsSource = new ProductCollection();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchQuery = searchTextBox.Text.ToLower();
            if (!string.IsNullOrEmpty(searchQuery))
            {
                ProductCollection _products = new ProductCollection();
                List<Product> filteredCollection = new List<Product>();
                foreach (Product product in _products)
                {
                    if (product.Title.ToLower().Contains(searchQuery) || product.Description.ToLower().Contains(searchQuery) || product.Category.ToLower().Contains(searchQuery) || product.Price.ToLower().Contains(searchQuery))
                    {
                        filteredCollection.Add(product);
                    }
                }
                shop.ItemsSource = filteredCollection;
            }
            else
            {
                shop.ItemsSource = new ProductCollection();
            }
        }

    }
}
