using Back_CRUDs_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_gamestore_PDV
{
    public class Empleado
    {
        //Definimos las variables. 
        public string nombre;
        public string apellido;
        public string celular;
        public string password;
        public string email;
        public int idEmpleado; //la utilizaremos para la id del empleado. 
        public Roles rol;
        public string imagen;
        CRUDs_BD bd;
        public static string msgError;
        public Empleado()
        {
            //crear una instancia de MYSQL a mi bd
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv");//el puerto esta por default
        }
        //LLAMAMOS LOS MÉTODOS DEL CRUD. 
        public bool crearUsuario(string nom, string apellido, string celular, string password, string email, string imagen, Roles rol)
        {
            List<string> nombresCampos = new List<string>()
            {
                    "nombre", "apellido", "celular", "password", "email", "rol", "imagen"
            };

            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(nom));
            vals.Add(new ValoresAInsertar(apellido));
            vals.Add(new ValoresAInsertar(celular));
            vals.Add(new ValoresAInsertar(password));
            vals.Add(new ValoresAInsertar(email));
            vals.Add(new ValoresAInsertar(rol.ToString()));
            vals.Add(new ValoresAInsertar(imagen));

            bool resultado = this.bd.insertar("usuarios", nombresCampos, vals);
            //valir el res
            if (resultado == false)
                Empleado.msgError = this.bd.msgError;

            return resultado;
        }
        public bool modificarUsuario(string nom, string apellido, string celular, string password, string email, Roles rol, string imagen, int id)
        {
            List<string> nombresCampos = new List<string>()
            {
                    "nombre", "apellido", "celular", "password", "email", "rol", "imagen"
            };

            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(nom));
            vals.Add(new ValoresAInsertar(apellido));
            vals.Add(new ValoresAInsertar(celular));
            vals.Add(new ValoresAInsertar(password));
            vals.Add(new ValoresAInsertar(email));
            vals.Add(new ValoresAInsertar(rol.ToString()));
            vals.Add(new ValoresAInsertar(imagen));

            bool resultado = this.bd.modificar("usuarios", nombresCampos, vals, id);
            //valir el res
            if (resultado == false)
                Empleado.msgError = this.bd.msgError;

            return resultado;
        }
        //ELIMINAR
        public bool borrarUsuario(int id)
        {
            bool res = this.bd.borrar("usuarios", id);
            if (res = false)
                Empleado.msgError = this.bd.msgError;
            return res;
        }
        public List<object[]> consultarTodoUsers() //DEVOLVEMOS TODOS LOS ASPECTOS. usuariois
        {
            return this.bd.consulta("usuarios");
        }
        //consultar
        public List<object[]> consultarPorNombreUsuario(string nom)
        {
            List<object[]> res = this.bd.consulta("usuarios", "nombre=" + "'" + nom + "'");//Agregaremos los apostrofes en la búsqueda literal para que nos encuentre el producrto que estamos buscando por el nombre literal que se escribió
            return res;
        }

    }
}
