using Middle_gamestore_PDV;
using System.Windows.Media.Media3D;
using System.Windows.Forms;
using Back_CRUDs_BD;
using MySql.Data.MySqlClient;
using System.CodeDom.Compiler;
using FontAwesome.Sharp;
using System.Runtime.CompilerServices;

namespace WinFromMenu
{
    public partial class FromDeleteUsers : Form
    {
        Empleado empleado = new Empleado(); //un tipo de producto vacio. 
        CRUDs_BD bd;//para utilizar la conexión a la bd
        int identi = 0;
        public FromDeleteUsers()
        {
            InitializeComponent();
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv", "3306");

        }

        private void btnBorrarUsers_Click(object sender, EventArgs e)
        {
            bool res = empleado.borrarUsuario(identi);
            if (res == false)
            {
                MessageBox.Show("USUARIO ELIMINADO CON ÉXITO");
                if (pictureBoxUsers.Image != null)
                {
                    File.Delete("..\\..\\..\\imagenesUsuarios\\" + txtImagen.Text);
                }
                this.limpiarForm(true);//desactivamos los txt al momento de eliminar un producto. 
                this.FromDeleteUsers_Load(sender, e); //Con esto, cada producto borrado nos recargará el datagrida
            }
            else
            {
                MessageBox.Show("ERROR AL ELIMINAR USUARIO " + Producto.msgError);
            }
            this.limpiarForm(false);//Volvemos a desactivarlos. 
        }
        private void FromDeleteUsers_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }
        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int celdas = e.RowIndex;//Al index donde le dimos click, (se llama e)
                //En cada campo, de la tabla, en la variable creada, en la celda de la posición del campo
                txtNombre.Text = dataGridUsers.Rows[celdas].Cells[1].Value.ToString();
                txtApellido.Text = dataGridUsers.Rows[celdas].Cells[2].Value.ToString();
                txtCelular.Text = dataGridUsers.Rows[celdas].Cells[3].Value.ToString();
                txtPassword.Text = dataGridUsers.Rows[celdas].Cells[4].Value.ToString();
                txtEmail.Text = dataGridUsers.Rows[celdas].Cells[5].Value.ToString();
                txtImagen.Text = dataGridUsers.Rows[celdas].Cells[7].Value.ToString();
                comboBoxRol.SelectedItem = dataGridUsers.Rows[celdas].Cells[6].Value.ToString();
                pictureBoxUsers.ImageLocation = "..\\..\\..\\imagenesUsuarios\\" + txtImagen.Text;//para recargar la foto. 
                this.identi = (int)dataGridUsers.Rows[celdas].Cells[0].Value;//Convertimos para no tener error de tipos de dato
                                                                             //Además de esto, esta la usamos, para pasar los datos del producto
            }
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //---------------------MÉTODOS. 
        #region
        public void limpiarForm(bool habilita)
        {
            if (habilita)
            {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = true;
                txtNombre.Clear();
                txtApellido.Enabled = true;
                txtApellido.Clear();
                txtPassword.Enabled = true;
                txtPassword.Clear();
                txtConfirmPass.Enabled = true;
                txtConfirmPass.Clear();
                txtEmail.Enabled = true;
                txtEmail.Clear();
                comboBoxRol.Enabled = true;
                comboBoxRol.Enabled = true;
                txtImagen.Enabled = true;
                txtImagen.Clear();
                txtCelular.Enabled = true;
                txtCelular.Clear();
            }
            else
            {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = false;
                txtNombre.Clear();
                txtApellido.Enabled = false;
                txtApellido.Clear();
                txtPassword.Enabled = false;
                txtPassword.Clear();
                txtConfirmPass.Enabled = false;
                txtConfirmPass.Clear();
                txtEmail.Enabled = false;
                txtEmail.Clear();
                comboBoxRol.Enabled = false;
                comboBoxRol.Enabled = false;
                txtImagen.Enabled = false;
                txtImagen.Clear();
                txtCelular.Enabled = false;
                txtCelular.Clear();
            }
        }
        public void cargarDatos()
        {
            dataGridUsers.Rows.Clear();
            List<object[]> datos = empleado.consultarTodoUsers();//guardo la lista de object según lo que quiero mostrar, en una variable de object llamada datos
            for (int i = 0; i < datos.Count; i++)//recorro toda la lista de object
            {
                dataGridUsers.Rows.Add(datos[i]);//al recorrerla, le agrego los datos que tengo en la variable en el indice [i]
            }
        }
        #endregion
    }
}