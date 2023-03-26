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
    public partial class FromDelete : Form
    {
        Producto prod = new Producto(); //un tipo de producto vacio. 
        CRUDs_BD bd;//para utilizar la conexión a la bd
        int identi = 0;

        public FromDelete()
        {
            InitializeComponent();
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv", "3306");

        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            bool resultado = prod.borrar(identi);
            if (resultado == false)
            {
                MessageBox.Show("PRODUCTO ELIMINADO CON ÉXITO");
                if (pictureBox1.Image != null)
                {
                    File.Delete("..\\..\\..\\fotosProductos\\" + txtImagen.Text);//ELIMINAREMOS LA FOTO. opción 1 para elimnar
                                                                                 //File.Delete("..\\..\\..\\..\\..\\..\\..\\fotosProductos\\" + txtImagen.Text);//ELIMINAREMOS LA FOTO. opción 2 para elimnar


                }
                this.limpiarForm(true);//desactivamos los txt al momento de eliminar un producto. 
                this.FromDelet_Load(sender, e);//Con esto, cada producto borrado nos recargará el datagrid

            }
            else
            {
                MessageBox.Show("ERROR AL ELIMINAR DATOS " + Producto.msgError);
            }
            this.limpiarForm(false);//Volvemos a desactivarlos. 
        }
        //---------------------------------MÉTODO PARA CARGAR EN LOS TXT LOS VALORES DEL DATA-------------------------------------------
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
                comboConsola.SelectedItem = dataGridProductos.Rows[celdas].Cells[6].Value.ToString();
                pictureBox1.ImageLocation = "..\\..\\..\\fotosProductos\\" + txtImagen.Text;//para recargar la foto. 
                this.identi = (int)dataGridProductos.Rows[celdas].Cells[0].Value;//Convertimos para no tener error de tipos de dato
                                                                                 //Además de esto, esta la usamos, para pasar los datos del producto
                                                                                 //y eliminarlos sin afectar TODOS los datos de la tabla
            }
        }
        //----------------------------------------------CARGAREMOS LOS DATOS AL FORMULARIO---------------------------------
        private void FromDelet_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }
        //--------------------------------------------------CERAMOS EL FORMULARIO--------------------------------------------
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //--------------------------------------MÉTODO PARA CARGAR FORMULARIO-------------------------------------
        public void cargarDatos()
        {
            dataGridProductos.Rows.Clear();
            List<object[]> datos = prod.consultarTodos();//guardo la lista de object según lo que quiero mostrar, en una variable de object llamada datos
            for (int i = 0; i < datos.Count; i++)//recorro toda la lista de object
            {
                dataGridProductos.Rows.Add(datos[i]);//al recorrerla, le agrego los datos que tengo en la variable en el indice [i]

            }

        }
        //---------------------------------MÉTODO PARA LIMPIAR FORMULARIOS--------------------------------------------------
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
                comboConsola.Enabled = true;
                comboConsola.Items.Clear();

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
                comboConsola.Enabled = false;///Combobox
                comboConsola.Items.Clear();
            }

        }
    }
}
