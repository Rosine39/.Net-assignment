using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Products.Data;
using Products.Models;

namespace Products.Pages_ItemPages
{
    public class IndexModel : PageModel
    {
        private readonly Products.Data.ItemContext _context;

        public IndexModel(Products.Data.ItemContext context)
        {
            _context = context;
        }

        public IList<Items> Items { get;set; }

        public async Task OnGetAsync()
        {
            Items = await _context.Items.ToListAsync();
        }
    }
}
