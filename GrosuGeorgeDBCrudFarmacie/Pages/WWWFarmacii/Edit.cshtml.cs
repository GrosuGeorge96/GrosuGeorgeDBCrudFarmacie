using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GrosuGeorgeDBCrudFarmacie.Models;
using Grosu_George.Models;

namespace GrosuGeorgeDBCrudFarmacie.Pages.WWWFarmacii
{
    public class EditModel : PageModel
    {
        private readonly GrosuGeorgeDBCrudFarmacie.Models.GrosuGeorgeDBCrudFarmacieContext _context;

        public EditModel(GrosuGeorgeDBCrudFarmacie.Models.GrosuGeorgeDBCrudFarmacieContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Farmacii).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FarmaciiExists(Farmacii.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FarmaciiExists(int id)
        {
            return _context.Farmacii.Any(e => e.ID == id);
        }
    }
}
