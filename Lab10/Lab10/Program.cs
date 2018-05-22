using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Person person = null;
            ClassLibrary1.Address addresss = null;
            ClassLibrary1.Car car = null;
            ClassLibrary1.Person parent1 = null;
            ClassLibrary1.Person parent2 = null;
            Console.WriteLine("Bievenido a Registro Civil");
            Console.WriteLine("1. Crear Persona");
            int op1 = Convert.ToInt32(Console.ReadLine());
            if (op1 == 1)
            {
                Console.WriteLine("Ingrese su Nombre :");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su Apellido :");
                string apellido = Console.ReadLine();
                Console.WriteLine("Ingrese su fecha de nacimiento mm/dd/aaaa");
                System.DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Ingrese Rut");
                string rut;
                rut = Convert.ToString(Console.ReadLine());
                person = new ClassLibrary1.Person(nombre, apellido, dateTime, null, rut, parent1, parent2);
                Console.WriteLine("Has sido creado con exito");
                RegistroCivil.AddPersontoDataBase(person);
                

            }


           


     
        }
    }
}
