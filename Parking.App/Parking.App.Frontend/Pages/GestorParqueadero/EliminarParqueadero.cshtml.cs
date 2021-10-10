using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Parking.App.Frontend
{
    public class EliminarParqueaderoModel : PageModel
    {
        private readonly IRepositorioParqueadero repositorioParqueadero;
        public Parqueadero parqueadero {get; set; }

        public EliminarParqueaderoModel(IRepositorioParqueadero repositorioParqueadero){
            this.repositorioParqueadero = repositorioParqueadero;
        }
        public void OnGet(int Id)
        {
            parqueadero = repositorioParqueadero.getParqueadero(Id);
        }

        public IActionResult OnPost(Parqueadero parqueadero){
            try{
                repositorioParqueadero.removeParqueadero(parqueadero.Id);
                return RedirectToPage("./ListarParqueadero");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
