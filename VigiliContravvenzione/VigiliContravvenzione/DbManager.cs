using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using VigiliContravvenzione.Entities;


namespace VigiliContravvenzione
{
    public class DbManager : IDbManager
    {

        const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VigiliContravvenzione;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public List<Contravvenzione> GetAll()
        {
            SqlConnection connection = null;

            try
            {

                List<Contravvenzione> contravvenzioni = new List<Contravvenzione>();

                using (connection = new SqlConnection(connectionString))
                {

                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM dbo.Contravvenzione";


                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var numeroVerbale = (int)reader["NumeroVerbale"];
                        var luogo = (string)reader["Luogo"];
                        var data = (DateTime)reader["Data"];
                        var numeroMatricola = (int)reader["MatricolaVigile"];
                        string targa = (string)reader["Targa"];

                        Vigile vigile = new Vigile(numeroMatricola);

                        Contravvenzione contravvenzione = new Contravvenzione(numeroVerbale, luogo, data, vigile, targa);


                        contravvenzioni.Add(contravvenzione);


                    }

                    return contravvenzioni;

                }

            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.Message);
                return new List<Contravvenzione>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Contravvenzione>();


            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

            }

        }

        public List<Contravvenzione> GetAllByVeicolo()
        {
            throw new NotImplementedException();
        }

        public List<Contravvenzione> GetAllByVigile()
        {
            throw new NotImplementedException();
        }
    }
}
