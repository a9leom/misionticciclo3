using System.Collections.Generic;

namespace HospitalEnCasa.app.Persistencia{
    public interface IRepositorioMedico{
        Medico addMedico(Medico medico);
        Medico editMedico(Medico medico);
        void removeMedico(int cedula);
        IEnumerable<Medico> getMedicos();
        
    }
}