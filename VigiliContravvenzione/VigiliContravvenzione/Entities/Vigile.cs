using System;
using System.Collections.Generic;
using System.Text;

namespace VigiliContravvenzione.Entities
{
    public class Vigile
    {
        public  string Nome { get; set; }
        public  string Cognome { get; set; }
        public int NumeroMatricola { get; set; }
        public List<Contravvenzione> ListaContravvenzioni { get; set; } = new List<Contravvenzione>();

        public Vigile(string nome, string cognome, int numeroMatricola)
        {
            Nome = nome;
            Cognome = cognome;
            NumeroMatricola = numeroMatricola;
        }

        public Vigile(int numeroMatricola)
        {

            NumeroMatricola = numeroMatricola;
        }

    }
}
