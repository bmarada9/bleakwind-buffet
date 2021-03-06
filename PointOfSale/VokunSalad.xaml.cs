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
    /// Interaction logic for VokunSalad.xaml
    /// </summary>
    public partial class VokunSalad : UserControl
    {
        public VokunSalad()
        {
            InitializeComponent();
            DataContext = new BleakwindBuffet.Data.Sides.VokunSalad();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new AllItems());

        }

        public void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            var vs = new VokunSalad();
            var salad = new BleakwindBuffet.Data.Sides.VokunSalad();
            vs.DataContext = salad;
            this.Content = vs;
            if (DataContext is BleakwindBuffet.Data.Order order)
            {
                order.Add(salad);
            }
        }
    }
}
