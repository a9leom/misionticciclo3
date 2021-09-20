using System.Collections.Generic;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public interface IRepositorioPersona{
        IEnumerable<Persona> obtenerPersonas();
        void EliminarPersona(int cedula);
        Persona obtenerPersona(int cedula);
        Persona editarPersona(Persona persona);
        Persona agregarPersona(Persona persona);

    }

}