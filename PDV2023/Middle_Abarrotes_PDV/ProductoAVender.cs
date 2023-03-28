using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_gamestore_PDV
{
    //Esta clase se crea para poder establecer los productos que vendemos. 
    public class ProductoAVender
    {
        public int productoId;
        public int cantidad; 
        public ProductoAVender(int prodId, int cant) 
        {
            this.productoId = prodId;
            this.cantidad = cant;
        }
    }
}
