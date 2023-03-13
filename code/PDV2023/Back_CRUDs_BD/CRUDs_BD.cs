using System.Data;
using System.Data.SqlClient;

namespace Back_CRUDs_BD
{
    public abstract class CRUDS_BD
    {
        protected string connectionString;
        private DBMS dbms;
        private CONSOLA consola;
        protected string tabla; 
        protected List<string> campos = new List<string>();
        protected List<string> valores = new List<string>();
        //Variables para la conexión. 
        protected string host;
        protected string us;
        protected string pwd;
        protected string puerto;
        protected string nombreBD; 
        /// <summary>
        /// para definir los criterios de búsqueda que se aplicarán en el SELECT en la parte del WHERE. 
        /// EJEMPLO:
        /// SELECT * FROM usuarios WHERE (criterio de busqueda)
        /// SELECT * FROM usuarios WHERE email = a@gmail.com AND password = 1234;
        /// </summary>
        protected string criteriosBusqueda;
        /// <summary>
        /// nos permite establecer el orden, ORDER BY, GRUP BY, LIMIT
        /// para personalizar la búsqueda
        /// SELECT * FROM usuarios WHERE nombre LIKE %% (los parentesis nos indicarán en donde queremos la cadena, o la parte desa %DA%
        /// </summary>
        protected string ordeGruposLimit; 
        public string msgError;
        //Estamos ocultandola, para cuando la heredemos en msql o sql, va a cambiar
        public object dr;
        ////------MÉTODOS--------////
        public abstract bool insertar(string tabla, List<string>campos, List<string>valores);
        public abstract bool modificar(string tabla, List<string>campos, List<string>valores, int id);
        public abstract bool eliminar(string tabla, int id);
        public abstract object consultar(string tabla);
        public abstract object consultar(string tabla, string criterioBusqueda);



    }
}