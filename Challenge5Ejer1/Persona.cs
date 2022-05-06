using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5Ejer1
{
    internal class Persona
    {
        public int edad { get; set; }

        public void Saludar()
        {
            Console.WriteLine("Hola");
        }

        public void SetEdad(int años)
        {
            edad = años;
        }

    }
}
