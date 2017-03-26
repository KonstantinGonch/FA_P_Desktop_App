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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Univer_Project_Worker_Side
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindRegNew wind = new WindRegNew();
            wind.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WindViewState wind = new WindViewState();
            wind.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WindChState wind = new WindChState();
            wind.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            WindGetReport wind = new WindGetReport();
            wind.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            new WindNuser().Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            try
            {
                Processor.GetGeneralReport();
                MessageBox.Show("Файл загружен успешно");
            }
            catch (Exception ex)
            {
                Processor.Log(ex, "In Getting General Report");
            }
        }
    }
}
