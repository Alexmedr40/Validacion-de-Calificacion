using System;

namespace ValidacionClasificacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBienvenido al Validador de Calificacion \n");
            Console.WriteLine("\nPor favor ingrese una Calificacion: \n");

            int Calificacion=int.Parse(Console.ReadLine());

            if (Calificacion < 70)
            {
                Console.WriteLine("\nREPROBADO \n");

            }
            else if (Calificacion > 70)
            {
                Console.WriteLine("\nAPROVADO \n");
            }
            else if (Calificacion == 70)
            {
                Console.WriteLine("\nREGULAR \n");
            }
            else if (Calificacion == 85 )
            {
                Console.WriteLine("\nBIEN \n");
            }
            else if (Calificacion == 95)
            {
                Console.WriteLine("\nEXCELENTE \n");
            }
            else
            {
                Console.WriteLine("\nEL Valor ingresado no esta dentro de los paramentros de Validacion \n");
            }




        }
    }
}