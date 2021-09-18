using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{ 
    public class Medico:Persona{
        public string nombre_hospital { get; set; }
        public string tarjeta_profesional { get; set;}
    }
}