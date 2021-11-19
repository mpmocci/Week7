using System;
using System.Collections.Generic;
using System.Text;

namespace VigiliContravvenzione.Entities
{
    public class Motociclo: Veicolo
    {
        public string NumeroTelaio { get; set; }

        public Motociclo(string targa, string numTelaio) : base(targa)
        {
            NumeroTelaio = numTelaio;
        }

        public Motociclo(string targa)
        {

            NumeroTarga = targa;

        }

        public Motociclo()
        {

        }
    }
}
