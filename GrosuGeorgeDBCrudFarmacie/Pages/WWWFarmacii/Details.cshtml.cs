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
    public class DetailsModel : PageModel
    {
        private readonly GrosuGeorgeDBCrudFarmacie.Models.GrosuGeorgeDBCrudFarmacieContext _context;

        public DetailsModel(GrosuGeorgeDBCrudFarmacie.Models.GrosuGeorgeDBCrudFarmacieContext context)
        {
            _context = context;
        }

        public Farmacii Farmacii { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Farmacii = await _context.Farmacii.FirstOrDefaultAsync(m => m.ID == id);

            if (Farmacii == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
