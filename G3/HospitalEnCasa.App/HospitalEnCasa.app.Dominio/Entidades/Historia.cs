using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalEnCasa.app.Dominio{ 
    public class Historia{
        public int Id{ get; set; }
        public Anotacion anotacion{ get; set; }
        [Required(ErrorMessage = "La fecha es obligatoria.")]
        public DateTime fecha{ get; set; }
    }
}