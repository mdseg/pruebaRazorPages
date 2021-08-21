using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PesoApp.Datos;
using PesoApp.Modelos;

namespace PesoApp.Pages.Registros
{
    public class DetallesModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public DetallesModel(ApplicationDbContext contexto)
        {
            this._contexto = contexto;
        }

        [BindProperty]
        public Registro Registro { get; set; }

        public async Task OnGet(int id)
        {
            Registro = await _contexto.Registro.FindAsync(id);
        }
    }
}
