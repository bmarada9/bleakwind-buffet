/*
 * Author: Bhargav Marada
 * Class name: Menu.cs
 * Purpose: a class that contains the items on the menu
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IEnumerable<IOrderItem> items { get; set; }

        /// <summary>
        /// The item being searched for
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Entree Side or Drink
        /// </summary>
        public string[] Category { get; set; }
        public void OnGet(int? calMin, int? calMax, double? priceMin, double? priceMax)
        {

            items = Menu.FullMenu();
            SearchTerms = Request.Query["SearchTerms"];
            Category = Request.Query["Category"];
            if (SearchTerms != null)
            {
                var fullItems = Menu.FullMenu();
                string[] searches = SearchTerms.Split(' ');
                items = items.Where(item => {
                    if (item.ToString() == null) return false;
                    foreach (string term in searches)
                    {
                        if (item.ToString().Contains(term, StringComparison.InvariantCultureIgnoreCase)
                    || item.Description.Contains(term, StringComparison.InvariantCultureIgnoreCase)) return true;
                    }
                    return false;
                });

                
            }
            /*if (Category != null && Category.Length != 0)
            {
                items = items.Where(item => item.Category != null && Categories.Contains(item.Category));
            }*/
            if (calMin != null || calMax != null)
            {
                if (calMin == null)
                {
                    items = items.Where(item => item.Calories <= calMax);
                }
                else if (calMax == null)
                {
                    items = items.Where(item => item.Calories >= calMin);
                }
                else
                {
                    items = items.Where(item => item.Calories >= calMin && item.Calories <= calMax);
                }
            }
            if (priceMin != null || priceMax != null)
            {
                if (priceMin == null)
                {
                    items = items.Where(item => item.Price <= priceMax);
                }
                else if (priceMax == null)
                {
                    items = items.Where(item => item.Price >= priceMin);
                }
                else
                {
                    items = items.Where(item => item.Price >= priceMin && item.Price <= priceMax);
                }
            }
            
        }
        /*items = Menu.FullMenu();
            SearchTerms = Request.Query["SearchTerms"];
            Category = Request.Query["Category"];
            items = Menu.Search(items, SearchTerms);
            items = Menu.FilterByCategory(items, Category);
            items = Menu.FilterByCalories(items, calMin, calMax);
            items = Menu.FilterByPrice(items, priceMin, priceMax);
        }*/
    }
}
