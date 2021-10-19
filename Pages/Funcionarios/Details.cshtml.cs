using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoEscolaPDC.DAO;

namespace AutoEscolaPDC.Pages.Funcionarios
{
    public class DetailsModel : PageModel
    {
        private readonly AutoEscolaPDC.DAO.AutoEscolaPDCContext _context;

        public DetailsModel(AutoEscolaPDC.DAO.AutoEscolaPDCContext context)
        {
            _context = context;
        }

        public Funcionario Funcionario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Funcionario = await _context.Funcionarios.FirstOrDefaultAsync(m => m.ID == id);

            if (Funcionario == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
