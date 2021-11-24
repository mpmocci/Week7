using System;
using System.Collections.Generic;
using System.Text;
using Week7_Paola_Mocci.Entities;

namespace Week7_Paola_Mocci
{
    public static class Menu
    {

        private static DbManager dbManager = new DbManager();

        internal static void Start()
        {

            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("\n--------------------------------Menu------------------------------");
                Console.WriteLine("1. Visualizza nome e cognome studente tramite Id.");
                Console.WriteLine("0. Exit");
                Console.WriteLine("\n------------------------------------------------------------");



                int choice;
                do
                {
                    Console.WriteLine("\nScegli cosa fare!\n");
                } while (!(int.TryParse(Console.ReadLine(), out choice) && choice >= 0 && choice <= 1));

                switch (choice)
                {
                    case 1:

                        GetStudentById();

                        break;

                    case 0:
                        goOn = false;
                        break;

                }

            }



        }



        private static void GetStudentById()
        {
            /***ECCEZIONE USER NOT FOUND****/
            try
            {
                int id;
                do
                {
                    Console.WriteLine("Digita l'ID dello studente:\n");

                }
                while (!(int.TryParse(Console.ReadLine(), out id)));


                Studente studente = new Studente();

                studente = DbManager.GetStudenteById(id);

    
                if(studente.IdStudente == 0)
                {
                    throw new NotFoundException("Non è stato possibile trovare questo studente perché l'id digitato non è presente nel database.")
                    {
                        
                    };

                }
                else if(studente.IdStudente !=0 && studente.IdStudente !=-1)
                {
                    Console.WriteLine($"Nome:{studente.Nome} - Cognome:{studente.Cognome}");
                }

            }

            catch(NotFoundException nfex)

            {
                Console.WriteLine(nfex.Message);
            }


        }

    }
}
