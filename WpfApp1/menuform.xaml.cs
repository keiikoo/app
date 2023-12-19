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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для menuform.xaml
    /// </summary>
    public partial class menuform : Window
    {
        public menuform()
        {
            InitializeComponent();
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            productsform pf = new productsform();
            pf.ShowDialog();
        }

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            customersform cf = new customersform();
            cf.ShowDialog();
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            ordersform of = new ordersform();
            of.ShowDialog();
        }
    }
}
