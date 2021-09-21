namespace HospitalEnCasa.app.Dominio{
    public class Medico:Persona{
        public string tarjeta_profesional { get; set; }
        public string hospital { get; set; }
        public int tiempo_experiencia { get; set; }
    }
}