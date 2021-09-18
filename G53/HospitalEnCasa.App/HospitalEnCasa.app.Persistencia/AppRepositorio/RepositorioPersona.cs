using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly Contexto _contexto;

        public RepositorioPersona(Contexto contexto){
            _contexto = contexto;
        }
        public Persona agregarPersona(Persona persona)
        {
            var personaNueva = _contexto.Add(persona).Entity;
            _contexto.SaveChanges();
            return personaNueva;
        }

        public Persona editarPersona(Persona persona)
        {
            Persona personaEncontrada = _contexto.Personas.Where(p => p.cedula == persona.cedula).FirstOrDefault();
            if(personaEncontrada!=null){
                personaEncontrada.nombre = persona.nombre;
                personaEncontrada.edad = persona.edad;
                personaEncontrada.genero = persona.genero;
                personaEncontrada.cedula = persona.cedula;  //Cuidado
                _contexto.SaveChanges();
            }
            return personaEncontrada;
        }

        public void EliminarPersona(int cedula)
        {
            Persona personaEncontrada = _contexto.Personas.Where(p => p.cedula == cedula).FirstOrDefault();
            if(personaEncontrada!=null){
                _contexto.Remove(personaEncontrada);
                _contexto.SaveChanges();
            }
            return;
        }

        public Persona obtenerPersona(int cedula)
        {
            Persona personaEncontrada = _contexto.Personas.Where(p => p.cedula == cedula).FirstOrDefault();
            return personaEncontrada;
        }

        public IEnumerable<Persona> obtenerPersonas()
        {
            return _contexto.Personas;
        }
    }
}