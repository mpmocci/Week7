using System;
using System.Collections.Generic;
using System.Text;

namespace Week7_Paola_Mocci.Entities
{
    public class MateriaStudio
    {
        public Subject Materia { get; set; }

        public MateriaStudio()
        {

        }
    }

    public enum Subject
    {
        Fisica,
        Matematica,
        Italiano,
        Latino,
        Arte
    }

}
