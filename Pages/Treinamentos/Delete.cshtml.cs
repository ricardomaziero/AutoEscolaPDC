using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoEscolaPDC.DAO;

namespace AutoEscolaPDC.Pages.Treinamentos
{
    public class DeleteModel : PageModel
    {
        private readonly AutoEscolaPDC.DAO.AutoEscolaPDCContext _context;

        public DeleteModel(AutoEscolaPDC.DAO.AutoEscolaPDCContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Treinamento Treinamento { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Treinamento = await _context.Treinamentos
                .Include(t => t.Aluno)
                .Include(t => t.Categoria)
                .Include(t => t.Funcionario).FirstOrDefaultAsync(m => m.ID == id);

            if (Treinamento == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Treinamento = await _context.Treinamentos.FindAsync(id);

            if (Treinamento != null)
            {
                _context.Treinamentos.Remove(Treinamento);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
