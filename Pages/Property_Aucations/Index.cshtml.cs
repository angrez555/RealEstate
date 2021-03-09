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
    public class IndexModel : PageModel
    {
        private readonly RealEstate.Data.RealEstateContext _context;

        public IndexModel(RealEstate.Data.RealEstateContext context)
        {
            _context = context;
        }

        public IList<Property_Aucation> Property_Aucation { get;set; }

        public async Task OnGetAsync()
        {
            Property_Aucation = await _context.Property_Aucation
                .Include(p => p.Customer)
                .Include(p => p.Dealer)
                .Include(p => p.Property).ToListAsync();
        }
    }
}
