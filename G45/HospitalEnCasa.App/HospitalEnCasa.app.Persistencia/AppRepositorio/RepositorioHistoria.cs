using System;
using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        private readonly Contexto _contexto;
        public RepositorioHistoria(Contexto context){
            this._contexto = context;
        }
        public Historia addHistoria(Historia historia)
        {
            Historia historiaNueva = _contexto.Add(historia).Entity;
            _contexto.SaveChanges();
            return historiaNueva;
        }

        public Historia editHistoria(Historia historia)
        {
            Historia historiaEncontrada = _contexto.Historias.FirstOrDefault(h => h.Id == historia.Id);
            if(historiaEncontrada != null){
                historiaEncontrada.anotacion = historia.anotacion;
                historiaEncontrada.fecha = historia.fecha;
                _contexto.SaveChanges();
            }
            return historiaEncontrada;
        }

        public IEnumerable<Historia> getAllHistorias()
        {
            return _contexto.Historias;
        }

        public Historia getHistoria(int Id)
        {
            return _contexto.Historias.FirstOrDefault(h => h.Id == Id);
        }

        public IEnumerable<Historia> getHistoriaByMedico(Medico medico)
        {
            return _contexto.Historias.Where(h => h.anotacion.medico.Id == medico.Id);
        }

        public IEnumerable<Historia> getHistoriaByPaciente(Paciente paciente)
        {
            return _contexto.Historias.Where(h => h.anotacion.paciente.Id == paciente.Id);
        }

        public IEnumerable<Historia> getHistoriaByPacienteAndFecha(Paciente paciente, DateTime fecha_inicio, DateTime fecha_final)
        {
            return _contexto.Historias.Where(h => h.anotacion.paciente.Id == paciente.Id && h.fecha >= fecha_inicio && h.fecha<= fecha_final);
        }

        public void RemoveHistoria(int Id)
        {
            Historia historiaEncontrada = _contexto.Historias.FirstOrDefault(h => h.Id == Id);
            if(historiaEncontrada != null){
                _contexto.Historias.Remove(historiaEncontrada);
                _contexto.SaveChanges();
            }
        }
    }
}