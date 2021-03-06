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
    /// Interaction logic for WarriorWater.xaml
    /// </summary>
    public partial class WarriorWater : UserControl
    {
        public WarriorWater()
        {
            InitializeComponent();
            DataContext = new BleakwindBuffet.Data.Drinks.WarriorWater();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new AllItems());

        }

        public void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            var ww = new WarriorWater();
            var water = new BleakwindBuffet.Data.Drinks.WarriorWater();
            ww.DataContext = water;
            this.Content = ww;
            if (DataContext is BleakwindBuffet.Data.Order order)
            {
                order.Add(water);
            }
        }
    }
}
