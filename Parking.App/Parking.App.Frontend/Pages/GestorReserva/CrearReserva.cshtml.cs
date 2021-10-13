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
    public class CrearReservaModel : PageModel
    {
        private readonly IRepositorioReserva repositorioReserva;
        private readonly IRepositorioVehiculo repositorioVehiculo;
        public Reserva reserva { get; set; }
        public List<SelectListItem> vehiculos { get; set; }
        public int IdVehiculo { get; set; }

        public String Mensaje { get; set;}
               
        public CrearReservaModel(IRepositorioReserva repositorioReserva, IRepositorioVehiculo repositorioVehiculo)
        {
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
        public void OnGet()
        {
            
        }

        public IActionResult OnPost(Reserva reserva, int IdVehiculo)
        {
            Vehiculo vehiculo = repositorioVehiculo.getVehiculo(IdVehiculo);

            Reserva nuevoReserva = new Reserva(){

                Espacio = reserva.Espacio,
                Vehiculo = vehiculo,
                Hora_Entrada = reserva.Hora_Entrada,
                Hora_Salida = reserva.Hora_Salida,
                Estado_Reserva = reserva.Estado_Reserva,
            };
           
            if (ModelState.IsValid)
            {
                Reserva reservaSolicitado = repositorioReserva.addReserva(nuevoReserva);
                if(reservaSolicitado!=null){
                    return RedirectToPage("./ListarReserva");
                }
                else{
                    
                    Mensaje = "El espacio se encuentra ocupado o el vehiculo ya se encuentr asignado a un parquedero";
                    
                    Console.WriteLine(Mensaje);
                    return Page();
                }
            }
            else{
                return Page();
            }
        }
    }
}
