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
    /// Interaction logic for AretinoAppleJuice.xaml
    /// </summary>
    public partial class AretinoAppleJuice : UserControl
    {
        public AretinoAppleJuice()
        {
            InitializeComponent();
            DataContext = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new AllItems());

        }

        public void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            var aa = new AretinoAppleJuice();
            var juice = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
            aa.DataContext = juice;
            this.Content = aa;
            if (DataContext is BleakwindBuffet.Data.Order order)
            {
                order.Add(juice);
            }
        }
    }
}
