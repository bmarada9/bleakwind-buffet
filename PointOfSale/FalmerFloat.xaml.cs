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
    /// Interaction logic for CustomizeFalmorFloat.xaml
    /// </summary>
    public partial class FalmerFloat : UserControl
    {
        public FalmerFloat()
        {
            InitializeComponent();
            DataContext = new BleakwindBuffet.Data.Drinks.FalmerFloat();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new AllItems());
        }

        public void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            var ff = new FalmerFloat();
            var falmer = new BleakwindBuffet.Data.Drinks.FalmerFloat();
            ff.DataContext = falmer;
            this.Content = ff;
            if (DataContext is BleakwindBuffet.Data.Order order)
            {
                order.Add(falmer);
            }
        }
    }
}
