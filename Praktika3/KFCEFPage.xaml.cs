using Praktika3.KFCDataSetTableAdapters;
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

namespace Praktika3
{
    public partial class KFCEFPage : Page
    {
        KFCEntities buyers = new KFCEntities();
        public KFCEFPage()
        {
            InitializeComponent();
            BuyersEFGrd.ItemsSource = buyers.buyers.ToList();
        }
    }
}
