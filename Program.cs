using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary < string, double> estudiantesNotas = new Dictionary < string, double> ();

            estudiantesNotas.Add("James", 62);
            estudiantesNotas.Add("Brisa ", 85);
            estudiantesNotas.Add("Marlon" , 73);
            estudiantesNotas.Add("Marta  ", 58);

            string BuscarEstudy = " Brisa";

            if (estudiantesNotas.ContainsKey(BuscarEstudy))
            {
                double Nota = estudiantesNotas[BuscarEstudy];
                Console.WriteLine("La Nota de: " + BuscarEstudy + " es de " + Nota);
            }
            else
            {
                Console.WriteLine("El estudiante no existe ");
            }


        }
    }
}
