using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Models;

namespace RealEstate.Pages.Property_Aucations
{
    public class DetailsModel : PageModel
    {
        private readonly RealEstate.Data.RealEstateContext _context;

        public DetailsModel(RealEstate.Data.RealEstateContext context)
        {
            _context = context;
        }

        public Property_Aucation Property_Aucation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Property_Aucation = await _context.Property_Aucation
                .Include(p => p.Customer)
                .Include(p => p.Dealer)
                .Include(p => p.Property).FirstOrDefaultAsync(m => m.Id == id);

            if (Property_Aucation == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
