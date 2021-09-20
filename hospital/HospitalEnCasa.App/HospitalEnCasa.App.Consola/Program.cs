using System;
using HospitalEnCasa.app.Dominio;
using HospitalEnCasa.app.Persistencia;


namespace HospitalEnCasa.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el nombre");
            string name = Console.ReadLine();  
            Console.WriteLine("Escriba la edad");
            int year = Convert.ToInt32(Console.ReadLine());
            Persona obj = new Persona(){
                
                nombre = name,             
                edad = year
            };
            
            var context= new Contexto();
            context.Add(obj);
            
            context.SaveChanges();
            Console.WriteLine(obj.nombre);

                    //Consultar
            var personas = context.Personas;
        
            foreach(var persona in personas){
                Console.WriteLine(persona.nombre+" "+persona.edad);
            }
        }


    }
}
