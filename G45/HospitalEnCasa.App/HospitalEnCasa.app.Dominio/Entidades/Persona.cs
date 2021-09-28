using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalEnCasa.app.Dominio
{
    public class Persona{

        public int Id { get; set; }
        [Required(ErrorMessage ="La cedula es requerida")]
        public int cedula { get; set; }
        public string nombre{ get;set;}
        public int edad{get; set;}
        public Genero genero{ get; set; }
    }
}