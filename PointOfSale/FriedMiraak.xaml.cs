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
    /// Interaction logic for FriedMiraak.xaml
    /// </summary>
    public partial class FriedMiraak : UserControl
    {
        public FriedMiraak()
        {
            InitializeComponent();
            DataContext = new BleakwindBuffet.Data.Sides.FriedMiraak();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new AllItems());

        }

        public void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            var fm = new FriedMiraak();
            var miraak = new BleakwindBuffet.Data.Sides.FriedMiraak();
            fm.DataContext = miraak;
            this.Content = fm;
            if (DataContext is BleakwindBuffet.Data.Order order)
            {
                order.Add(miraak);
            }
        }
    }
}
