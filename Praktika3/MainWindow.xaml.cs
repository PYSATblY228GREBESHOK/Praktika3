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
using Praktika3.KFCDataSetTableAdapters;

namespace Praktika3
{
    public partial class MainWindow : Window
    {
        buyersTableAdapter kfc = new buyersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            KFCGrd.ItemsSource = kfc.GetFullInfo();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            KFCGrd.Columns[0].Visibility = Visibility.Collapsed;
            KFCGrd.Columns[1].Header = "Имя покупателя";
            KFCGrd.Columns[2].Header = "Отчество";
            KFCGrd.Columns[3].Header = "Фамилия";
            KFCGrd.Columns[4].Visibility = Visibility.Collapsed;
            KFCGrd.Columns[5].Header = "Заказ";
            KFCGrd.Columns[6].Header = "Дата заказа";
            KFCGrd.Columns[7].Header = "Счет заказа";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KFCEFPage KFCEFPage = new KFCEFPage();

            this.Content = KFCEFPage;

        }
    }
}
