using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoEscolaPDC.DAO;

namespace AutoEscolaPDC.Pages.Alunos
{
    public class IndexModel : PageModel
    {
        private readonly AutoEscolaPDC.DAO.AutoEscolaPDCContext _context;

        public IndexModel(AutoEscolaPDC.DAO.AutoEscolaPDCContext context)
        {
            _context = context;
        }

        public IList<Aluno> Aluno { get;set; }

        public async Task OnGetAsync()
        {
            Aluno = await _context.Alunos.ToListAsync();
        }
    }
}
