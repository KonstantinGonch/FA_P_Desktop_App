using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Univer_Project_Worker_Side
{
    /// <summary>
    /// Логика взаимодействия для WindNuser.xaml
    /// </summary>
    public partial class WindNuser : Window
    {
        public WindNuser()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            string password = tbPassword.Text.ToString();
            string login = tbLogin.Text.ToString();
            if (password.Length < 6 || password.Equals("Ваш Пароль"))
                MessageBox.Show("Минимальный пароль должен состоять минимум из 6 символов");
            else
            {
                if (login.Equals("") || login.Equals("Ваш Логин"))
                {
                    MessageBox.Show("Введите логин");
                }
                else
                {
                    MessageBox.Show(Processor.newUser(login, password ));
                }
            }
        }
    }
}
