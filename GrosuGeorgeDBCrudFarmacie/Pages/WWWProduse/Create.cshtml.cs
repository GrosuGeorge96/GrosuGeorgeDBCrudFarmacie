using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GrosuGeorgeDBCrudFarmacie.Models;
using Grosu_George.Models;

namespace GrosuGeorgeDBCrudFarmacie.Pages.WWWProduse
{
    public class CreateModel : PageModel
    {
        private readonly GrosuGeorgeDBCrudFarmacie.Models.GrosuGeorgeDBCrudFarmacieContext _context;

        public CreateModel(GrosuGeorgeDBCrudFarmacie.Models.GrosuGeorgeDBCrudFarmacieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FarmaciiID"] = new SelectList(_context.Farmacii, "ID", "farmacieAdr");
        ViewData["OrasID"] = new SelectList(_context.Oras, "ID", "orasDen");
            return Page();
        }

        [BindProperty]
        public Produse Produse { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produse.Add(Produse);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}