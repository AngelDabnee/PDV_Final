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
    public partial class Form1 : Form
    {
        public static Empleado sesion;
        //variable de sesion
        public Form1()
        {
            InitializeComponent();
        }
        //FORM PARA ABRIR. 
        private void buttonSubMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDebajo);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            openHijoFrom(new FromAddcs());
        }
        private void buttonDelet_Click(object sender, EventArgs e)
        {
            openHijoFrom((new FromDelete()));
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            openHijoFrom((new FromUpdate()));
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            openHijoFrom(new FromBuscar());
        }
        //-------------------------IMPLEMENTAMOS LOS BOTONES PARA LOS USUARIOS-------------------------------------------
        private void btnSubMenuUser_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubUser);
        }
        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            openHijoFrom(new FromAddUsers());
        }
        private void btnUpdateUsers_Click(object sender, EventArgs e)
        {
            openHijoFrom(new FromUpdateUsers());
        }
        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            openHijoFrom(new FromDeleteUsers());
        }
        private void btnBuscarUsers_Click(object sender, EventArgs e)
        {
            openHijoFrom(new FromBuscarUsuarios());
        }
        //----------------------------LLAMAREMOS CAJA
        private void btnCaja_Click(object sender, EventArgs e)
        {
            openHijoFrom(new FromCajaCobro());
        }

        #region
        //----------------------------------Definiremos métodos para mostrar diversos formularios.------------------
        #region
        private void mostrarAddForm()
        {
            Form form = new FromAddcs();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;//quitamos los botones de cerrar, minimizar
            form.Dock = DockStyle.Fill;
            panelForm.Controls.Add(form);
            panelForm.Tag = form;
            form.Show();
        }
        private void mostrarFromDelete()
        {
            Form form = new FromDelete();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;//quitamos los botones de cerrar, minimizar
            form.Dock = DockStyle.Fill;
            panelForm.Controls.Add(form);
            panelForm.Tag = form;
            form.Show();
        }
        private void mostrarFromUpdate()
        {
            Form form = new FromUpdate();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;//quitamos los botones de cerrar, minimizar
            form.Dock = DockStyle.Fill;
            panelForm.Controls.Add(form);
            panelForm.Tag = form;
            form.Show();
        }
        #endregion
        //-----------metodo para abrir un unico formulario. 
        private Form activeForm = null;
        private void openHijoFrom(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelForm.Controls.Add(form);
            panelForm.Tag = form;
            form.Show();
        }
        //------------------------------Método para ocultar y mostrar los submenu
        private void customizeDesing()
        {
            panelDebajo.Visible = false;
        }
        //----------------------------metodo para enseñar
        private void hideSubMenu()
        {
            if (panelDebajo.Visible == true)
            {
                panelDebajo.Visible = false;
            }
        }
        //------------------------método para desplegar y no desplegar el menú. 
        private void showSubMenu(Panel submenu1)
        {
            if (submenu1.Visible == false)
            {
                hideSubMenu();
                submenu1.Visible = true;
            }
            else
            {
                submenu1.Visible = false;

            }
        }

        #endregion

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //mostrsr el login
            Login login = new Login();
            login.ShowDialog();
            //AQUI!!!
            if (Form1.sesion.rol == Roles.USUARIO)
            {
                this.Hide();
                FromCajaCobro caja = new FromCajaCobro();
                caja.ShowDialog();
                Login loginForm = new Login();
                login.ShowDialog();
                this.Show();
            }
        }
    }
}
