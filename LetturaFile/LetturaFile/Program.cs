using System;
using System.Collections.Generic;
using System.IO;

namespace LetturaFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\paola\source\repos\Week7\Input.txt";

            StreamReader file = new StreamReader(path);

            string line;

            while((line=file.ReadLine()) != null)
            {
                List<int> lista = new List<int>();

                var elementi = line.Split(" ");


                try
                {
                    foreach (var item in elementi)
                    {
                        if (item == null)
                        {
                            break;
                        }
                        else
                        {
                            int numero = int.Parse(item);
                            lista.Add(numero);
                        }
                    }

                    foreach (var item in lista)
                    {
                        Console.WriteLine($"{item}");
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Non tutti gli elementi del file sono dei numeri!");
                }

   
            }


        }
    }
}
