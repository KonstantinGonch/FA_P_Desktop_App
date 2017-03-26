using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Логика взаимодействия для VerificationWindow.xaml
    /// </summary>
    public partial class VerificationWindow : Window
    {
        public VerificationWindow()
        {
            InitializeComponent();
        }

        private void btnGetReport_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text.ToString();
            string password = tbPassword.Text.ToString();
            string response = Processor.Enter(login, password);
            if (response=="OK")
            {
                Processor.CLogin = login;
                Processor.CPassword = password;
                new MainWindow().Show();
            }
            else
            {
                MessageBox.Show(response);
            }
        }
    }
}
