using System;

namespace Numeri_complessi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci parte reale del primo numero:");
            double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("Inserisci parte immaginaria del primo numero:");
            double.TryParse(Console.ReadLine(), out double b);
            Console.WriteLine("Inserisci parte reale del secondo numero:");
            double.TryParse(Console.ReadLine(), out double c);
            Console.WriteLine("Inserisci parte immaginaria del secondo numero:");
            double.TryParse(Console.ReadLine(), out double d);


            NumeroComplesso primo = new NumeroComplesso() { ParteImmaginaria = b, ParteReale = a };
            NumeroComplesso secondo = new NumeroComplesso() { ParteImmaginaria = d, ParteReale = c };

            try
            {
                NumeroComplesso risultato = primo.Divisione(secondo);
                Console.WriteLine(risultato);
               
            }
            catch(NumeroComplessoException ncex)
            {
                Console.WriteLine(ncex.Message);
                Console.WriteLine($"Dividendo: {ncex.PrimoOperatore} - Divisore:{ncex.SecondoOperatore}");
            }


        }
    }
}
