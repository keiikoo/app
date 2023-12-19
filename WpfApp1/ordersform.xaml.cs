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
using System.Xml.Linq;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ordersform.xaml
    /// </summary>
    public partial class ordersform : Window
    {
        XDocument doc;
        public ordersform()
        {
            InitializeComponent();
            doc = XDocument.Load("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\orders.xml");
            var orders = (from x in doc.Elements("orders").Elements("order")
                             orderby x.Element("code").Value
                             select new
                             {
                                 Код_заказа = x.Element("code").Value,
                                 Код_заказчика = x.Element("codez").Value,
                                 Код_товара = x.Element("codet").Value,
                                 Количество = x.Element("amount").Value,
                                 Дата = x.Element("data").Value,
                                 Способ_доставки = x.Element("deliverym").Value,
                                 Стоимость_доставки = x.Element("deliverycost").Value
                             }).ToList();
            OrdersInfo.ItemsSource = orders;

        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            doc.Element("orders").Elements("order").First(b => b.Element("code").
            Value == OrderCode.Text).
            Element("amount").Value = Amount.Text;
            doc.Save("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\orders.xml");
            MessageBox.Show("Данные изменены");
            var orders = (from x in doc.Elements("orders").Elements("order")
                          orderby x.Element("code").Value
                          select new
                          {
                              Код_заказа = x.Element("code").Value,
                              Код_заказчика = x.Element("codez").Value,
                              Код_товара = x.Element("codet").Value,
                              Количество = x.Element("amount").Value,
                              Дата = x.Element("data").Value,
                              Способ_доставки = x.Element("deliverym").Value,
                              Стоимость_доставки = x.Element("deliverycost").Value
                          }).ToList();
            OrdersInfo.ItemsSource = orders;
        }
        private void sortirovka_Click(object sender, RoutedEventArgs e)
        {

            if (sort.Text == "количество" || sort.Text == "Количество")
            {
                doc = XDocument.Load("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\orders.xml");
                var orders = (from x in doc.Elements("orders").Elements("order")
                              orderby x.Element("amount").Value
                              select new
                              {
                                  Код_заказа = x.Element("code").Value,
                                  Код_заказчика = x.Element("codez").Value,
                                  Код_товара = x.Element("codet").Value,
                                  Количество = x.Element("amount").Value,
                                  Дата = x.Element("data").Value,
                                  Способ_доставки = x.Element("deliverym").Value,
                                  Стоимость_доставки = x.Element("deliverycost").Value
                              }).ToList();
                OrdersInfo.ItemsSource = orders;

            }
            else if (sort.Text == "код заказа" || sort.Text == "Код заказа")
            {
                doc = XDocument.Load("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\orders.xml");
                var orders = (from x in doc.Elements("orders").Elements("order")
                              orderby x.Element("code").Value
                              select new
                              {
                                  Код_заказа = x.Element("code").Value,
                                  Код_заказчика = x.Element("codez").Value,
                                  Код_товара = x.Element("codet").Value,
                                  Количество = x.Element("amount").Value,
                                  Дата = x.Element("data").Value,
                                  Способ_доставки = x.Element("deliverym").Value,
                                  Стоимость_доставки = x.Element("deliverycost").Value
                              }).ToList();
                OrdersInfo.ItemsSource = orders;

            }
            else if (sort.Text == "стоимость доставки" || sort.Text == "Стоимость доставки")
            {
                doc = XDocument.Load("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\orders.xml");
                var orders = (from x in doc.Elements("orders").Elements("order")
                              orderby x.Element("deliverycost").Value
                              select new
                              {
                                  Код_заказа = x.Element("code").Value,
                                  Код_заказчика = x.Element("codez").Value,
                                  Код_товара = x.Element("codet").Value,
                                  Количество = x.Element("amount").Value,
                                  Дата = x.Element("data").Value,
                                  Способ_доставки = x.Element("deliverym").Value,
                                  Стоимость_доставки = x.Element("deliverycost").Value
                              }).ToList();
                OrdersInfo.ItemsSource = orders;

            }
            else if (sort.Text == "код заказчика" || sort.Text == "Код заказчика")
            {
                doc = XDocument.Load("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\orders.xml");
                var orders = (from x in doc.Elements("orders").Elements("order")
                              orderby x.Element("codez").Value
                              select new
                              {
                                  Код_заказа = x.Element("code").Value,
                                  Код_заказчика = x.Element("codez").Value,
                                  Код_товара = x.Element("codet").Value,
                                  Количество = x.Element("amount").Value,
                                  Дата = x.Element("data").Value,
                                  Способ_доставки = x.Element("deliverym").Value,
                                  Стоимость_доставки = x.Element("deliverycost").Value
                              }).ToList();
                OrdersInfo.ItemsSource = orders;
            }
            else if (sort.Text == "код товара" || sort.Text == "Код товара")
            {
                doc = XDocument.Load("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\orders.xml");
                var orders = (from x in doc.Elements("orders").Elements("order")
                              orderby x.Element("codet").Value
                              select new
                              {
                                  Код_заказа = x.Element("code").Value,
                                  Код_заказчика = x.Element("codez").Value,
                                  Код_товара = x.Element("codet").Value,
                                  Количество = x.Element("amount").Value,
                                  Дата = x.Element("data").Value,
                                  Способ_доставки = x.Element("deliverym").Value,
                                  Стоимость_доставки = x.Element("deliverycost").Value
                              }).ToList();
                OrdersInfo.ItemsSource = orders;
            }
            else { MessageBox.Show("Убедитесь что вы верно ввели запрос (Именительный падеж)"); }
        }

    }
}
