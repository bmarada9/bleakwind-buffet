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
    /// Interaction logic for MadOtarGrits.xaml
    /// </summary>
    public partial class MadOtarGrits : UserControl
    {
        public MadOtarGrits()
        {
            InitializeComponent();
            DataContext = new BleakwindBuffet.Data.Sides.MadOtarGrits();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new AllItems());

        }

        public void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            var mog = new MadOtarGrits();
            var grits = new BleakwindBuffet.Data.Sides.MadOtarGrits();
            mog.DataContext = grits;
            this.Content = mog;
            if (DataContext is BleakwindBuffet.Data.Order order)
            {
                order.Add(grits);
            }
        }
    }
}
