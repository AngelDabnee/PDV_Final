using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Ocsp;

namespace Back_CRUDs_BD
{
    public class MySql: CRUDS_BD
    {
        /// <summary>
        /// Variables de conexión. 
        /// </summary>
        MySqlConnection con;
        MySqlCommand comando;
        MySqlDataReader dr;
        //Variables de identificador. 
        public MySql(string host, string us, string pwd, string bd, string puerto = "3306") //Haremos que reciban estos valores. 
        {
            //Inicializamos los valores de conexión. 
            this.connectionString = ($"Server={host};Port{puerto};Database={bd};Uid={us};Pwd={pwd};");
            //creamos la conexión con el conection string
            con = new MySqlConnection(connectionString);
        }
        public override bool insertar(string tabla, List<string> campos, List<valoresAInsertar> valores)
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
                    foreach (valoresAInsertar valor in valores)
                    {
                        if (valor.llevaApostrofes)
                        {
                            valoresConcat += "'" + valor + "'";
                        }
                        else
                        {
                            valoresConcat += valor + ",";
                        }
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
        public override bool modificar(string tabla, List<string> campos, List<valoresAInsertar> valores, int id)
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
                    for (int i = 0; i < campos.Count; i++)
                    {
                        camposConcat += campos[i] + "=" + (valores[i].llevaApostrofes ? "'" + valores[i].valor + "'," : valores[i].valor + "',");

                    }
                    camposConcat = camposConcat.Remove(camposConcat.Length - 1);
                    //instanciamos la query. 
                    comando = new MySqlCommand($"UPDATE {tabla} SET {camposConcat} = {camposConcat} WHERE id = {id};");
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
                    comando = new MySqlCommand($"DELET FROM {tabla} WHERE id = {id}");
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
        public override List<object[]> consultar(string tabla)//PAra que me devuelva una lista de arreglos. 
        {
            List<object[]> resultado = new List<object[]>();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    comando = new MySqlCommand($"SELECT * FROM {tabla}");//Ejecutar la conexión
                    dr = comando.ExecuteReader();//Para realizar la query. 
                    if (dr.HasRows)
                    {
                        //leemos 
                        while (dr.Read())
                        {
                            //cada elemento del object
                            object[] registro = new object[dr.FieldCount];//para saber los campos que tiene. 
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                registro[i] = dr.GetValue(i);//procesamos el arreglo para los datos. para agregar el campo al indice registro
                            }
                            resultado.Add(registro);//ya que pase ya lo agregamos. 
                        }

                    }
                    else
                    {
                        this.msgError = $"ERROR, NO EXISTEN REGISTROS EN LA TABLA {tabla}.";
                        //Que devolvemos. 
                        resultado = new List<object[]>(); //arreglo de object, nos revolverá la devolución. 
                    }
                }

            }
            catch (MySqlException mex)
            {
                this.msgError = $"NO SE PUDO REALIZAR LA CONSULTA A BASE DE DATOS, {mex.Message}";
            }
            catch (Exception ex)
            {
                this.msgError = $"ERROR GENERAL DE LA APLICACIÓN, {ex.Message}";
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

        public override List<object[]> consultar(string tabla, string criterioBusqueda)
        {
            List<object[]> resultado = new List<object[]>();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    comando = new MySqlCommand($"SELECT * FROM {tabla} WHERE {criterioBusqueda}");//Ejecutar la conexión, esto es para el criterio de busqueda. 
                    dr = comando.ExecuteReader();//Para realizar la query. 
                    if (dr.HasRows)
                    {
                        //leemos 
                        while (dr.Read())
                        {
                            //cada elemento del object
                            object[] registro = new object[dr.FieldCount];//para saber los campos que tiene. 
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                registro[i] = dr.GetValue(i);//procesamos el arreglo para los datos. para agregar el campo al indice registro
                            }
                            resultado.Add(registro);//ya que pase ya lo agregamos. 
                        }

                    }
                    else
                    {
                        this.msgError = $"ERROR, NO EXISTEN REGISTROS EN LA TABLA {tabla}.";
                        //Que devolvemos. 
                        resultado = new List<object[]>(); //arreglo de object, nos revolverá la devolución. 
                    }
                }

            }
            catch (MySqlException mex)
            {
                this.msgError = $"NO SE PUDO REALIZAR LA CONSULTA A BASE DE DATOS, {mex.Message}";
            }
            catch (Exception ex)
            {
                this.msgError = $"ERROR GENERAL DE LA APLICACIÓN, {ex.Message}";
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
    }
}
