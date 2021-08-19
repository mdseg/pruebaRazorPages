using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PesoApp.Datos;
using PesoApp.Modelos;

namespace PesoApp.Pages.Registros
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public IndexModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Registro> Registros { get; set;}

        public async Task OnGet()
        {
            Registros = await _contexto.Registro.ToListAsync();
        }
    }
}
