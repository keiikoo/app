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
    /// Логика взаимодействия для registrform.xaml
    /// </summary>
    public partial class registrform : Window
    {
        public registrform()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginRegist.Text != "" && PasswordRegist.Text != "")
            {
                XDocument doc;
                doc = XDocument.Load("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\logins.xml");
                doc.Element("users").Add(new XElement("user",
                    new XElement("login", LoginRegist.Text),
                    new XElement("password", PasswordRegist.Text)));
                doc.Save("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\logins.xml");
                MessageBox.Show("Данные добавлены", "Успех", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                this.Visibility = Visibility.Collapsed;
                MainWindow mw = new MainWindow();
                mw.ShowDialog();
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
