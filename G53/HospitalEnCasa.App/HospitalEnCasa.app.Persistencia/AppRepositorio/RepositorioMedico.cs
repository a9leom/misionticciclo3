using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly Contexto _contexto;

        public RepositorioMedico(Contexto contexto){
            _contexto = contexto;
        }
        public Medico addMedico(Medico medico)
        {
            Medico newMedico = _contexto.Add(medico).Entity;
            _contexto.SaveChanges();
            return newMedico;
        }

        public Medico editMedico(Medico medico)
        {
            Medico medicoEncontrado = _contexto.Medicos.FirstOrDefault(m => m.cedula == medico.cedula);
            if(medico != null){
                medicoEncontrado.cedula = medico.cedula;
                medicoEncontrado.nombre = medico.nombre;
                medicoEncontrado.hospital = medico.hospital;
                medicoEncontrado.genero = medico.genero;
                medicoEncontrado.tarjeta_profesional = medico.tarjeta_profesional;
                medicoEncontrado.edad = medico.edad;

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
            Medico medico = _contexto.Medicos.FirstOrDefault(m => m.cedula == cedula);
            return medico;
        }

        public void removeMedico(int cedula)
        {
            Medico medico = _contexto.Medicos.FirstOrDefault(m => m.cedula == cedula);
            if (medico != null){
                _contexto.Medicos.Remove(medico);
                _contexto.SaveChanges();
            }
        }
    }
}