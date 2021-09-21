using System;
using System.Collections.Generic;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public interface IRepositorioHistoria{
        IEnumerable<Historia> geAllHistoria();
        Historia getHistoria(int id);
        Historia editHistoria(Historia historia);
        Historia addHistoria(Historia historia);
        void RemoveHistoria(int id);
        IEnumerable<Historia> historiaPorPaciente(Paciente paciente);
        IEnumerable<Historia> historiaPorMedico(Medico medico);
        IEnumerable<Historia> historiaPorEnfermera(Enfermera enfermera);

        IEnumerable<Historia> historiaPorFechaYPaciente(DateTime fecha_inicio, DateTime fecha_final, Paciente paciente);
        
    }
}