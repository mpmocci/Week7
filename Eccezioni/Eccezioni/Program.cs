using System;

namespace Eccezioni
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] array = new int[3] { 1, 3, 5 };


            try
            {
                array[3] = 5;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("L'indice inserito è oltre il range dell'array!\n");
            }


            //try
            //{
            //    int[] array = new int[10] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            //    Console.WriteLine("Inserisci la posizione del numero da modificare:\n");
            //    int i = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Inserisci il nuovo numero da inserire:\n");
            //    int numero = int.Parse(Console.ReadLine());

            //    array[i] = numero;
            //}


            //catch (System.FormatException)
            //{
            //    Console.WriteLine("Bisogna inserire un numero!\n");

            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("L'indice inserito è oltre il range dell'array!\n");
            //}

            //catch (ArrayTypeMismatchException)
            //{
            //    Console.WriteLine("Bisogna inserire un numero!\n");

            //}


        }
    }
}
