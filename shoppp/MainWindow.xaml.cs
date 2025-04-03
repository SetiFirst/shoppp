using shoppp.model;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace shoppp
{
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
                searchQuery = searchQuery?.ToLower() ?? ""; 

                List<Product> filteredCollection = _products
                    .Where(p =>
                        (p.Title?.ToLower() ?? "").Contains(searchQuery) ||
                        (p.Description?.ToLower() ?? "").Contains(searchQuery) ||
                        (p.Category?.ToLower() ?? "").Contains(searchQuery) ||
                        (p.Price?.ToLower() ?? "").Contains(searchQuery))
                    .ToList();

                shop.ItemsSource = filteredCollection;
            }
            else
            {
                shop.ItemsSource = new ProductCollection();
            }
        }

    }
}
