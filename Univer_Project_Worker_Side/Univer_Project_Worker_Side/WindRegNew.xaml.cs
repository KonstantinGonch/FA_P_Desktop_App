using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Net;
using System.IO;
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
    /// Логика взаимодействия для WindRegNew.xaml
    /// </summary>
    public partial class WindRegNew : Window
    {
        public WindRegNew()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            string errorlog = "";
            if (tb1.Text.ToString().Length != 6 || !chText(tb1.Text.ToString())) { errorlog += "Недопустимый формат данных в коде подразделения\n"; }
            if (tb2.Text.ToString().Length != 2 || !chText(tb2.Text.ToString())) { errorlog += "Недопустимый формат данных в коде года\n"; }
            if (tb3.Text.ToString().Length != 5 || !chText(tb3.Text.ToString())) { errorlog += "Недопустимый формат данных в порядковом номере\n"; }

            if (errorlog != "")
            {
                MessageBox.Show(errorlog);
            }
            else
            {
                string outputs = "";
                outputs = Processor.regNew(tb1.Text.ToString(), tb2.Text.ToString(), tb3.Text.ToString());
                MessageBox.Show(outputs);
            }
        }

        private bool chText(string text)
        {
            foreach (char ch in text)
            {
                if (!Char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
