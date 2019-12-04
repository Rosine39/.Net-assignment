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
    public class DetailsModel : PageModel
    {
        private readonly Products.Data.ItemContext _context;

        public DetailsModel(Products.Data.ItemContext context)
        {
            _context = context;
        }

        public Items Items { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Items = await _context.Items.FirstOrDefaultAsync(m => m.Id == id);

            if (Items == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
