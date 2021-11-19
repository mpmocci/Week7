using System;
using System.Collections.Generic;
using System.Text;
using VigiliContravvenzione.Entities;

namespace VigiliContravvenzione
{
    public class Menu
    {

        private static DbManager dbManager = new DbManager();

        /***MENU
             * Visualizza contravvenzioni
             * Visualizza Contravvenzione trmite matricola vigile
             * Contravvenzioni di un determinato veicolo (targa)
            ********/
        public static void Start()
        {

            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("\n--------------------------------Menu----------------------------");
                Console.WriteLine("1. Mostrare tutte le contravvenzioni.");
                Console.WriteLine("2. Visualizza tutte le contravvenzioni tramite matricola vigile.");
                Console.WriteLine("3. Visualizza tutte le contravvenzioni di un determinato veicolo.");
                Console.WriteLine("0. Exit");
                Console.WriteLine("\n------------------------------------------------------------");



                int choice = Scegli();
                //do
                //{
                //    Console.WriteLine("\nScegli cosa fare!\n");
                //} while (!(int.TryParse(Console.ReadLine(), out choice) && choice >= 0 && choice <= 3));

                switch (choice)
                {
                    case 1:

                        GetAll();
                        break;

                    case 2:

                        GetAllByVigile();
                        break;


                    case 3:

                        GetAllByVeicolo();
                        break;



                    case 0:
                        goOn = false;
                        break;

                    default:
                        Console.WriteLine("Scelta errata!");
                        break;

                }

            }


        }

        private static int Scegli()
        {
            try
            {
                Console.WriteLine("\nScegli cosa fare!\n");
                int scelta = int.Parse(Console.ReadLine());
                return scelta;
            }
            catch
            {
                Console.WriteLine("Errore!!");
                return -1;
            }

        }

            private static void GetAllByVeicolo()
        {
            throw new NotImplementedException();
        }

        private static void GetAllByVigile()
        {
            throw new NotImplementedException();
        }

        private static void GetAll()
        {

            Console.WriteLine("\nLa lista di tutte le contravvenzioni presente nel database è la seguente:\n");
            List<Contravvenzione> contravvenzioni = dbManager.GetAll();
            int numbList = 1;

            foreach (var item in contravvenzioni)
            {
                Console.WriteLine($"{numbList++}. {item.ToString()}");
            }

        }
    }
}
