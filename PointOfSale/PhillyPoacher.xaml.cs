using System;
using System.Collections.Generic;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PhillyPoacher.xaml
    /// </summary>
    public partial class PhillyPoacher : UserControl
    {
        public PhillyPoacher()
        {
            InitializeComponent();
            DataContext = new BleakwindBuffet.Data.Entrees.PhillyPoacher();
        }

        public void Done_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new AllItems());

        }

        public void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            var pp = new PhillyPoacher();
            var philly = new BleakwindBuffet.Data.Entrees.PhillyPoacher();
            pp.DataContext = philly;
            this.Content = pp;
            if (DataContext is BleakwindBuffet.Data.Order order)
            {
                order.Add(philly);
            }
        }
    }
}
