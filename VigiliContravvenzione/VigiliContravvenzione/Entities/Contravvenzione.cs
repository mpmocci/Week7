using System;
using System.Collections.Generic;
using System.Text;

namespace VigiliContravvenzione.Entities
{
   public class Contravvenzione
    {

        public int NumeroVerbale{ get; set; }
        public string Luogo{ get; set; }
        public DateTime Data { get; set; }
        public Vigile Vigile { get; set; }
        public Veicolo Veicolo { get; set; }
        public string Targa { get; set; }
        public string NumeroMatricola { get; set; }

        public Contravvenzione(int numeroVerbale, string luogo, DateTime data, Vigile vigile, string targa)
        {
            NumeroVerbale=numeroVerbale;
            Luogo = luogo;
            Data = data;
            Vigile = vigile;
            Targa= targa;
        }

        public Contravvenzione(int numeroVerbale, string luogo, DateTime data, Vigile vigile, Veicolo veicolo)
        {
            NumeroVerbale = numeroVerbale;
            Luogo = luogo;
            Data = data;
            Vigile = vigile;
            Veicolo = veicolo;
        }

        public Contravvenzione()
        {

        }

        public override string ToString()
        {
            return $"Numero Verbale: {NumeroVerbale} - Luogo: {Luogo} -  Data: {Data} - Veicolo:{Targa} - Vigile:{Vigile.NumeroMatricola}";
        }


    }
}
