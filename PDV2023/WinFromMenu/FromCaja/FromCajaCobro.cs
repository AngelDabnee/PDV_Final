using Middle_gamestore_PDV;
using System.Windows.Media.Media3D;
using System.Windows.Forms;
using Back_CRUDs_BD;
using MySql.Data.MySqlClient;
using System.CodeDom.Compiler;
using FontAwesome.Sharp;
using System.Windows.Interop;

namespace WinFromMenu
{
    public partial class FromCajaCobro : Form
    {
        CRUDs_BD bd;//para utilizar la conexión a la bd
        Producto prod;
        public FromCajaCobro()
        {
            InitializeComponent();
            prod = new Producto();
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv", "3306");

        }
        //--------------------------GENERAMOS LA BUSQUEDA Y EL REGISTRO DE LOS PRODUCTOS POR CADA "PIP" QUE HAGAMOS AL CÓDIGO DE BARRA A LA HORA DE COBRAR
        private void btnBuscarPorCodBarra_Click(object sender, EventArgs e)
        {
            Producto res = prod.consultarPorCodBarras('"' + txtPorCodBarra.Text + '"');
            if (res == null)
            {
                MessageBox.Show("PRODUCTO NO EXISTENTE" + Producto.msgError);
            }
            else
            {
                //Si el producto existe crearemos en el dtgrid el renglon y el producto. 
                dataGridViewProdVent.Rows.Add(new object[]
                {
                    res.id, res.nombre, res.precio, numericInicio.Value, res.precio * double.Parse(numericInicio.Value.ToString())
                });
                //
                //LIMPIAMOS PARA BUSCAR Y MULTIPLICAR POR LA CANTIDAD NECESITADA
                txtPorCodBarra.Clear();
                numericInicio.Value = 1;
                int col = dataGridViewProdVent.ColumnCount - 1;
                double subtotal = 0;
                for (int i = 0; i < dataGridViewProdVent.Rows.Count - 1; i++)
                {
                    subtotal += double.Parse(dataGridViewProdVent.Rows[i].Cells[col].Value.ToString());
                }
                txtSubTotal.Text = (subtotal / 0.16).ToString();//AQUÍ CALCULAMOS EL IVA TOTAL DE LOS PRODUCTOS Y SE LO ASIGNAMOS A NUESTRO TXT SUBTOTAL
                txtTotal.Text = subtotal.ToString();//---GENERAMOS EL TOTAL DE LOS PRODUCTOS. (RECORDAR QUE EL TOTAL YA ESTA REGISTRADO EN LA BASE DE DATOS). 
            }
        }
        //----------------------CREAMOS EL MÉTODO PARA PODER CALCULAR EL CAMBIO DE LOS PRODUCTOS QUE SE REGISTREN PARA LA VENTA-----
        private void btnCambio_Click(object sender, EventArgs e)
        {
            double total = double.Parse(txtTotal.Text);//CREAMOS UNA VARIABLE TOTAL PARA QUE ESTA TOME EL VALOR DE LO QUE SE ENCUENTRA EN TXTTOTAL
            double cantidadRecibida = double.Parse(txtCantidadRecibida.Text);//CREAMOS UNA VARIABLE PARA LA CANTIDAD RECIBIDA QUE RECIBAMOS DEL CLIENTE
            double cambio = 0;//GENERAMOS LA VARIABLE CAMBIO QUE UTILIZAREMOS CADA VEZ QUE CREEMOS UNA NUEVA COMPRA
            double res = (cantidadRecibida - total);//----REALIZAMOS LAS OPERACIONES PARA LA COMPRA. EN ESTE CASO GENERAMOS EL CAMBIO QUE DEBEMOS ENTREGARLE AL USUARIO. 
            txtCambio.Text = res.ToString();//le damos el cambio o saldra negativa si le hace falta dinero. 
        }
        //----------CREAREMOS EL EVENTO PARA PODER GENERAR EL PAGO. 
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            double res = double.Parse(txtCambio.Text.ToString());
            if (res == 0)
            {
                MessageBox.Show("GRACIAS POR SU COMPRA");
                this.limpiarProd();
            }
            else
            {
                MessageBox.Show("QUEDA PENDIENTE " + res);
            }
        }

        //ELIMINAMOS TODO AL MOMENTO DE CANCELAR
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataGridViewProdVent.Rows.RemoveAt(this.dataGridViewProdVent.CurrentRow.Index);//Con esto eliminaremos el renglon seleccionado. 
            this.recargar();
        }
        //----crearemos un metodo para limpiar a la hora de pagar. 
        private void limpiarProd()
        {
            txtCambio.Clear();
            txtCantidadRecibida.Clear();
            txtPorCodBarra.Clear();
            txtTotal.Clear();
            txtSubTotal.Clear();
        }
        //--------------crearemos un método para recargar el formulario cuando eliminemos algo del datagrids. 
        private void recargar()
        {
            txtPorCodBarra.Clear();
            numericInicio.Value = 1;
            int col = dataGridViewProdVent.ColumnCount - 1;
            double subtotal = 0;
            for (int i = 0; i < dataGridViewProdVent.Rows.Count - 1; i++)
            {
                subtotal += double.Parse(dataGridViewProdVent.Rows[i].Cells[col].Value.ToString());
            }
            txtSubTotal.Text = (subtotal / 0.16).ToString();//AQUÍ CALCULAMOS EL IVA TOTAL DE LOS PRODUCTOS Y SE LO ASIGNAMOS A NUESTRO TXT SUBTOTAL
            txtTotal.Text = subtotal.ToString();//---GENERAMOS EL TOTAL DE LOS PRODUCTOS. (RECORDAR QUE EL TOTAL YA ESTA REGISTRADO EN LA BASE DE DATOS). 
        }
    }
}
