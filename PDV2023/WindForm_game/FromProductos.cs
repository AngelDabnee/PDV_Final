using Middle_gamestore_PDV;
using System.Windows.Media.Media3D;
using System.Windows.Forms;
using Back_CRUDs_BD;
using MySql.Data.MySqlClient;
using System.CodeDom.Compiler;

namespace WindForm_game
{
    public partial class FromProductos : Form
    {
        //Creamos una instancia de producto
        Producto prod = new Producto(); //un tipo de producto vacio. 
        CRUDs_BD bd;//para utilizar la conexión a la bd
        int identi = 0;

        public FromProductos()
        {
            InitializeComponent();
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv", "3306");
        }
        //Inicializamos para activar los txt al darle añadir o modificar el producto. 
        private void iconAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Enabled == false && txtDescripcion.Enabled == false && txtCodBarra.Enabled == false && txtPrecio.Enabled == false && txtImagen.Enabled == false && comboConsola.Enabled == false)
            {
                this.limpiarForm(true);
            }
        }
        //Creamos el boton de save para cada producto. 
        private void iconCrear_Click(object sender, EventArgs e)
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
                this.FromProductos_Load(sender, e);
            }
        }
        //Confirmamos con el boton de editar, pero antes de esto hay que activar los txt con el boton de '+'
        private void iconEditar_Click(object sender, EventArgs e)
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
            bool resultado = prod.modificar(txtNombre.Text, txtDescripcion.Text, double.Parse(txtPrecio.Text), txtCodBarra.Text, txtImagen.Text, valorConsola, identi);
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
            this.FromProductos_Load(sender, e);

        }
        //Creamos la imagen para cargarla en el picturebox. -------------------------Revisar ya que en mi pc abre el escritorio pero desde oneDrive. 
        private void iconImagen_Click(object sender, EventArgs e)
        {
            DialogResult res = dialogResult.ShowDialog();
            //Cargar el archivo. 
            if (res == DialogResult.OK)
            {
                pictureBoxImagen.Image = new Bitmap(dialogResult.FileName);
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
        //Creamos el método para borrar los poroductos
        private void iconBorrar_Click(object sender, EventArgs e)
        {

            bool resultado = prod.borrar(identi);
            if (resultado == false)
            {
                MessageBox.Show("PRODUCTO ELIMINADO CON ÉXITO");
                if (pictureBoxImagen.Image != null)
                {
                    File.Delete("..\\..\\..\\fotosProductos\\" + txtImagen.Text);//ELIMINAREMOS LA FOTO. opción 1 para elimnar
                                                                                 //File.Delete("..\\..\\..\\..\\..\\..\\..\\fotosProductos\\" + txtImagen.Text);//ELIMINAREMOS LA FOTO. opción 2 para elimnar


                }
                this.limpiarForm(true);//desactivamos los txt al momento de eliminar un producto. 
                this.FromProductos_Load(sender, e);//Con esto, cada producto borrado nos recargará el datagrid

            }
            else
            {
                MessageBox.Show("ERROR AL ELIMINAR DATOS " + Producto.msgError);
            }
            this.limpiarForm(false);//Volvemos a desactivarlos. 
        }

        //para consultar por nombre
        private void iconBuscar_Click(object sender, EventArgs e)
        {
            dataGridProductos.Rows.Clear();
            List<object[]> datos = prod.consultarPorNombre(txtBuscar.Text);//guardo la lista de object según lo que quiero mostrar, en una variable de object llamada datos
            for (int i = 0; i < datos.Count; i++)//recorro toda la lista de object
            {
                dataGridProductos.Rows.Add(datos[i]);//al recorrerla, le agrego los datos que tengo en la variable en el indice [i]
            }
        }

        //Cargamos los productos llamando al método cargar productos de esta clase. 
        private void FromProductos_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }
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
        //--------------------------------------Inicializaremos diversos métodos para su implementación---------------------------------------------------------------- 
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
                iconImagen.Enabled = true;
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
                comboConsola.Enabled = false;
                iconImagen.Enabled = false;
            }

        }
        //Creo el método para cargar los datos en el dataGrid
        public void cargarDatos()
        {
            dataGridProductos.Rows.Clear();
            List<object[]> datos = prod.consultarTodos();//guardo la lista de object según lo que quiero mostrar, en una variable de object llamada datos
            for (int i = 0; i < datos.Count; i++)//recorro toda la lista de object
            {
                dataGridProductos.Rows.Add(datos[i]);//al recorrerla, le agrego los datos que tengo en la variable en el indice [i]

            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}