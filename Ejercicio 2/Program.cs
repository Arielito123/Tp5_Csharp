using System;
using System.Threading;
namespace Ejercicio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Modificar el método anterior para que la leyenda se desplace por la mitad de la pantalla
 de izquierda a derecha como una marquesina*/

            int x = 1,y=40;

          
            Console.ForegroundColor = ConsoleColor.DarkGreen;
         


                while (x <= 40)
                {
                    Console.SetCursorPosition(x, 10);
                    Hola();
                    Thread.Sleep(100);
                    Console.Clear();
                    x++;


                }

                while (y <= 40)
                {
                    Console.SetCursorPosition(y, 10);
                    Hola();
                    Thread.Sleep(100);
                    Console.Clear();
                  
                }

          
           


        }


        static void Hola()
        {
            Console.WriteLine("Este Es Mi primer Metodo en C#");
        }



    }
}
