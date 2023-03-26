using Middle_gamestore_PDV;
using System.Windows.Media.Media3D;
using System.Windows.Forms;
using Back_CRUDs_BD;
using MySql.Data.MySqlClient;
using System.CodeDom.Compiler;
using FontAwesome.Sharp;

namespace WinFromMenu
{
    public partial class FromAddcs : Form
    {
        Producto prod = new Producto(); //un tipo de producto vacio. 
        CRUDs_BD bd;//para utilizar la conexión a la bd
        int identi = 0;
        public FromAddcs()
        {
            InitializeComponent();
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv", "3306");
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtNombre.Enabled == false && txtDescripcion.Enabled == false &&
                txtCodBarra.Enabled == false && txtPrecio.Enabled == false && txtImagen.Enabled == false
                && comboConsola.Enabled == false && buttonImagen.Enabled == false && buttonGuardar.Enabled == false)
            {
                this.limpiarForm(true);
            }
        }
        //------------------------------METODO PARA GUARDAR---------------------------
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Consola valorConsola;
            //Valoramos que tipo de consola eligió el usuario. 
            switch (comboConsola.SelectedItem.ToString())
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
            bool resultado = prod.crear(txtNombre.Text, txtDescripcion.Text, double.Parse(txtPrecio.Text), txtCodBarra.Text, txtImagen.Text, valorConsola);//Con esto metemos en el insert
            if (resultado == false)
            {
                MessageBox.Show("ERROR AL CARGAR PRODUCTO" + Producto.msgError);
            }
            else
            {
                MessageBox.Show("PRODUCTO CARGADO CON ÉXITO");
                if (pictureBoxImagen.Image != null)
                {
                    pictureBoxImagen.Image.Save("..\\..\\..\\fotosProductos\\" + txtImagen.Text);//Guardaremos la foto. opción uno. 
                    //pictureBoxImagen.Image.Save("..\\..\\..\\..\\..\\..\\..\\fotosProductos\\" + txtImagen.Text);//Guardaremos la foto. opción 2 
                }
                this.limpiarForm(false);
                this.FromAddcs_Load(sender, e);
            }
        }
        //------------------------------Método para cargar el formulario. ----------------------------
        private void FromAddcs_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }
        //-----------------------------------------------MÉTODO PARA ABRIR LA IMAGEN, CARGARLA--------------------------------------
        private void buttonImagen_Click(object sender, EventArgs e)
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
        //--------------------------MÉTODO PARA CARGAR LOS DATOS AL FORMULARIO-------------------------
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
                pictureBoxImagen.ImageLocation = "..\\..\\..\\fotosProductos\\" + txtImagen.Text;//para recargar la foto. 
                this.identi = (int)dataGridProductos.Rows[celdas].Cells[0].Value;//Convertimos para no tener error de tipos de dato
                                                                                 //Además de esto, esta la usamos, para pasar los datos del producto
                                                                                 //y eliminarlos sin afectar TODOS los datos de la tabla
            }
        }
        //-----------------------boton para cerrar formulario------------------------------
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();//Cerraremos el formulario
        }

        //-------------método para cargar los datos---------
        public void cargarDatos()
        {
            dataGridProductos.Rows.Clear();
            List<object[]> datos = prod.consultarTodos();//guardo la lista de object según lo que quiero mostrar, en una variable de object llamada datos
            for (int i = 0; i < datos.Count; i++)//recorro toda la lista de object
            {
                dataGridProductos.Rows.Add(datos[i]);//al recorrerla, le agrego los datos que tengo en la variable en el indice [i]

            }
        }
        //-----------------------------------Siguiente región es el método para limpiar los form------------------------
        #region
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
                buttonImagen.Enabled = true;
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
                comboConsola.Enabled = false;///Combobox
                buttonImagen.Enabled = false;//imagen
                buttonGuardar.Enabled = true;//activar guardar
            }

        }
        #endregion
    }
}
