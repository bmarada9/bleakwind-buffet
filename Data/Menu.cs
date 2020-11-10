/*
 * Author: Bhargav Marada
 * Class name: Menu.cs
 * Purpose: a class that contains the items on the menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using Size = BleakwindBuffet.Data.Enums.Size;
using Flavor = BleakwindBuffet.Data.Enums.SodaFlavor;
using System.Linq;
using System.IO;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        public static string[] Category
        {
            get => new string[] { "Entree", "Side", "Drink" };
        }

        /// <summary>
        /// list of entrees
        /// </summary>
        /// <returns> IEnumerable<IOrderItem> containing an instance of all available entrees offered by Bleakwind Buffet </returns>
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

        /// <summary>
        /// list of sides
        /// </summary>
        /// <returns> IEnumerable<IOrderItem> containing an instance of all available sides offered by Bleakwind Buffet </returns>
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

        /// <summary>
        /// list of drinks
        /// </summary>
        /// <returns> IEnumerable<IOrderItem> containing an instance of all available drinks offered by Bleakwind Buffet </returns>
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

        /// <summary>
        /// menu
        /// </summary>
        /// <returns> an IEnumerable<IOrderItem> containing all of the items on the menu </returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();

            fullMenu.AddRange(Entrees());
            fullMenu.AddRange(Drinks());
            fullMenu.AddRange(Sides());
            return fullMenu;
        }


        public static IEnumerable<IOrderItem> Search(string item, IEnumerable<IOrderItem> fullMenu)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (item == null) return fullMenu;

            foreach (IOrderItem menuItem in fullMenu)
            {
                if (menuItem.ToString() != null && menuItem.ToString().Contains(item))
                {
                    results.Add(menuItem);
                }
            }

            return results;
        }

        /// <summary>
        /// method to filter items by category
        /// </summary>
        /// <param name="fullMenu">all items on menu</param>
        /// <param name="menuItem">entree, side, or drink</param>
        /// <returns>a list of filtered items</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> fullMenu, IEnumerable<string> menuItem)
        {
            if (menuItem == null || menuItem.ToString().Length == 0) return fullMenu;
            List<IOrderItem> results = new List<IOrderItem>();

            foreach (IOrderItem item in fullMenu)
            {
                if (item is Entree && menuItem.Contains("Entree"))
                {
                    results.Add(item);
                }

                if (item is Drink && menuItem.Contains("Drink"))
                {
                    results.Add(item);
                }

                if (item is Side && menuItem.Contains("Side"))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filtered results by calories
        /// </summary>
        /// <param name="fullMenu">all items on menu</param>
        /// <param name="min">the minimum range calories</param>
        /// <param name="max">the maximum range calories</param>
        /// <returns>the filtered menu items collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> fullMenu, int? min, int? max)
        {
            if (min == null && max == null) return fullMenu;

            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in fullMenu)
                {
                    if (item.Calories <= max)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in fullMenu)
                {
                    if (item.Calories >= min)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
            foreach (IOrderItem item in fullMenu)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filtered by price
        /// </summary>
        /// <param name="fullMenu">all items on menu</param>
        /// <param name="min">The minimum range price</param>
        /// <param name="max">the maximum range price</param>
        /// <returns>the filtered menu items collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> fullMenu, double? min, double? max)
        {
            if (min == null && max == null) return fullMenu;

            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in fullMenu)
                {
                    if (item.Price <= max)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in fullMenu)
                {
                    if (item.Price >= min)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            foreach (IOrderItem item in fullMenu)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
