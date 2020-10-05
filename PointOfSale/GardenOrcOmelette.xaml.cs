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
    /// Interaction logic for GardenOrcOmelette.xaml
    /// </summary>
    public partial class GardenOrcOmelette : UserControl
    {
        public GardenOrcOmelette()
        {
            InitializeComponent();
            DataContext = new BleakwindBuffet.Data.Entrees.GardenOrcOmelette();
        }

        public void Done_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new AllItems());
        }
    }
}
