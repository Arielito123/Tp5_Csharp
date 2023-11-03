using System;

namespace Ejercicio12
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Desarrollar un método que permita recibir una cadena de caracteres e informe la
 cantidad de letras que tiene la misma.*/

            string palabra="holaga";



            Cadena(palabra);





        }



        static string Cadena(string Palabra)
        {
            


            Console.WriteLine("Ingrese Palabra");
            Palabra = Console.ReadLine();

            Console.WriteLine("la cantidad de letras es"+ Palabra.Length);


            return Palabra;

        }



    }
}
