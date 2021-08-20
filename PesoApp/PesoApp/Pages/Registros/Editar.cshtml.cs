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
    public class EditarModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public EditarModel(ApplicationDbContext contexto)
        {
            this._contexto = contexto;
        }

        [BindProperty]
        public Registro Registro { get; set; }

        public async void OnGet(int id)
        {
            Registro = await _contexto.Registro.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var RegistroDesdeDb = await _contexto.Registro.FindAsync(Registro.Id);
                RegistroDesdeDb.Peso = Registro.Peso;
                RegistroDesdeDb.Cadera = Registro.Cadera;
                RegistroDesdeDb.Cintura = Registro.Cintura;
                RegistroDesdeDb.Pierna = Registro.Pierna;

                await _contexto.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
