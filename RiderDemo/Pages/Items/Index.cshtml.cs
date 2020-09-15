using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RiderDemo.Data;
using RiderDemo.Models;

namespace RiderDemo.Pages_Items
{
    public class IndexModel : PageModel
    {
        private readonly RiderDemo.Data.ItemsContext _context;

        public IndexModel(RiderDemo.Data.ItemsContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Items.ToListAsync();
        }
    }
}
