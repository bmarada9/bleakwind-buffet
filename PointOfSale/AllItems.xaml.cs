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
    /// Interaction logic for AllItems.xaml
    /// </summary>
    public partial class AllItems : UserControl
    {
        public AllItems()
        {
            InitializeComponent();
        }

        private void BriarheartBurger_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new BriarheartBurger());
        }

        private void DoubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new DoubleDraugr());
        }

        private void ThalmorTriple_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new ThalmorTriple());
        }

        private void SmokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new SmokehouseSkeleton());
        }

        private void GardenOrcOmlete_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new GardenOrcOmelette());
        }

        private void ThugsTBone_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new ThugsTBone());
        }

        private void MarkathMilk_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new MarkathMilk());
        }

        private void AretinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new Aretino());
        }

        private void CandlehearthCoffee_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new Candlehearth());
        }

        private void WariorWater_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new WariorWater());
        }

        private void SailorSoda_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new SailorSoda());
        }

        private void VokunSalad_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new VokunSalad());
        }

        private void FriedMirak_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new FriedMirak());
        }

        private void MadOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new MadOtarGrits());
        }

        private void DragonBornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new DragonBornWaffleFries());
        }

        private void PhillyPoacher_Click(object sender, RoutedEventArgs e)
        {
            var Control = this.FindAncestor<Control>();
            Control.ChangeScreen(new PhillyPoacher());
        }
    }

   
}
