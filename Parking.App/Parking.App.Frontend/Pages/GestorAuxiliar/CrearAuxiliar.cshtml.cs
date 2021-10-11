using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.App.Frontend
{
    public class CrearAuxiliarModel : PageModel
    {
        private IRepositorioAuxiliar repositorioAuxiliar;
        public Auxiliar auxiliar { get; set; }

        public CrearAuxiliarModel(IRepositorioAuxiliar repositorioAuxiliar)
        {
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet()
        {
            Auxiliar auxiliar = new Auxiliar();
        }
        public IActionResult OnPost(Auxiliar auxiliar)
        {
            if (ModelState.IsValid)
            {
                try{
                repositorioAuxiliar.addAuxiliar(auxiliar);
                return RedirectToPage("./index");
                }
                catch{
                    return RedirectToPage("../Error");
                }
            }
            else
            {
                return Page();
            }

        }

    }
}

