using Back_CRUDs_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_gamestore_PDV
{
    public class Logear
    {
        CRUDs_BD bd;
        int idEmpleado;
        string nombre;
        string password;
        public static int id;
        public static string msgError;

        public Logear()
        {
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv", "3306");
        }
        public Logear consulta(string nombre, string password)
        {
            Logear prodResultado = new Logear();

            List<object[]> res = this.bd.consulta("usuarios", "nombre=" + nombre + "AND password = " + password);
            //validamos que traig un elemento la lista
            if (res.Count == 1)
            {
                Consola presentacionTexto;
                object[] tempo = res[0];
                prodResultado.idEmpleado = int.Parse(tempo[0].ToString());
                prodResultado.nombre = tempo[1].ToString();
                prodResultado.password = tempo[4].ToString();
                id = idEmpleado; 
            }
            else
            {
                Producto.msgError = "ERROR, EL USUARIO NO EXISTE " + this.bd.msgError;
                prodResultado = null;
            }
            return prodResultado; 
        } 
    }
}
