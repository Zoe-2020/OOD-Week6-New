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

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        NORTHWNDEntities db = new NORTHWNDEntities();
      /*  private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            stockLbx.ItemsSource = Enum.GetNames(typeof(StockLevel));

            var query1 = from s in db.Suppliers
                         orderby s.CompanyName
                         select new
                         {
                             SupplierName = s.CompanyName,
                             SupplierID = s.SupplierID,
                             Country = s.Country
                         };

            SuppliersLbx.ItemsSource = query1.ToList();

            var query2 = query1
                .OrderBy(s => s.Country)
                .Select(s => s.Country);


            var countries = query2.ToList();
            CountryLbx.ItemsSource = countries.Distinct();


        } 

        private void stockLbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var query = from p in db.Products
                        where p.UnitsInStock < 50
                        orderby p.ProductName
                        select p.ProductName;

            string selected = stockLbx.SelectedItem as string;

            switch (selected)
            {
                case "Low":
                    break;
                case "Normal":
                    query = from p in db.Products
                            where p.UnitsInStock >= 50 && p.UnitsInStock <= 100
                            orderby p.ProductName
                            select p.ProductName;
                    break;
                case "OverStocked":
                    query = from p in db.Products
                            where p.UnitsInStock > 100
                            orderby p.ProductName
                            select p.ProductName;
                    break;

            }
            productLbx.ItemsSource = query.ToList();

        } 

        private void SuppliersLbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int supplierID = Convert.ToInt32(SuppliersLbx.SelectedValue);

            var query = from p in db.Products
                        where p.SupplierID == supplierID
                        orderby p.ProductName
                        select p.ProductName;

            productLbx.ItemsSource = query.ToList();

        } 

        private void CountryLbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string country = (string)(CountryLbx.SelectedValue);

            var query = from p in db.Products
                        where p.Supplier.Country == country
                        orderby p.ProductName
                        select p.ProductName;

            productLbx.ItemsSource = query.ToList();

        } */

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            stockLbx.ItemsSource = Enum.GetNames(typeof(StockLevel));

            var query1 = from s in db.Suppliers
                         orderby s.CompanyName
                         select new
                         {
                             SupplierName = s.CompanyName,
                             SupplierID = s.SupplierID,
                             Country = s.Country
                         };

            SuppliersLbx.ItemsSource = query1.ToList();

            var query2 = query1
                .OrderBy(s => s.Country)
                .Select(s => s.Country);


            var countries = query2.ToList();
            CountryLbx.ItemsSource = countries.Distinct();

        }

        private void stockLbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var query = from p in db.Products
                        where p.UnitsInStock < 50
                        orderby p.ProductName
                        select p.ProductName;

            string selected = stockLbx.SelectedItem as string;

            switch (selected)
            {
                case "Low":
                    break;
                case "Normal":
                    query = from p in db.Products
                            where p.UnitsInStock >= 50 && p.UnitsInStock <= 100
                            orderby p.ProductName
                            select p.ProductName;
                    break;
                case "OverStocked":
                    query = from p in db.Products
                            where p.UnitsInStock > 100
                            orderby p.ProductName
                            select p.ProductName;
                    break;

            }
            productLbx.ItemsSource = query.ToList();
        }

        private void SuppliersLbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int supplierID = Convert.ToInt32(SuppliersLbx.SelectedValue);

            var query = from p in db.Products
                        where p.SupplierID == supplierID
                        orderby p.ProductName
                        select p.ProductName;

            productLbx.ItemsSource = query.ToList();

        }

        private void CountryLbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int supplierID = Convert.ToInt32(SuppliersLbx.SelectedValue);

            var query = from p in db.Products
                        where p.SupplierID == supplierID
                        orderby p.ProductName
                        select p.ProductName;

            productLbx.ItemsSource = query.ToList();
        }
    }
    public enum StockLevel { low, Normal, OverStocked };
}
    

