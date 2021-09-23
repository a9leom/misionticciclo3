using System;

namespace HospitalEnCasa.app.Dominio{
    public class Historia{
        public int Id { get; set; }
        public Anotacion anotacion {get; set; }
        public DateTime fecha { get; set; }
    }
}