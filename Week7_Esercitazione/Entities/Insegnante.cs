using System;
using System.Collections.Generic;
using System.Text;

namespace Week7_Paola_Mocci.Entities
{
   public class Insegnante : Persona
    {
        public int IdInsegnante { get; set; }
        public List<MateriaStudio> Materie { get; set; } = new List<MateriaStudio>();
        public List<Classe> Classi { get; set; } = new List<Classe>();

        public Insegnante()
        {

        }

    }
}
