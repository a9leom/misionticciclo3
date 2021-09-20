
namespace HospitalEnCasa.app.Dominio{
    public class Paciente:Persona{
        public int latitud { get; set; }
        public int longitud { get; set; }
        public Medico medico_asignado { get; set;}
    }
}