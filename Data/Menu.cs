using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using Size = BleakwindBuffet.Data.Enums.Size;
using Flavor = BleakwindBuffet.Data.Enums.SodaFlavor;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entree = new List<IOrderItem>();
            entree.Add(new BriarheartBurger());
            entree.Add(new DoubleDraugr());
            entree.Add(new GardenOrcOmelette());
            entree.Add(new PhillyPoacher());
            entree.Add(new SmokehouseSkeleton());
            entree.Add(new ThalmorTriple());
            entree.Add(new ThugsTBone());

            return entree;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            foreach(Size s in Enum.GetValues(typeof(Size)))
            {
                sides.Add(new DragonBornWaffleFries()
                {
                    Size = s
                });
                sides.Add(new FriedMiraak()
                {
                    Size = s
                });
                sides.Add(new MadOtarGrits()
                {
                    Size = s
                });
                sides.Add(new VokunSalad()
                {
                    Size = s
                });
            }

            return sides;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                drinks.Add(new AretinoAppleJuice(){
                    Size = s
                });
                drinks.Add(new CandlehearthCoffe()
                {
                    Size = s
                });
                drinks.Add(new MarkarthMilk()
                {
                    Size = s
                });
                foreach(Flavor f in Enum.GetValues(typeof(Flavor)))
                {
                    drinks.Add(new SailorsSoda()
                    {
                        Size = s,
                        Flavor = f
                    });
                }
                
                drinks.Add(new WarriorWater()
                {
                    Size = s
                });
            }
            return drinks;
        }

        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();

            fullMenu.Add((IOrderItem)Entrees());
            fullMenu.Add((IOrderItem)Drinks());
            fullMenu.Add((IOrderItem)Sides());
            return fullMenu;
        }
    }
}
