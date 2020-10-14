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
    /// Interaction logic for MarkathMilk.xaml
    /// </summary>
    public partial class MarkathMilk : UserControl
    {
        public MarkathMilk()
        {
            InitializeComponent();
            DataContext = new BleakwindBuffet.Data.Drinks.MarkarthMilk();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new AllItems());

        }

        public void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            var mm = new MarkathMilk();
            var milk = new BleakwindBuffet.Data.Drinks.MarkarthMilk();
            mm.DataContext = milk;
            this.Content = mm;
            if (DataContext is BleakwindBuffet.Data.Order order)
            {
                order.Add(milk);
            }
        }
    }
}
