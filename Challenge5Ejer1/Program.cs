using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5Ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Saludar();
            Console.WriteLine();

            Estudiante estudiante = new Estudiante();
            estudiante.SetEdad(31);
            estudiante.Saludar();
            estudiante.VerEdad();
            estudiante.Estudiar();
            Console.WriteLine();

            Profesor profesor = new Profesor();
            profesor.SetEdad(31);
            profesor.Saludar();
            profesor.Explicar();


            Console.ReadKey();
        }
    }
}
