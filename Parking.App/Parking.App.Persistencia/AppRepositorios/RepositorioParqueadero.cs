using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Parking.App.Dominio;
using Parking.App.Persistencia;

namespace Parking.app.Persistencia
{
    public class RepositorioParqueadero : IRepositorioParqueadero
    {
        private readonly AppContext _contexto;

        public RepositorioParqueadero(AppContext contexto){
            this._contexto = contexto;
        }
        public Parqueadero addParqueadero(Parqueadero Parqueadero)
        {
            /*Parqueadero nuevoParqueadero = _contexto.Add(Parqueadero).Entity;
            _contexto.SaveChanges();
            return nuevoParqueadero;
            */

            Parqueadero asigEspacio = _contexto.Parqueaderos.FirstOrDefault(
                e => e.Espacio == Parqueadero.Espacio &&
                 Parqueadero.Hora_Entrada >= e.Hora_Entrada &&
                Parqueadero.Hora_Entrada < e.Hora_Entrada.AddMinutes(30)                 
                );
            
            Parqueadero asigVehiculo = _contexto.Parqueaderos.FirstOrDefault(
                e => e.Vehiculo.Id == Parqueadero.Vehiculo.Id &&
                Parqueadero.Hora_Entrada >= e.Hora_Entrada &&
                Parqueadero.Hora_Entrada < e.Hora_Entrada.AddMinutes(30)                 
                );

            if(asigEspacio == null && asigVehiculo == null ){
                Parqueadero nuevoParqueadero = _contexto.Add(Parqueadero).Entity;
                _contexto.SaveChanges();
                return nuevoParqueadero;                
            }
            else{
                return null;
            }
        }


        public Parqueadero editParqueadero(Parqueadero Parqueadero)
        {
            Parqueadero ParqueaderoAEditar = _contexto.Parqueaderos.Include("Vehiculo").FirstOrDefault(f => f.Id == Parqueadero.Id);
            if(ParqueaderoAEditar != null){
                ParqueaderoAEditar.Vehiculo = Parqueadero.Vehiculo;
                ParqueaderoAEditar.Espacio =Parqueadero.Espacio;
                ParqueaderoAEditar.Hora_Entrada = Parqueadero.Hora_Entrada;
                ParqueaderoAEditar.Hora_Salida = Parqueadero.Hora_Salida;
                              
                
                _contexto.SaveChanges();
            }
            return ParqueaderoAEditar;
        }

        public IEnumerable<Parqueadero> getAllParqueaderos()
        {
            return _contexto.Parqueaderos.Include("Vehiculo");
        }

        public Parqueadero getParqueadero(int Id)
        {
             Parqueadero Parqueadero = _contexto.Parqueaderos.Include("Vehiculo").FirstOrDefault(x => x.Id == Id);
             return Parqueadero;
        }

        public void removeParqueadero(int Id)
        {
            Parqueadero Parqueadero = _contexto.Parqueaderos.FirstOrDefault(x => x.Id == Id);
            if(Parqueadero != null){
                _contexto.Parqueaderos.Remove(Parqueadero);
                _contexto.SaveChanges();
            }

        }

        
    }
}