using System;
using System.Collections.Generic;
using System.Text;

namespace Week7_Paola_Mocci.Entities
{
   public class Classe
    {

        public string IdClasse { get; set; }
        public string Codice { get; set; }
        public int Livello { get; set; }

        List<Insegnante> Insegnanti { get; set; } = new List<Insegnante>();
        List<Studente> Studenti { get; set; } = new List<Studente>();

        public Classe()
        {

        }

    }
}
