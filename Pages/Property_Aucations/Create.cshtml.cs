using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstate.Data;
using RealEstate.Models;

namespace RealEstate.Pages.Property_Aucations
{
    public class CreateModel : PageModel
    {
        private readonly RealEstate.Data.RealEstateContext _context;

        public CreateModel(RealEstate.Data.RealEstateContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Customer_Name");
        ViewData["DealerId"] = new SelectList(_context.Dealer, "Id", "Dealer_Name");
        ViewData["PropertyId"] = new SelectList(_context.Property, "Id", "Area");
            return Page();
        }

        [BindProperty]
        public Property_Aucation Property_Aucation { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Property_Aucation.Add(Property_Aucation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
