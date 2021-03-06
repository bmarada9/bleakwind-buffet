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
    /// Interaction logic for DoubleDraugr.xaml
    /// </summary>
    public partial class DoubleDraugr : UserControl
    {
        public DoubleDraugr()
        {
            InitializeComponent();
            DataContext = new BleakwindBuffet.Data.Entrees.DoubleDraugr();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new AllItems());
        }

        public void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            var dd = new DoubleDraugr();
            var draugr = new BleakwindBuffet.Data.Entrees.DoubleDraugr();
            dd.DataContext = draugr;
            this.Content = dd;
            if (DataContext is BleakwindBuffet.Data.Order order)
            {
                order.Add(draugr);
            }
        }
    }
}
