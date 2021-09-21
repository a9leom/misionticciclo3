using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public class RepositorioEnfermera : IRepositorioEnfermera
    {
        public readonly Contexto _contexto;

        public RepositorioEnfermera(Contexto context){
            this._contexto = context;
        }
        public Enfermera addEnfermera(Enfermera enfermera)
        {
            Enfermera newEnfermera = _contexto.Add(enfermera).Entity;
            _contexto.SaveChanges();
            return newEnfermera;
        }

        public Enfermera editEnfermera(Enfermera enfermera)
        {
            Enfermera enfermeraEncontrada = _contexto.Enfermeras.FirstOrDefault(e => e.Id == enfermera.Id);
            if(enfermeraEncontrada != null){
                enfermeraEncontrada.cedula = enfermera.cedula;
                enfermeraEncontrada.nombre = enfermera.nombre;
                enfermeraEncontrada.edad = enfermera.edad;
                enfermeraEncontrada.genero = enfermera.genero;
                enfermeraEncontrada.hospital = enfermera.hospital;
                enfermeraEncontrada.informacion_laboral = enfermera.informacion_laboral;
                _contexto.SaveChanges();
            }
            return enfermeraEncontrada;
        }

        public IEnumerable<Enfermera> getAllEnfermeras()
        {
            return _contexto.Enfermeras;
        }

        public Enfermera getEnfermera(int cedula)
        {
            Enfermera enfermeraEncontrada = _contexto.Enfermeras.FirstOrDefault(e => e.cedula == cedula);
            return enfermeraEncontrada;
        }

        public void removeEnfermera(int cedula)
        {
            Enfermera enfermeraEncontrada = _contexto.Enfermeras.FirstOrDefault(e => e.cedula == cedula);
            if(enfermeraEncontrada != null){
                _contexto.Enfermeras.Remove(enfermeraEncontrada);
                _contexto.SaveChanges();
            }
        }
    }
}