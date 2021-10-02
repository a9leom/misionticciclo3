using System;
using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;
namespace HospitalEnCasa.app.Persistencia{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly Contexto _contexto;
        private readonly Security security;
        public RepositorioMedico(Contexto contexto){
            _contexto = contexto;
            security = new Security();
        }
        public Medico addMedico(Medico medico)
        {
            medico.password = security.GetMD5Hash(medico.password);
            var medicoAdd = _contexto.Add(medico).Entity;
            _contexto.SaveChanges();
            return medicoAdd;
        }

        public Medico editMedico(Medico medico)
        {
            medico.password = security.GetMD5Hash(medico.password);

            var medicoEncontrado = _contexto.Medicos.Where(x => x.Id == medico.Id).FirstOrDefault();

            if(medicoEncontrado != null){
                medicoEncontrado.cedula = medico.cedula;
                medicoEncontrado.nombre = medico.nombre;
                medicoEncontrado.edad = medico.edad;
                medicoEncontrado.genero = medico.genero;
                medicoEncontrado.nombre_hospital =  medico.nombre_hospital;
                medicoEncontrado.tarjeta_profesional = medico.tarjeta_profesional;
                medicoEncontrado.username = medico.username;
                medicoEncontrado.password = medico.password;
                medicoEncontrado.email = medico.email;
                _contexto.SaveChanges();
            }
            return medicoEncontrado;

        }

        public IEnumerable<Medico> getMedicos()
        {
            return _contexto.Medicos;
        }

        public Medico obtenerMedico(int cedula)
        {
            var medicoEncontrado = _contexto.Medicos.Where(x => x.cedula == cedula).FirstOrDefault();
            return medicoEncontrado;
        }

        public void removeMedico(int cedula)
        {
            var medicoEncontrado = _contexto.Medicos.Where(x => x.cedula == cedula).FirstOrDefault();
            if(medicoEncontrado != null){
                _contexto.Medicos.Remove(medicoEncontrado);
                _contexto.SaveChanges();
            }
        }
    }
}