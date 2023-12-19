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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для customersform.xaml
    /// </summary>
    public partial class customersform : Window
    {
        XDocument doc;
        public ObservableCollection<object> customerss;
        public customersform()
        {
            InitializeComponent();
            DataGridLoad();

        }
        private void Show_Click(object sender, RoutedEventArgs e)
        {
            DataGridLoad();
        }

        public void DataGridLoad()
        {
            doc = XDocument.Load("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\customers.xml");
            var customers = (from x in doc.Elements("customers").Elements("customer")
                             orderby x.Element("code").Value
                             select new
                             {
                                 Код = x.Element("code").Value,
                                 Наименовaние = x.Element("name").Value,
                                 Адресс = x.Element("adress").Value,
                                 Телефон = x.Element("phone").Value,
                                 Контактное_Лицо = x.Element("contact").Value
                             }).ToList();
            CustomersInfo.ItemsSource = customers;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var customerSearch = (from x in doc.Element("customers").Elements("customer")
                              where (string)x.Element("code") == CustomerCode.Text
                              select new
                              {
                                Код = x.Element("code").Value,
                                Наименование = x.Element("name").Value,
                                Адресс = x.Element("adress").Value,
                                Телефон = x.Element("phone").Value,
                                Контактное_лицо = x.Element("contact").Value

                              }).ToList();
            CustomersInfo.ItemsSource = customerSearch;
        }


        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            doc = XDocument.Load("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\customers.xml");
            XElement root = doc.Element("customers");
            foreach (XElement xe in root.Elements("customer"))
            {
                if (xe.Element("code").Value == CustomerCode.Text)
                {
                    if (MessageBox.Show("Вы уверены?", "Вопрос", MessageBoxButton.YesNo, MessageBoxImage.Warning)==MessageBoxResult.Yes)
                    {
                        xe.Remove();
                        doc.Save("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\customers.xml");
                        MessageBox.Show("Данные удалены");
                        DataGridLoad();
                    }
                }
            }
        }
    }
}
