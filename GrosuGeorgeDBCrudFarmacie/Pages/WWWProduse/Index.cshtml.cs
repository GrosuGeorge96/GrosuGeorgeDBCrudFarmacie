using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GrosuGeorgeDBCrudFarmacie.Models;
using Grosu_George.Models;

namespace GrosuGeorgeDBCrudFarmacie.Pages.WWWProduse
{
    public class IndexModel : PageModel
    {
        private readonly GrosuGeorgeDBCrudFarmacie.Models.GrosuGeorgeDBCrudFarmacieContext _context;

        public IndexModel(GrosuGeorgeDBCrudFarmacie.Models.GrosuGeorgeDBCrudFarmacieContext context)
        {
            _context = context;
        }

        public IList<Produse> Produse { get;set; }

        public async Task OnGetAsync()
        {
            Produse = await _context.Produse
                .Include(p => p.Farmacie)
                .Include(p => p.Oras).ToListAsync();
        }
    }
}
