using System;

namespace Parking.App.Dominio
{
    public class Reserva : Parqueadero 
   {
        public int IdReserva {get; set; }
       
        public Estado_Reserva Estado_Reserva{ get; set; }
             
    }
 }