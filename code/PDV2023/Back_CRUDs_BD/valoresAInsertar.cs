using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_CRUDs_BD
{
    public class valoresAInsertar
    {
        public string valor;
        public bool llevaApostrofes;
        public valoresAInsertar(string v, bool llevaApostrofes = true) 
        {
            this.valor = v;
            this.llevaApostrofes= llevaApostrofes;
        }
    }
}
