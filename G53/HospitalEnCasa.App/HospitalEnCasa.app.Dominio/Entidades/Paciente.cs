namespace HospitalEnCasa.app.Dominio
{
    public class Paciente:Persona
    {
        public string direccion {get; set; }
        public int latitud {get; set; }
        public int longitud {get; set; }
        public Medico medico {get; set; }
        public Enfermera enfermera {get; set; }

        public Familiar familiar { get; set; }
    }
}