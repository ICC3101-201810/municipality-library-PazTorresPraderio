using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using ClassLibrary1;

namespace Lab10
{
    public static class RegistroCivil
    {
        [DllImport("ClassLibrary1.dll")] 
        private static extern Object ClassLibrary_ (ClassLibrary1.Person person, ClassLibrary1.Car car , ClassLibrary1.Address address);
        public static List<ClassLibrary1.Person> persona;
     
        public static void AddPersontoDataBase(ClassLibrary1.Person person)
        {
            persona.Add(person);
        }
        
        
    }
}
