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
    /// Interaction logic for SmokehouseSkeleton.xaml
    /// </summary>
    public partial class SmokehouseSkeleton : UserControl
    {
        public SmokehouseSkeleton()
        {
            InitializeComponent();
            DataContext = new BleakwindBuffet.Data.Entrees.SmokehouseSkeleton();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new AllItems());

        }

        public void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            var ss = new SmokehouseSkeleton();
            var smoke = new BleakwindBuffet.Data.Entrees.SmokehouseSkeleton();
            ss.DataContext = smoke;
            this.Content = ss;
            if (DataContext is BleakwindBuffet.Data.Order order)
            {
                order.Add(smoke);
            }
        }
    }
}
