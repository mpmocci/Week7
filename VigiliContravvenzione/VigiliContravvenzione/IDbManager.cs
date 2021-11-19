using System;
using System.Collections.Generic;
using System.Text;
using VigiliContravvenzione.Entities;


namespace VigiliContravvenzione
{
    interface IDbManager
    {

        public List<Contravvenzione> GetAll();
        public List<Contravvenzione> GetAllByVigile();
        public List<Contravvenzione> GetAllByVeicolo();
     
    }
}
