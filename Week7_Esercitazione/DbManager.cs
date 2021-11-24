using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Week7_Paola_Mocci.Entities;


namespace Week7_Paola_Mocci
{
    public class DbManager
    {

        //STRINGAA CORRETTA:
       const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Scuola;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //STRINGA SBAGLIATA:
        //const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Scuo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        // STRINGA NULLA:
         //const string connectionString = null;

        internal static Studente GetStudenteById(int id)
        {

            Studente studente = new Studente();


            /***ECCEZIONE MANCATA CONNESSIONE A DB***/

            SqlConnection connection = null;
            try
            {


                using (connection = new SqlConnection(connectionString))
                {

                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM Studente WHERE Id= @y";
                    command.Parameters.AddWithValue("@y", id);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var nome = (string)reader["Nome"];
                        var cognome = (string)reader["Cognome"];

                        studente.IdStudente = id;
                        studente.Nome = nome;
                        studente.Cognome = cognome;

                    }

                    return studente;


                }

            }
            catch (NullReferenceException nex)
            {
                Console.WriteLine(nex.Message);
                Studente fakeStudent = new Studente();
                fakeStudent.IdStudente = -1;
                return fakeStudent;
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.Message);
                //Ho creato un fakeStudent con Id=-1, così  non mi stampa a seguire anche il messaggio della NotFoundException (che viene stampato quando idStudente=0)
                Studente fakeStudent = new Studente();
                fakeStudent.IdStudente = -1;
                return fakeStudent;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Studente fakeStudent = new Studente();
                fakeStudent.IdStudente = -1;
                return fakeStudent;

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }



            }

        }





    }
}
