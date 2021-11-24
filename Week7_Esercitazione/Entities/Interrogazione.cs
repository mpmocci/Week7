using System;
using System.Collections.Generic;
using System.Text;

namespace Week7_Paola_Mocci.Entities
{
    public class Interrogazione
    {
        public int IdInterrogazione { get; set; }
        public Studente Studente { get; set; }
        public MateriaStudio Materia { get; set; }
        public int Votazione { get; set; }
        public DateTime Data { get; set; }


        public Interrogazione()
        {

        }

    }
}
