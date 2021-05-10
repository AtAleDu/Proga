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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2(User users)
        {
            //Вывод даных на экран
            InitializeComponent();
            kabinet = users;
            using(avtorEntities2 Kabinet = new avtorEntities2())
            {
                Persona persona = Kabinet.Persona.Where(p => p.kod_persona == kabinet.kod_Person).FirstOrDefault();
                name.Text = persona.Firs_Name;
                Lastname.Text = persona.Last_Name;
                Data.Text = Convert.ToString(persona.age);
            }
            
        }
        User kabinet;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow back = new MainWindow();
            back.Show();
            Hide();
        }
    }
}
