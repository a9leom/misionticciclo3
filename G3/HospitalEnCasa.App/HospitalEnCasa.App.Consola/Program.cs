using System;
using HospitalEnCasa.app.Dominio;
using HospitalEnCasa.app.Persistencia;
using System.Linq;

namespace HospitalEnCasa.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Contexto _contexto = new Contexto();
            var historias = _contexto.historias
                .Join(
                    _contexto.anotaciones,
                    historia => new {iD = historia.anotacion},
                    anotacion => new {Id = anotacion.Id},
                    (historia,anotacion) => 
                    new {
                        historiaID = historia.Id,
                        fecha = historia.fecha,
                        enfermera = anotacion.enfermera,
                        paciente = anotacion.paciente,
                        medico = anotacion.medico,
                        descripcion = anotacion.descripcion,
                        formula_medica = anotacion.formula_medica,
                    }

                ).toList();

            foreach (var historia in historias){
                Console.WriteLine(historia);
            }
        }


    }
}
