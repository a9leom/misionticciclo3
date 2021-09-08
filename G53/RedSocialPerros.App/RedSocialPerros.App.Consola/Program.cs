using System;
using RedSocialPerros.App.Dominio;
using RedSocialPerros.App.Persistencia;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RedSocialPerros.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Contexto objContexto = new Contexto();
            Console.WriteLine("Ingrese 1 si desea agregar los datos por primera vez");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if(opcion ==1){
                Perro objPerroA = new Perro(){
                    nombre = "Simón",
                    edad = 12,
                    raza = "French Poodle"
                };
                objContexto.Add(objPerroA);
                Perro objPerroB = new Perro(){
                    nombre = "Max Power",
                    edad = 2,
                    raza = "Criollo"
                }; 
                objContexto.Add(objPerroB);
                Persona objPersonaA = new Persona(){
                    nombre = "Carlos",
                    edad = 34,
                    perro = objPerroA
                };     
                objContexto.Add(objPersonaA);
                Persona objPersonaB = new Persona(){
                    nombre = "Maria la del barrio",
                    edad = 50,
                    perro = objPerroB
                }; 
                objContexto.Add(objPersonaB);
                Amistad objAmistad = new Amistad(){
                    perroA = objPerroA,
                    perroB = objPerroB,
                    fecha_amistad = "01/01/2019"
                };
                objContexto.Add(objAmistad);
                objContexto.SaveChanges();
            }

            var personas = objContexto.Personas.Include("perro");

            foreach(Persona persona in personas){
                Console.WriteLine("Nombre "+persona.nombre+" Edad "+persona.edad+" Perro "+persona.perro.nombre+" "+persona.perro.edad);
            }
        }
    }
}
