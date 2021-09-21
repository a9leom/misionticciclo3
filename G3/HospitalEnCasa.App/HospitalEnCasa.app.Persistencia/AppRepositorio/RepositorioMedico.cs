using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly Contexto _contexto;
        
        public RepositorioMedico(Contexto contexto){
            this._contexto = contexto;
        }
        public Medico addMedico(Medico medico)
        {
            Medico newMedico =_contexto.Add(medico).Entity;
            _contexto.SaveChanges();
            return newMedico;
        }

        public Medico editMedico(Medico medico)
        {
            Medico medicoEncontrado = _contexto.Medicos.FirstOrDefault(m => m.Id == medico.Id);
            if(medicoEncontrado != null){
                medicoEncontrado.cedula = medico.cedula;
                medicoEncontrado.nombre = medico.nombre;
                medicoEncontrado.edad = medico.edad;
                medicoEncontrado.genero = medico.genero;
                medicoEncontrado.hospital = medico.hospital;
                medicoEncontrado.tarjeta_profesional = medico.tarjeta_profesional;
                medicoEncontrado.tiempo_experiencia = medico.tiempo_experiencia;
                _contexto.SaveChanges();
            }
            return medicoEncontrado;

        }

        public IEnumerable<Medico> getAllMedicos()
        {
            return _contexto.Medicos;
        }

        public Medico getMedico(int cedula)
        {
            Medico medicoEncontrado = _contexto.Medicos.FirstOrDefault(m => m.cedula == cedula);
            return medicoEncontrado;
        }

        public void removeMedico(int cedula)
        {
            Medico medicoEncontrado = _contexto.Medicos.FirstOrDefault(m => m.cedula == cedula);
            if(medicoEncontrado != null){
                _contexto.Medicos.Remove(medicoEncontrado);
                _contexto.SaveChanges();
            }
        }
    }
}