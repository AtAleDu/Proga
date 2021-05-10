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

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        //кнопка возврощает назад
        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow back = new MainWindow();
            back.Show();
            Hide();
        }
        //Регистрация
        private void Regis(object sender, RoutedEventArgs e)
        {
           
            //проверка на пустые строки
            if (name.Text.Length > 0 && FirstName.Text.Length > 0 && login.Text.Length > 0 && pas.Password.Length > 0)
            {
                using (avtorEntities2 Kabinet = new avtorEntities2())
                {
                    string chlogin = Convert.ToString(login.Text);
                    User reguser = Kabinet.User.Where(r => r.Login == chlogin).FirstOrDefault();
                    if(reguser !=null)
                    {
                        MessageBox.Show("Такая запись есть");
                    }
                    else
                    {
                        Class1 register = new Class1();
                        register.AddPerson(name.Text, FirstName.Text, (DateTime)Data.SelectedDate);
                        register.AddUser(login.Text, pas.Password);
                        MessageBox.Show("Успешно");
                    }


                }
            }
           
            else 
            {
                MessageBox.Show("Что-то не заполненно");
            }

        }
    }
}
