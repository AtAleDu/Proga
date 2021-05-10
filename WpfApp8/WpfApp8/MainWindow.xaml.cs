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

namespace WpfApp8
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
            Window1 reg = new Window1();
            reg.Show();
            Hide();
        }
        //Вход 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (avtorEntities2 Vhod = new avtorEntities2())
            {
                //проверка на ввод даных
                User user = Vhod.User.Where(u => u.Login == login.Text && u.Password == Passw.Password).FirstOrDefault();
                if (user != null)
                {
                    MessageBox.Show("Вы зашли");
                    Window2 kab = new Window2(user);
                    kab.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Неправильно ");
                }
            }    
        }
    }
}
