using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GrosuGeorgeDBCrudFarmacie.Models;
using Grosu_George.Models;

namespace GrosuGeorgeDBCrudFarmacie.Pages.WWWFarmacii
{
    public class IndexModel : PageModel
    {
        private readonly GrosuGeorgeDBCrudFarmacie.Models.GrosuGeorgeDBCrudFarmacieContext _context;

        public IndexModel(GrosuGeorgeDBCrudFarmacie.Models.GrosuGeorgeDBCrudFarmacieContext context)
        {
            _context = context;
        }

        public IList<Farmacii> Farmacii { get;set; }

        public async Task OnGetAsync()
        {
            Farmacii = await _context.Farmacii.ToListAsync();
        }
    }
}
