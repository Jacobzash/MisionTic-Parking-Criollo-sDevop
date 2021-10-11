using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.app.Persistencia
{
    public class RepositorioReserva : IRepositorioReserva
    {
        private readonly AppContext _contexto;

        public RepositorioReserva(AppContext contexto){
            this._contexto = contexto;
        }
        public Reserva addReserva(Reserva Reserva)
        {
            Reserva nuevoReserva = _contexto.Add(Reserva).Entity;
            _contexto.SaveChanges();
            return nuevoReserva;
        }


        public Reserva editReserva(Reserva Reserva)
        {
            Reserva ReservaAEditar = _contexto.Reservas.FirstOrDefault(f => f.Id == Reserva.Id);
            if(ReservaAEditar != null){
                ReservaAEditar.Vehiculo = Reserva.Vehiculo;
                ReservaAEditar.Espacio = Reserva.Espacio;
                ReservaAEditar.Hora_Entrada = Reserva.Hora_Entrada;
                ReservaAEditar.Hora_Salida = Reserva.Hora_Salida;
                ReservaAEditar.Estado_Reserva = Reserva.Estado_Reserva;
                                             
                
                _contexto.SaveChanges();
            }
            return ReservaAEditar;
        }

        


        public IEnumerable<Reserva> getAllReservas()
        {
             return _contexto.Reservas.Include("Vehiculo");
        }

       

        public Reserva getReserva(int Id)
        {
             Reserva Reserva = _contexto.Reservas.FirstOrDefault(x => x.Id == Id);
             return Reserva;
        }

        public void removeReserva(int Id)
        {
            Reserva Reserva = _contexto.Reservas.FirstOrDefault(x => x.Id == Id);
            if(Reserva != null){
                _contexto.Reservas.Remove(Reserva);
                _contexto.SaveChanges();
            }

        }

       
    }
}