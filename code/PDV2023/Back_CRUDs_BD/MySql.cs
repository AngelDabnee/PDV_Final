using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.VisualBasic;

namespace Back_CRUDs_BD
{
    public class MySql: CRUDS_BD
    {
        /// <summary>
        /// Variables de conexión. 
        /// </summary>
        MySqlConnection con;
        MySqlCommand comando;
        MySqlDataAdapter dr;
        //Variables de identificador. 
        int id; 
        public MySql(string host, string us, string pwd, string bd, string puerto = "3306") //Haremos que reciban estos valores. 
        {
            //Inicializamos los valores de conexión. 
            this.connectionString = ($"Server={host};Port{puerto};Database={bd};Uid={us};Pwd={pwd};");
            //creamos la conexión con el conection string
            con = new MySqlConnection(connectionString);
        }
        public override bool insertar(string tabla, List<string> campos, List<string> valores)
        {//Programaré el esqueleto de cada uno de los métodos. 
            bool resultado = false;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    //vamos a concatenar todos los valores con ","
                    string camposConcat = "";
                    foreach (var campo in campos)
                    {
                        camposConcat += campo + ",";
                    }
                    camposConcat = camposConcat.Remove(camposConcat.Length - 1);//Con este removemos el último caracter de la cadena
                    //Agregaremos a la interpolación las '' para la query
                    string valoresConcat = "";
                    foreach (var valor in valores)
                    {

                        if (int.TryParse(valor, out int numeroEntero))//Esto lo utilizamos para separar si el valor es entero solo agregarle las comas
                        {
                            valoresConcat = "," + numeroEntero.ToString() + ",";
                        }
                        else if (double.TryParse(valor, out double numeroDouble))//Si el valor fuese double le agregariamos solo las comas
                        {
                            valoresConcat += "," + numeroDouble.ToString() + ",";
                        }
                        else
                            valoresConcat += "'" + valor + "',"; //si el valor es un string, se agrega el apostrofe al inicio, final y la separación de coma 
                    }
                    valoresConcat = valoresConcat.Remove(valoresConcat.Length - 1);//Eliminamos la última coma que se encuentre. 
                    //Comando revisar el nombre de la tabla
                    comando = new MySqlCommand($"INSERT INTO {tabla} ({camposConcat}) VALUES ({valoresConcat})");
                    //Relacionamos el comando con la conexión. 
                    comando.Connection = con;
                    //Ejecutamos la query
                    int res = comando.ExecuteNonQuery();
                    //validar la ejecución. 
                    if (res == 1)
                    {
                        resultado = true;
                    }
                    else
                    {
                        resultado = false;
                        this.msgError = "ERROR AL GENERAR LOS DATOS ";
                    }

                }
            }
            catch (MySqlException mex)
            {
                this.msgError = "NO SE PUDO GENERAR EL REGISTRO, ERROR " + mex.Message;
            }
            catch (Exception ex)
            {
                this.msgError = "NO SE PUDO CONCRECTAR LA OPERACIÓN POR ERROR GENERAL DE WINDWOS " + ex.Message;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                con.Close();
            }
            //Regresamos el resultado
            return resultado; 
        }
        public override bool modificar(string tabla, List<string> campos, List<string> valores, int id)
        {
            bool resultado = false;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    //Se abrirá la conexíón si se encuentra cerrada, según la condición. 
                    con.Open();
                    //Agregaremos las comas en la query, para los campos que seleccionaremos. 
                    string camposConcat = "";
                    foreach (var campo in campos)
                    {
                        camposConcat += campos + ",";
                    }
                    camposConcat = camposConcat.Remove(camposConcat.Length - 1);//Eliminaremos la última coma.
                    //Para los valores, haremos lo mismo, solo que aquí condicionaremos para saber si es un número int o double o una cadena de string. 
                    string valorConcat = "";
                    foreach (var valor in valores)
                    {
                        if (int.TryParse(valor, out int valorEntero))
                        {
                            valorConcat = "," + valorEntero + ",";
                        }
                        else if (double.TryParse(valor, out double valorDouble))
                        {
                            valorConcat = "," + valorDouble + ",";
                        }
                        else
                        {
                            valorConcat = "'" + valor + "',";
                        }
                    }
                    valorConcat = valorConcat.Remove(valorConcat.Length - 1);
                    //instanciamos la query. 
                    comando = new MySqlCommand($"UPDATE {tabla} SET {camposConcat} = {valorConcat} WHERE id = {this.id};");
                    //Relacionamos el comando. 
                    comando.Connection = con;
                    //Ejecutamos la query. 
                    int res = comando.ExecuteNonQuery();
                    //Validamos el udpate. 
                    if (res == 1)
                    {
                        resultado = true;
                    }
                    else
                    {
                        resultado = false;
                        this.msgError = "ERROR AL ACTUALIZAR LOS DATOS";
                    }
                }
            }
            catch (MySqlException mex)
            {
                this.msgError = "ERROR AL CONCRETAR LA OPERACIÓN, " + mex.Message;
            }
            catch (Exception ex)
            {
                this.msgError = "ERROR GENERAL DE WINDWOS, ERROR " + ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return resultado;
        }
        public override bool eliminar(string tabla, int id)
        {
            bool resultado = false;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    //Ejecutamos el comando. 
                    comando = new MySqlCommand($"DELET FROM {tabla} WHERE id = {this.id}");
                    //ejecutamos la conexión. 
                    comando.Connection = con;
                    //realizamos la query
                    int res = comando.ExecuteNonQuery();
                    //validamos la conexión. 
                    if (res == 1)
                    {
                        resultado = true;
                    }
                    else
                    {
                        resultado = false;
                        this.msgError = "NO SE PUDO CONCRETAR LA OPERACIÓN, ERROR";
                    }
                }

            }
            catch (MySqlException mex)
            {
                this.msgError = $"ERROR AL CONCRECTAR LA OPERACIÓN, ERROR {mex.Message}";
            }
            catch (Exception ex)
            {
                this.msgError = $"ERROR GENERALIZADO DE WINDWOS {ex.Message}";
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return resultado;
        }
        public override object consultar(string tabla)
        {
            throw new NotImplementedException();
        }

        public override object consultar(string tabla, string criterioBusqueda)
        {
            throw new NotImplementedException();
        }
    }
}
