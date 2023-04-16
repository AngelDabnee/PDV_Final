using Back_CRUDs_BD;
using Middle_gamestore_PDV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFromMenu
{
    public partial class FromUpdate : Form
    {
        Producto prod = new Producto(); //un tipo de producto vacio. 
        CRUDs_BD bd;//para utilizar la conexión a la bd
        int identi = 0;
        public FromUpdate()
        {
            InitializeComponent();
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv", "3306");

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtNombre.Enabled == false && txtDescripcion.Enabled == false &&
            txtCodBarra.Enabled == false && txtPrecio.Enabled == false && txtImagen.Enabled == false
            && buttonExaminar.Enabled == false && buttonGuardar.Enabled == false)
            {
                this.limpiarForm(true);
            }
        }
        //En el boton de guardar estableceremos que se carge el update que se generar´pa
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Consola valorConsola;
            //Valoramos que tipo de consola eligió el usuario. 
            switch (comboConsolaUpdate.SelectedItem.ToString())
            {
                case "XBOX":
                    valorConsola = Consola.XBOX;
                    break;
                case "PLAYSTATION":
                    valorConsola = Consola.PLAYSTATION;
                    break;
                case "WI":
                    valorConsola = Consola.WI;
                    break;
                case "NINTENDO":
                    valorConsola = Consola.NINTENDO;
                    break;
                case "PC":
                    valorConsola = Consola.PC;
                    break;
                default:
                    valorConsola = Consola.XBOX;
                    break;
            }
            bool resultado = prod.modificar(txtNombre.Text, txtDescripcion.Text, double.Parse(txtPrecio.Text), txtCodBarra.Text, txtImagen.Text, valorConsola, this.identi);
            if (resultado == false)
            {
                MessageBox.Show("ERROR AL MODIFICAR PRODUCTO" + Producto.msgError);
            }
            else
            {
                MessageBox.Show("PRODUCTO MODIFICADO CON ÉXITO");
                if (pictureBoxImagen.Image != null)
                {
                    pictureBoxImagen.Image.Save("..\\..\\..\\fotosProductos\\" + txtImagen.Text);//Guardaremos la foto. opción uno. 
                    //pictureBoxImagen.Image.Save("..\\..\\..\\..\\..\\..\\..\\fotosProductos\\" + txtImagen.Text);//Guardaremos la foto. opción 2 
                }

            }
            this.limpiarForm(false);
            this.FromUpdate_Load(sender, e);
        }
        //ESTABLECEMOS PARA PODER ABRIR EL EXAMINADOR DE FOTOS, Y QUE SE PUEDAN MODIFICAR. 
        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            //Cargar el archivo. 
            if (res == DialogResult.OK)
            {
                pictureBoxImagen.Image = new Bitmap(openFileDialog1.FileName);
                //crear el nombre único. 
                DateTime dtNombre = DateTime.Now;
                string nombreImg = "prod_" + dtNombre.Ticks + ".png";
                txtImagen.Text = nombreImg;
            }
            else
            {
                //Mencionar el error en caso de existir. 
            }
        }
        //MÉTODO PARA CARGAR EL DATA GRID EN LOS TXT 
        private void dataGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int celdas = e.RowIndex;//Al index donde le dimos click, (se llama e)
                //En cada campo, de la tabla, en la variable creada, en la celda de la posición del campo
                txtNombre.Text = dataGridProductos.Rows[celdas].Cells[1].Value.ToString();
                txtDescripcion.Text = dataGridProductos.Rows[celdas].Cells[2].Value.ToString();
                txtCodBarra.Text = dataGridProductos.Rows[celdas].Cells[4].Value.ToString();
                txtPrecio.Text = dataGridProductos.Rows[celdas].Cells[3].Value.ToString();
                txtImagen.Text = dataGridProductos.Rows[celdas].Cells[5].Value.ToString();
                comboConsolaUpdate.SelectedItem = dataGridProductos.Rows[celdas].Cells[6].Value.ToString();
                pictureBoxImagen.ImageLocation = "..\\..\\..\\fotosProductos\\" + txtImagen.Text;//para recargar la foto. 
                this.identi = (int)dataGridProductos.Rows[celdas].Cells[0].Value;//Convertimos para no tener error de tipos de dato
                                                                                 //Además de esto, esta la usamos, para pasar los datos del producto
                                                                                 //y eliminarlos sin afectar TODOS los datos de la tabla
            }
        }
        //CERRAREMOS ESTE FORMULARIO CON EL EVENTO CLIC EN LA X
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //CARGAREMOS LOS DATOS CADA VEZ QUE EL FORMULARIO SE ABRA. 
        private void FromUpdate_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }
        //-------------------------------------------------DEFINIMOS LOS MÉTODOS--------------------------------------------------
        public void cargarDatos()
        {
            dataGridProductos.Rows.Clear();
            List<object[]> datos = prod.consultarTodos();//guardo la lista de object según lo que quiero mostrar, en una variable de object llamada datos
            for (int i = 0; i < datos.Count; i++)//recorro toda la lista de object
            {
                dataGridProductos.Rows.Add(datos[i]);//al recorrerla, le agrego los datos que tengo en la variable en el indice [i]

            }
        }
        public void limpiarForm(bool habilita)
        {
            if (habilita)
            {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = true;
                txtNombre.Clear();
                txtDescripcion.Enabled = true;
                txtDescripcion.Clear();
                txtCodBarra.Enabled = true;
                txtCodBarra.Clear();
                txtPrecio.Enabled = true;
                txtPrecio.Clear();
                txtImagen.Enabled = true;
                txtImagen.Clear();
                buttonExaminar.Enabled = true;
                buttonGuardar.Enabled = true;

            }
            else
            {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = false;
                txtNombre.Clear();
                txtDescripcion.Enabled = false;
                txtDescripcion.Clear();
                txtCodBarra.Enabled = false;
                txtCodBarra.Clear();
                txtPrecio.Enabled = false;
                txtPrecio.Clear();
                txtImagen.Enabled = false;
                txtImagen.Clear();
                buttonExaminar.Enabled = false;
                buttonGuardar.Enabled = false;
            }

        }

        private void pictureBoxImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
