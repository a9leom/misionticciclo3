using System;
using System.Collections.Generic;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public interface IRepositorioHistoria{
        IEnumerable<Historia> getAllHistoria();
        Historia addHistoria(Historia historia);
        Historia editHistoria(Historia historia);
        Historia getHistoria(int Id);

        IEnumerable<Historia> getHistoriaByPaciente(Paciente paciente);
        IEnumerable<Historia> getHistoriaByMedico(Medico medico);
        IEnumerable<Historia> getHistoriaByMedicoFecha(Medico medico, DateTime inicial, DateTime final);
        void removeHistoria(int Id);
    }
}