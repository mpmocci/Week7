using System;
using System.Collections.Generic;
using System.Text;

namespace VigiliContravvenzione.Entities
{
    public class Automobile : Veicolo
    {
        public double Potenza { get; set; }

        public Automobile(string targa, double potenza) : base(targa)
        {
            Potenza = potenza;
        }
        public Automobile(string targa){

            NumeroTarga = targa;

            }

        public Automobile()
        {

        }
    }
}
