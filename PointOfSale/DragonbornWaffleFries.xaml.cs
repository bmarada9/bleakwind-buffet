﻿using System;
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
    /// Interaction logic for DragonbornWaffleFries.xaml
    /// </summary>
    public partial class DragonbornWaffleFries : UserControl
    {
        public DragonbornWaffleFries()
        {
            InitializeComponent();
            DataContext = new BleakwindBuffet.Data.Sides.DragonBornWaffleFries(); 
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new AllItems());

        }

        public void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            var wf = new DragonbornWaffleFries();
            var fries = new BleakwindBuffet.Data.Sides.DragonBornWaffleFries();
            wf.DataContext = fries;
            this.Content = wf;
            if (DataContext is BleakwindBuffet.Data.Order order)
            {
                order.Add(fries);
            }
        }
    }
}
