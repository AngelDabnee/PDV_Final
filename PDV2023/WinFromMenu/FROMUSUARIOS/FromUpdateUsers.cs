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
    public partial class FromUpdateUsers : Form
    {
        Empleado empleado = new Empleado(); //un tipo de producto vacio. 
        CRUDs_BD bd;//para utilizar la conexión a la bd
        int id; //id para realizar el update


        public FromUpdateUsers()
        {
            InitializeComponent();
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv", "3306");
        }

        private void btnAñadirUsers_Click(object sender, EventArgs e)
        {
            if (txtNombre.Enabled == false && txtApellido.Enabled == false &&
            txtPassword.Enabled == false && txtConfirmPass.Enabled == false && txtEmail.Enabled == false
            && comboBoxRol.Enabled == false && btnFotoUsers.Enabled == false && btnGuardarUsers.Enabled == false && txtCelular.Enabled == false)
            {
                this.limpiarForm(true);
            }
        }

        private void btnGuardarUsers_Click(object sender, EventArgs e)
        {
            Roles valorRol;
            //Valoramos que tipo de consola eligió el usuario. 
            switch (comboBoxRol.SelectedItem.ToString())
            {
                case "ADMIN":
                    valorRol = Roles.ADMIN;
                    break;
                case "USUARIO":
                    valorRol = Roles.USUARIO;
                    break;
                default:
                    valorRol = Roles.USUARIO;
                    break;
            }
            try
            {
                if (txtPassword.Text == txtConfirmPass.Text)
                {
                    bool resultado = empleado.modificarUsuario(txtNombre.Text, txtApellido.Text, txtCelular.Text, txtPassword.Text, txtEmail.Text, valorRol, txtImagen.Text, id);//Con esto metemos en el insert
                    if (resultado == false)
                    {
                        MessageBox.Show("ERROR AL MODIFICAR USUARIO" + Empleado.msgError);
                    }
                    else
                    {
                        MessageBox.Show("USUARIO MODIFICADO CON ÉXITO");
                        if (pictureBoxUsers.Image != null)
                        {
                            pictureBoxUsers.Image.Save("..\\..\\..\\imagenesUsuarios\\" + txtImagen.Text);//Guardaremos la foto. opción uno. 
                                                                                                          //pictureBoxImagen.Image.Save("..\\..\\..\\..\\..\\..\\..\\fotosProductos\\" + txtImagen.Text);//Guardaremos la foto. opción 2 
                        }
                        this.limpiarAlGuardar(false);
                        this.FromUpdateUsers_Load(sender, e);
                    }

                }
                else
                {
                    MessageBox.Show("CONTRASEÑAS NO IGUALES, VOLVERLO A INTENTAR");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnFotoUsers_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialogModificar.ShowDialog();
            //cargar el archivo
            if (res == DialogResult.OK)
            {
                pictureBoxUsers.Image = new Bitmap(openFileDialogModificar.FileName);
                //crear un nombre unico
                DateTime dtNombre = DateTime.Now;
                string nombreImg = "prod_" + dtNombre.Ticks + ".png";
                txtImagen.Text = nombreImg;
            }
            //por si le da click en cerrar. 
            else { }
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
                this.id = (int)dataGridUsers.Rows[celdas].Cells[0].Value;//Convertimos para no tener error de tipos de dato
                                                                         //Además de esto, esta la usamos, para pasar los datos del producto
                                                                         //y eliminarlos sin afectar TODOS los datos de la tabla
            }
        }
        private void FromUpdateUsers_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //--------------------------------------------------MÉTODOS--------------------------------------
        #region
        //-------------------------------------------------MÉTODO PARA CARGAR USUARIOS AL INICIAR--------
        public void cargarDatos()
        {
            dataGridUsers.Rows.Clear();
            List<object[]> datos = empleado.consultarTodoUsers();//guardo la lista de object según lo que quiero mostrar, en una variable de object llamada datos
            for (int i = 0; i < datos.Count; i++)//recorro toda la lista de object
            {
                dataGridUsers.Rows.Add(datos[i]);//al recorrerla, le agrego los datos que tengo en la variable en el indice [i]
            }
        }
        //---------------------------------------------MÉTODO PARA LIMPIAR LOS TXT-------------------------------
        public void limpiarForm(bool habilita)
        {
            if (habilita)
            {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtPassword.Enabled = true;
                txtConfirmPass.Enabled = true;
                txtEmail.Enabled = true;
                comboBoxRol.Enabled = true;
                comboBoxRol.Enabled = true;
                txtImagen.Enabled = true;
                txtCelular.Enabled = true;
                btnGuardarUsers.Enabled = true;
                btnFotoUsers.Enabled = true;
            }
            else
            {
                //habilitamos y limpiamos los texts
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtPassword.Enabled = false;
                txtConfirmPass.Enabled = false;
                txtEmail.Enabled = false;
                comboBoxRol.Enabled = false;
                comboBoxRol.Enabled = false;
                txtImagen.Enabled = false;
                txtCelular.Enabled = false;
                btnGuardarUsers.Enabled = false;
                btnFotoUsers.Enabled = false;
            }

        }
        public void limpiarAlGuardar(bool habilita)
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
                btnGuardarUsers.Enabled = true;
                btnFotoUsers.Enabled = true;
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
                btnGuardarUsers.Enabled = false;
                btnFotoUsers.Enabled = false;
            }
            #endregion
        }
    }
}
