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
    public partial class FromBuscarUsuarios : Form
    {
        Empleado empleado = new Empleado();
        CRUDs_BD bd;//para utilizar la conexión a la bd
        public FromBuscarUsuarios()
        {
            InitializeComponent();
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv", "3306");
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            dataGridUsers.Rows.Clear();
            List<object[]> datos = empleado.consultarPorNombreUsuario(txtBuscar.Text);//guardo la lista de object según lo que quiero mostrar, en una variable de object llamada datos
            for (int i = 0; i < datos.Count; i++)//recorro toda la lista de object
            {
                dataGridUsers.Rows.Add(datos[i]);//al recorrerla, le agrego los datos que tengo en la variable en el indice [i]
            }

        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int celdas = e.RowIndex;//Al index donde le dimos click, (se llama e)
                //con esto haremos que al darle clik al producto nos enviará la foto en el picture box. 
                txtImagen.Text = dataGridUsers.Rows[celdas].Cells[7].Value.ToString();
                pictureBoxImagen.ImageLocation = "..\\..\\..\\imagenesUsuarios\\" + txtImagen.Text;//para recargar la foto. 

            }
        }
        private void FromBuscarUsuarios_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //--------------------------------------MÉTODO PARA CARGAR DATOS-----------------------------------
        public void cargarDatos()
        {
            dataGridUsers.Rows.Clear();
            List<object[]> datos = empleado.consultarTodoUsers();//guardo la lista de object según lo que quiero mostrar, en una variable de object llamada datos
            for (int i = 0; i < datos.Count; i++)//recorro toda la lista de object
            {
                dataGridUsers.Rows.Add(datos[i]);//al recorrerla, le agrego los datos que tengo en la variable en el indice [i]

            }
        }
    }
}
