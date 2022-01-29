using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GrosuGeorgeDBCrudFarmacie.Models;
using Grosu_George.Models;

namespace GrosuGeorgeDBCrudFarmacie.Pages.WWWOras
{
    public class DetailsModel : PageModel
    {
        private readonly GrosuGeorgeDBCrudFarmacie.Models.GrosuGeorgeDBCrudFarmacieContext _context;

        public DetailsModel(GrosuGeorgeDBCrudFarmacie.Models.GrosuGeorgeDBCrudFarmacieContext context)
        {
            _context = context;
        }

        public Oras Oras { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Oras = await _context.Oras.FirstOrDefaultAsync(m => m.ID == id);

            if (Oras == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
