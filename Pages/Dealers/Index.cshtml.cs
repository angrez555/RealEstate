﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Models;

namespace RealEstate.Pages.Dealers
{
    public class IndexModel : PageModel
    {
        private readonly RealEstate.Data.RealEstateContext _context;

        public IndexModel(RealEstate.Data.RealEstateContext context)
        {
            _context = context;
        }

        public IList<Dealer> Dealer { get;set; }

        public async Task OnGetAsync()
        {
            Dealer = await _context.Dealer.ToListAsync();
        }
    }
}
