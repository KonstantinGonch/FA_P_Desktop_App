using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
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
    /// Логика взаимодействия для WindGetReport.xaml
    /// </summary>
    public partial class WindGetReport : Window
    {
        public WindGetReport()
        {
            InitializeComponent();
        }

        private void btnGetReport_Click(object sender, RoutedEventArgs e)
        {
            var picker1 = dp1 as DatePicker;
            var picker2 = dp2 as DatePicker;
            DateTime? d1 = picker1.SelectedDate;
            DateTime? d2 = picker2.SelectedDate;
            if (d2 == null || d1 == null)
                MessageBox.Show("Введите две даты");
            else
            {
                if (cb.Text.ToString().Equals(""))
                    MessageBox.Show("Выберите критерий");
                else
                {
                    Dictionary<string, int> fields = new Dictionary<string, int>();
                    fields.Add("Дата регистрации заявления", 1);
                    fields.Add("Дата информирования об изготовлении акцизных марок", 2);
                    fields.Add("Дата принятия обязательства", 3);
                    fields.Add("Дата принятия обеспечения", 5);
                    fields.Add("График получения марок", 6);
                    fields.Add("Дата получения марок", 7);
                    fields.Add("Дата закрытия отчета", 8);
                    try
                    {
                        Processor.GetReport(fields[cb.Text.ToString()].ToString(), d1.ToString().Split(' ')[0].Trim(), d2.ToString().Split(' ')[0].Trim());
                        lblStatus.Content = "Загрузка отчета завершена";
                    }
                    catch (Exception ex)
                    {
                        Processor.Log(ex, "Get Report");
                    }
                }
            }
        }
    }
}
