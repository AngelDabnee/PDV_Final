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
        Producto prodAVender;
        Venta venta;
        Logear idlog;


        public FromCajaCobro()
        {
            InitializeComponent();
            prodAVender = new Producto();
            venta = new Venta();
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "gamestore_pdv", "3306");
            idlog = new Logear();

        }
        //--------------------------GENERAMOS LA BUSQUEDA Y EL REGISTRO DE LOS PRODUCTOS POR CADA "PIP" QUE HAGAMOS AL CÓDIGO DE BARRA A LA HORA DE COBRAR
        private void btnBuscarPorCodBarra_Click(object sender, EventArgs e)
        {
            Producto res = prodAVender.consultarPorCodBarras('"' + txtPorCodBarra.Text + '"');
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
        //----------CREAREMOS EL BOTÓN PARA GENERAR EL CAMBIO DEL CLIENTE. 
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            //preparamos las vars para registra la venta
            List<ProductoAVender> prodsAVender = new List<ProductoAVender>();
            for (int i = 0; i < dataGridViewProdVent.Rows.Count - 1; i++)//ESTE FOR SIGNIFICA QUE RECORRREREMOS LOS RENGLONES Y CONTAREMOS LOS RENGLONES PARA SUMAR SEGÚN EL ID Y LA CANTIDAD
            {

                //agregar un ProductoAVender a la lista
                ProductoAVender prodVender = new ProductoAVender(int.Parse(dataGridViewProdVent.Rows[i].Cells[0].Value.ToString()), int.Parse(dataGridViewProdVent.Rows[i].Cells[3].Value.ToString()));
                prodsAVender.Add(prodVender);//AGREGAMOS LOS VALORES QUE OBTUVIMOS PARA AÑADIRLOS A LA VARIABLE DE VENTA DE PRODUCTOS

            }
            //cambio
            double cambio = venta.registrarVenta(Logear.id, double.Parse(txtTotal.Text), double.Parse(txtCantidadRecibida.Text), prodsAVender);//RECUERDA MODIFICAR EL ID DEL EMPLEADO EN ESTE CASO MANEJAREMOS EL 1 PARA EL EJEMPLO
            //si hay error
            if (cambio == -1)
            {
                MessageBox.Show("ERROR AL REGISTRAR LA VENTA" + Venta.msgError);
            }
            else
            {
                double numRedon = Math.Round(cambio, 2);//CON ESTO REDONDEAMOS. 
                MessageBox.Show($"VENTA REGISTRADA CON ÉXITO");
                MessageBox.Show($"SU CAMBIO ES {numRedon}");
                this.limpiarProd();
            }
        }
        private void btnCambio_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtCantidadRecibida.Text) >= double.Parse(txtTotal.Text))
            {
                btnCobrar.Enabled = true;
                double total = double.Parse(txtTotal.Text);//CREAMOS UNA VARIABLE TOTAL PARA QUE ESTA TOME EL VALOR DE LO QUE SE ENCUENTRA EN TXTTOTAL
                double cantidadRecibida = double.Parse(txtCantidadRecibida.Text);//CREAMOS UNA VARIABLE PARA LA CANTIDAD RECIBIDA QUE RECIBAMOS DEL CLIENTE
                double cambio = 0;//GENERAMOS LA VARIABLE CAMBIO QUE UTILIZAREMOS CADA VEZ QUE CREEMOS UNA NUEVA COMPRA
                double res = (cantidadRecibida - total);//----REALIZAMOS LAS OPERACIONES PARA LA COMPRA. EN ESTE CASO GENERAMOS EL CAMBIO QUE DEBEMOS ENTREGARLE AL USUARIO. 
                txtCambio1.Text = res.ToString();//le damos el cambio o saldra negativa si le hace falta dinero. 

            }
        }
        //ELIMINAMOS TODO AL MOMENTO DE CANCELAR, PERO SOLO EL RENGLON Y RECARGAMOS LOS DATOS. 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataGridViewProdVent.Rows.RemoveAt(this.dataGridViewProdVent.CurrentRow.Index);//Con esto eliminaremos el renglon seleccionado. 
            this.recargar();
        }
        //-------------------------------------------crearemos un metodo para limpiar a la hora de pagar. 
        private void limpiarProd()
        {
            txtCambio1.Clear();
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
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
