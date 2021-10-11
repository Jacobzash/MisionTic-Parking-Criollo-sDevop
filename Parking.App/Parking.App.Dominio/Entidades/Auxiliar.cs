using System;
using System.ComponentModel.DataAnnotations;

namespace Parking.App.Dominio
{
    public class Auxiliar:Persona
    {
      public int IdAuxiliar { get; set; }

      [Required,Range(1,3)]
      public string Turno{ get; set; }
    }
}