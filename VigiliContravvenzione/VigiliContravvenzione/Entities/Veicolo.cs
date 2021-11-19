using System;
using System.Collections.Generic;
using System.Text;

namespace VigiliContravvenzione.Entities
{
   public class Veicolo
    {

        public string NumeroTarga { get; set; }
        public List<Contravvenzione> ListaContravvenzioni { get; set; } = new List<Contravvenzione>();

        public Veicolo()
        {

        }
        public Veicolo(string targa)
        {
            NumeroTarga = targa;
        }
    }
}
