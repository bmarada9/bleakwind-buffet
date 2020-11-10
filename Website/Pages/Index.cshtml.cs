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
        public string SearchItem { get; set; }

        /// <summary>
        /// Entree Side or Drink
        /// </summary>
        public string[] SearchType { get; set; }

        public void OnGet(int? calMin, int? calMax, double? priceMin, double? priceMax)
        {
            items = Menu.FullMenu();
            SearchItem = Request.Query["SearchItem"];
            SearchType = Request.Query["SearchType"];
            items = Menu.Search(SearchItem, items);
            items = Menu.FilterByCategory(items, SearchType);
            items = Menu.FilterByCalories(items, calMin, calMax);
            items = Menu.FilterByPrice(items, priceMin, priceMax);
        }
    }
}
