using System;
using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        private readonly Contexto _contexto;

        public RepositorioHistoria(Contexto contexto){
            this._contexto = contexto;
        }        
        
        public Historia addHistoria(Historia historia)
        {
            Historia historiaNueva = _contexto.Add(historia).Entity;
            _contexto.SaveChanges();
            return historiaNueva;
        }

        public Historia editHistoria(Historia historia)
        {
            Historia historiaAEditar = _contexto.Historias.FirstOrDefault(h => h.Id == historia.Id);
            if(historiaAEditar != null){
                historiaAEditar.anotacion = historia.anotacion;
                historiaAEditar.fecha = historia.fecha;
                _contexto.SaveChanges();
            }
            return historiaAEditar;
        }

        public IEnumerable<Historia> getAllHistoria()
        {
            return _contexto.Historias;
        }

        public Historia getHistoria(int Id)
        {
            return _contexto.Historias.FirstOrDefault(h => h.Id == Id);
        }

        public IEnumerable<Historia> getHistoriaByMedico(Medico medico)
        {
            IEnumerable<Historia> historias = _contexto.Historias.Where(h => h.anotacion.medico.Id == medico.Id);
            return historias;
        }

        public IEnumerable<Historia> getHistoriaByMedicoFecha(Medico medico, DateTime inicial, DateTime final)
        {
            IEnumerable<Historia> historias = _contexto.Historias.Where(h => h.anotacion.medico.Id == medico.Id &
            h.fecha >= inicial & h.fecha <= final);
            return historias;
        }

        public IEnumerable<Historia> getHistoriaByPaciente(Paciente paciente)
        {
            IEnumerable<Historia> historias = _contexto.Historias.Where(h => h.anotacion.paciente.Id == paciente.Id);
            return historias;
        }

        public void removeHistoria(int Id)
        {
            Historia historia = _contexto.Historias.FirstOrDefault(x => x.Id == Id);
            if(historia != null){
                _contexto.Historias.Remove(historia);
                _contexto.SaveChanges();
            }
        }
    }
}