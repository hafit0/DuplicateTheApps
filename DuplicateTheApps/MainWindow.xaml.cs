using DuplicateTheApps.Model;
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
using System.Windows.Controls.Primitives;

namespace DuplicateTheApps
{
    public partial class MainWindow : Window
    {
        private Keranjang keranjang;
        private Item item;
        double subTotal = 0, Saldo = 500000;

        public MainWindow()
        {

            InitializeComponent();

            keranjang = new Keranjang();
            Dijual.ItemsSource = keranjang.GetItems();
            Dijual.Items.Refresh();
        }

        private void OnButtonGantiMetodePembayranClicked(object sender, RoutedEventArgs e)
        {
            Bayar bayar = new Bayar();
            bayar.Show();
        }

        private void OnButtonGantiPromoCLicked(object sender, RoutedEventArgs e)
        {
            Promo promo = new Promo();
            promo.Show();
        }

        private void OnButtonGantiAlamatClicked(object sender, RoutedEventArgs e)
        {
            Alamat alamat = new Alamat();
            alamat.Show();
        }

        private void OnMouseDoubleclick2(object sender, MouseButtonEventArgs e)
        {
            var Result = MessageBox.Show("Are You Sure", "Delete Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (Result == MessageBoxResult.Yes)
            {
                Dibeli.Items.Remove(Dibeli.SelectedItem);
            }
            else if (Result == MessageBoxResult.No)
            {
               
            }

        }

        

        private void OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {


            Dibeli.Items.Add(Dijual.SelectedItem);
            if (Dijual.SelectedIndex == 0)
            {
                subTotal += 3000;
                Saldo -= 3000;
            }
            else if (Dijual.SelectedIndex == 1)
            {
                subTotal += 7000;
                Saldo -= 7000;
            }
            else if (Dijual.SelectedIndex == 2)
            {
                subTotal += 8000;
                Saldo -= 8000;
            }
            else if (Dijual.SelectedIndex == 3)
            {
                subTotal += 6000;
                Saldo -= 6000;
            }
            else if (Dijual.SelectedIndex == 4)
            {
                subTotal += 10000;
                Saldo -= 10000;
            }
            else
            {
                subTotal += 12000;
                Saldo -= 12000;
            }
            subtotal.Content = String.Format("{0}", subTotal);
            saldo.Content = String.Format("{0}", Saldo);
            Total.Content = String.Format("{0}", subTotal + 10000);
        }
    }
}
