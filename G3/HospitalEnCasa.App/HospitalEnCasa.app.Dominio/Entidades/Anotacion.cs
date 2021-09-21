namespace HospitalEnCasa.app.Dominio
{
    public class Anotacion
    {
        public int Id { get; set; }
        public Paciente paciente { get; set; }
        public Medico medico {get; set; }
        public Enfermera enfermera{get; set; }
        public string descripcion {get; set; }
        public string formula_medica {get; set; }
    }
}