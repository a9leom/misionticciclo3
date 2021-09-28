using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalEnCasa.app.Dominio
{
    public class Persona{

        public int Id { get; set; }
        public int cedula { get; set; }
        public string nombre{ get;set;}
        public int edad{get; set;}
        public Genero genero{ get; set; }
        [Required(ErrorMessage = "El email es requerido."),DataType(DataType.EmailAddress,ErrorMessage = "El dato de ser un email")]
        public string email{ get; set;}
        [Required(ErrorMessage = "El nombre de usuario es requerido."),RegularExpression(@"^\S*$", ErrorMessage = "No se permiten espacios")]
        public string username { get; set; }
        [Required(ErrorMessage = "La contraseña es requerida."),DataType(DataType.Password)]
        public string password { get; set; }
    }
}