using Back_CRUDs_BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Middle_gamestore_PDV;
using System.Windows.Media.Media3D;

namespace WinFromMenu
{
    public partial class Login : Form
    {
        CRUDs_BD bd;
        //Logear log = new Logear();
        //Logear logear = new Logear();
        Empleado sesion = new Empleado();

        public Login()
        {
            InitializeComponent();
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv", "3306");
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            sesion = sesion.login(txtEmail.Text, txtPassword.Text);
            try
            {
                if (sesion == null)
                {
                    MessageBox.Show("USUARIO Y/O CONTRASEÑA NO COINCIDEN" + Empleado.msgError);
                }
                else
                {
                    Form1.sesion = this.sesion;
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR GENERAL " + ex.Message);
            }
        }

        private void pictureVisible_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureNoVisible_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuDeCierre menuDeCierre = new MenuDeCierre();
            menuDeCierre.ShowDialog();
        }
    }
}