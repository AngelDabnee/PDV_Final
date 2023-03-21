using Middle_gamestore_PDV;
using System.Windows.Media.Media3D;
using System.Windows.Forms;
using Back_CRUDs_BD;
using MySql.Data.MySqlClient;

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

        private void iconAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Enabled == false && txtDescripcion.Enabled == false && txtCodBarra.Enabled == false && txtPrecio.Enabled == false && txtImagen.Enabled == false && comboConsola.Enabled == false)
            {
                this.limpiarForm(true);
            }
        }

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
                this.limpiarForm(true);
            }
        }

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
            bool resultado = prod.modificar(txtNombre.Text, txtDescripcion.Text, double.Parse(txtPrecio.Text), txtCodBarra.Text, txtImagen.Text, valorConsola, (int)dataGridProductos.Rows[0].Cells[0].Value);
            if (resultado == false)
            {
                MessageBox.Show("ERROR AL MODIFICAR PRODUCTO" + Producto.msgError);
            }
            else
            {
                MessageBox.Show("PRODUCTO MODIFICADO CON ÉXITO");

            }
            this.limpiarForm(false);
            
        }
        private void FromProductos_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }
        private void iconBorrar_Click(object sender, EventArgs e)
        {
            int id = 0;
            bool resultado = prod.borrar(id);
            if (resultado == false)
            {
                MessageBox.Show("ERROR AL ELIMINAR DATOS " + Producto.msgError);
            }
            else
            {
                MessageBox.Show("PRODUCTO ELIMINADO CON ÉXITO");
                this.limpiarForm(true);
            }
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
            List<object[]> datos = prod.consultarTodos();//guardo la lista de object según lo que quiero mostrar, en una variable de object llamada datos
            for (int i = 0; i < datos.Count; i++)//recorro toda la lista de object
            {
                dataGridProductos.Rows.Add(datos[i]);//al recorrerla, le agrego los datos que tengo en la variable en el indice [i]

            }

        }
    }
}