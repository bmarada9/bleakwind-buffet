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
    /// Interaction logic for ThugsTBone.xaml
    /// </summary>
    public partial class ThugsTBone : UserControl
    {
        public ThugsTBone()
        {
            InitializeComponent();
            DataContext = new BleakwindBuffet.Data.Entrees.ThugsTBone();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new AllItems());

        }

        public void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            var tb = new ThugsTBone();
            var tbone = new BleakwindBuffet.Data.Entrees.ThugsTBone();
            tb.DataContext = tbone;
            this.Content = tb;
            if (DataContext is BleakwindBuffet.Data.Order order)
            {
                order.Add(tbone);
            }
        }
    }
}
