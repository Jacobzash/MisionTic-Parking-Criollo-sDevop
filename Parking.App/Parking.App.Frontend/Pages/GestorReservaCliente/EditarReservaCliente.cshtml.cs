using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.App.Frontend.Pages
{
    public class EditarReservaClienteModel : PageModel
    {

        private readonly IRepositorioReserva repositorioReserva;
        private readonly IRepositorioVehiculo repositorioVehiculo;
        public Reserva reserva { get; set; }
        public List<SelectListItem> vehiculos { get; set; }
        public int IdVehiculo { get; set; }
               
        public EditarReservaClienteModel(IRepositorioReserva repositorioReserva, IRepositorioVehiculo repositorioVehiculo){
            this.repositorioReserva = repositorioReserva;
            this.repositorioVehiculo = repositorioVehiculo;
            reserva = new Reserva();
            vehiculos = repositorioVehiculo.getAllVehiculo().Select(
                r => new SelectListItem
                {
                    Text = r.Placa,
                    Value = Convert.ToString(r.Id)
                }
            ).ToList();
        }
        public void OnGet(int Id)
        {
           reserva = repositorioReserva.getReserva(Id);
        }

        public IActionResult OnPost(Reserva reserva, int IdVehiculo){
            if (ModelState.IsValid)
            {
                try
                {
                    Vehiculo vehiculo = repositorioVehiculo.getVehiculo(IdVehiculo);

                    reserva.Vehiculo = vehiculo;

                     repositorioReserva.editReserva(reserva);


                    return RedirectToPage("./ListarReservaCliente");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
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
