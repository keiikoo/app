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
using System.Windows.Shapes;
using System.Xml.Linq;
using static WpfApp1.productsform;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для productsform.xaml
    /// </summary>
    public partial class productsform : Window
    {
        XDocument doc;
        public ObservableCollection<object> product;
        public productsform()
        {
            InitializeComponent();
            doc = XDocument.Load("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\products.xml");
            var products = (from x in doc.Elements("products").Elements("product")
                            orderby x.Element("code").Value
                            select new
                            {
                                Код = x.Element("code").Value,
                                Цена = x.Element("cost").Value,
                                Способ_доставки = x.Element("deliverym").Value,
                                Стоимость_доставки = x.Element("deliverycost").Value,
                                Описание = x.Element("describtion").Value
                            }).ToList();

            product = new ObservableCollection<object>(products);
            ProductsInfo.ItemsSource = product;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            doc.Element("products").Add(new XElement("product",
                new XElement("code", ProductCode.Text),
                new XElement("cost", Cost.Text),
                new XElement("deliverym", DeliveryMethod.Text),
                new XElement("deliverycost", DeliveryCost.Text),
                new XElement("describtion", Description.Text)));
            doc.Save("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\products.xml");
            MessageBox.Show("Данные добавлены");
            product.Add(new Products { Код = ProductCode.Text, Цена = Cost.Text, Способ_доставки = DeliveryMethod.Text, Стоимость_доставки = DeliveryCost.Text, Описание = Description.Text });
        }
    }
    public class Products
    {
        public string Код { get; set; }
        public string Цена { get; set; }
        public string Способ_доставки { get; set; }
        public string Стоимость_доставки { get; set; }
        public string Описание { get; set; }
    }
}