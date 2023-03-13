using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_CRUDs_BD
{
    public class pruebaInstancia
    {
        public pruebaInstancia()
        {
            CRUDS_BD baseDatos;
            //Podemos crear las mismas para mysql o sqlServer
            baseDatos = new MySql("LocalHost", "Root", "pwd", "GameStore");//Como solo tenemos un "puerto" se queda el valor. 
            baseDatos.insertar("productos", new List<string>() { "id", "nombre", "precio" }, new List<string>() { "12", "asd", "12"});   


        }
    }
}
