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
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            openHijoFrom(new FromAddcs());
        }
        private void buttonDelet_Click(object sender, EventArgs e)
        {
            openHijoFrom((new FromDelet()));
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            openHijoFrom((new FromUpdate()));
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
            Form form = new FromDelet();
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

        #endregion


    }
}
