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
using System.Xml.Linq;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XDocument doc;
            doc = XDocument.Load("C:\\Users\\Егор\\Desktop\\WpfApp1\\WpfApp1\\xmlfiles\\logins.xml");
            XElement root = doc.Element("users");
            foreach (XElement xe in root.Elements("user"))
            {
                if (xe.Element("login").Value == Login.Text && xe.Element("password").Value == Password.Text)
                {
                    MessageBox.Show("Вы успешно вошли!", "Успех", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    this.Visibility = Visibility.Collapsed;
                    menuform mf = new menuform();
                    mf.ShowDialog();

                }
            }
            MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            registrform rf = new registrform();
            rf.ShowDialog();
        }
    }
}
