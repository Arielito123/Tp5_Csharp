using System;

namespace Ejercicio8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Desarrollar un método que reciba un carácter en minúscula y lo devuelva en
mayúsculas. Si el carácter recibido no es una letra, devolver el mismo carácter.*/

            char letra;
            string str = "asd";
            int b;
            while (true)
            {
                Console.Write("ingrese una letra para convertirla: ");
                letra = char.Parse(Console.ReadLine());
                str = letra.ToString();

                foreach (int a in str)
                {
                    if ((a <= 96 || a >= 123))
                    {
                        Console.WriteLine((char)a);
                    }
                    else
                    {
                        b = (a - 32);

                        Console.WriteLine((char)b);
                    }

                }

                Console.ReadKey();
            }

        }




    }
}
