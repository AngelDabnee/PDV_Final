using Back_CRUDs_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Middle_gamestore_PDV
{
    public class Venta
    {
        DateTime fechaHora;
        //DateTime fechaHora = DateTime.Now; 
        //DateTime fechaHoraMysql = fechaHora.ToUniversalTime();
        //string fechaHora = fechaHoraMysql.ToString("yyyy-MM-dd HH:mm:ss"); //con esto convertimos la cadena del texo de hora en un formato valido para mysql. 
        public int cajeroId = 0; 
        public double monto = 0;
        public static string msgError = "";
        //Variables para la conexión. 
        CRUDs_BD bd; 

        public Venta() 
        {
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv", "3306");
        }
        public double registrarVenta(int cajeroID, double monto, double pago, List<ProductoAVender> prodsAVender) 
        {
            double res = 0; 
            this.fechaHora = new DateTime();
            fechaHora = fechaHora.ToUniversalTime();
            string newFechaHora = fechaHora.ToString("yyyy-MM-dd HH:mm:ss");//CON ESTO TRANSFORMAMOS LA FECHA Y HORA EN EL FORMATO CORRECTO DE MYSQL. 
            try
            {
                //Asiganamos los campos para poder generar el primer insert. 
                List<string> campos = new List<string>()
                {
                    "fecha_hora","cajero_id","monto"
                };
                //agregamos los valores que crearemos en el insert. 
                List<ValoresAInsertar> valores = new List<ValoresAInsertar>()
                {
                    new ValoresAInsertar(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),true),
                    new ValoresAInsertar(this.cajeroId.ToString(),false),                //RECUERDA QUE ESTO LO DEBEMOS CAMBIAR POR EL ID DEL USUARIO QUE ENTRARÁ.  
                    new ValoresAInsertar(monto.ToString(),false),
                };
                //generaremos el insert. 
                bool registroVenta = bd.insertar("ventas", campos, valores);// INSERTAMOS EN LA TABLA DE VENTA LOS CAMPOS QUE ESTABLECIMOS Y LOS VALORES QUE "METEREMOS"
                if (registroVenta)
                {
                    int ultimoIdVenta = int.Parse(bd.consultaUnValor("id", "ventas", "1 ORDER BY id DESC LIMIT 1 ").ToString());//CON ESTO GENERAMOS UNA MANIPIULACIÓN DE DATOS DONDE ORDENAMOS EL ÚLTIMO INSERTADO AL INICIO Y LO TOMAMOS AL GENERARLE EL LIMIT. 

                    //LISTA DE LOS CAMPOS QUE INSERTAREMOS. 
                    List<string> listaCamposDetalle = new List<string>()
                    {
                        "venta_id","producto_id","cantidad"
                    };
                    for (int i = 0; i < prodsAVender.Count; i++)//RECORREREMOS CADA VALOR PARA INSERTARLO. 
                    {
                        //GENERAMOS OTRA VARIABLE DE LISTA DE VALORES A INSERTAR, PARA AÑADIRLO POR CADA DATO QUE SE RECORRE. 
                        List<ValoresAInsertar> listaValoresDetalle = new List<ValoresAInsertar>()
                        {
                            new ValoresAInsertar(ultimoIdVenta.ToString(),true),
                            new ValoresAInsertar(prodsAVender[i].productoId.ToString(),false),//ESTO ES PARA DARLE EL PRODUCTO VENDIDO SU PRODUCTO ID Y QUITARLE EL LAS COMILLAS
                            new ValoresAInsertar(prodsAVender[i].cantidad.ToString(),false)//CON ESTO GENERAMOS LA CANTIDAD DE LO QUE SE VENDIÓ. 
                        };
                        bool resDetalle = bd.insertar("ventas_detalles", listaCamposDetalle, listaValoresDetalle);//LO QUE ESTAMOS GENERANDO es insertar en la tabla de ventas detalle
                                                                                                                 //los valores que generamos en la lista de campos detalle, y en la lista de los valores detalle, en el recorrimiento del for anterior. 
                        if (resDetalle)
                        {
                            res = pago - monto;
                        }
                        else
                        {
                            Venta.msgError = bd.msgError;
                            return -1;
                        }

                    }
                }
            }
            catch (Exception)
            {
                res = -1;
                Venta.msgError = bd.msgError;
            }
            return res; 
        }
    }
}
