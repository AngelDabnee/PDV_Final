namespace WinFromMenu
{
    partial class FromCajaCobro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromCajaCobro));
            panelMenuSuperior = new Panel();
            panel2 = new Panel();
            pictureBoxClose = new FontAwesome.Sharp.IconPictureBox();
            btnBuscarPorCodBarra = new Button();
            panelLogoCaja = new Panel();
            label8 = new Label();
            txtPorCodBarra = new TextBox();
            panelCantidad = new Panel();
            btnCancel = new Button();
            panel1 = new Panel();
            txtCambio1 = new TextBox();
            btnCobrar = new Button();
            iconcambi = new TextBox();
            label6 = new Label();
            iconoprecio = new TextBox();
            txtSubTotal = new TextBox();
            label5 = new Label();
            txtCantidadRecibida = new TextBox();
            iconpre = new TextBox();
            label4 = new Label();
            iconpreci = new TextBox();
            txtTotal = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panelNomCaja = new Panel();
            label7 = new Label();
            panelBuscarCodBarra = new Panel();
            numericInicio = new NumericUpDown();
            panelDataView = new Panel();
            dataGridViewProdVent = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            CANTIDAD = new DataGridViewTextBoxColumn();
            TOTAL = new DataGridViewTextBoxColumn();
            panelMenuSuperior.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panelCantidad.SuspendLayout();
            panel1.SuspendLayout();
            panelNomCaja.SuspendLayout();
            panelBuscarCodBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericInicio).BeginInit();
            panelDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdVent).BeginInit();
            SuspendLayout();
            // 
            // panelMenuSuperior
            // 
            panelMenuSuperior.BackColor = Color.Transparent;
            panelMenuSuperior.Controls.Add(panel2);
            panelMenuSuperior.Controls.Add(btnBuscarPorCodBarra);
            panelMenuSuperior.Controls.Add(panelLogoCaja);
            panelMenuSuperior.Controls.Add(label8);
            panelMenuSuperior.Controls.Add(txtPorCodBarra);
            panelMenuSuperior.Dock = DockStyle.Top;
            panelMenuSuperior.Location = new Point(0, 0);
            panelMenuSuperior.Name = "panelMenuSuperior";
            panelMenuSuperior.Size = new Size(1303, 101);
            panelMenuSuperior.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBoxClose);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1229, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(74, 101);
            panel2.TabIndex = 7;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BackColor = Color.Transparent;
            pictureBoxClose.ForeColor = SystemColors.Control;
            pictureBoxClose.IconChar = FontAwesome.Sharp.IconChar.X;
            pictureBoxClose.IconColor = SystemColors.Control;
            pictureBoxClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pictureBoxClose.IconSize = 40;
            pictureBoxClose.Location = new Point(19, 22);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(40, 40);
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // btnBuscarPorCodBarra
            // 
            btnBuscarPorCodBarra.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarPorCodBarra.Location = new Point(1069, 24);
            btnBuscarPorCodBarra.Name = "btnBuscarPorCodBarra";
            btnBuscarPorCodBarra.Size = new Size(150, 40);
            btnBuscarPorCodBarra.TabIndex = 4;
            btnBuscarPorCodBarra.Text = "BUSCAR";
            btnBuscarPorCodBarra.UseVisualStyleBackColor = true;
            btnBuscarPorCodBarra.Click += btnBuscarPorCodBarra_Click;
            // 
            // panelLogoCaja
            // 
            panelLogoCaja.BackgroundImage = (Image)resources.GetObject("panelLogoCaja.BackgroundImage");
            panelLogoCaja.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogoCaja.Dock = DockStyle.Left;
            panelLogoCaja.Location = new Point(0, 0);
            panelLogoCaja.Name = "panelLogoCaja";
            panelLogoCaja.Size = new Size(177, 101);
            panelLogoCaja.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(429, 29);
            label8.Name = "label8";
            label8.Size = new Size(227, 28);
            label8.TabIndex = 6;
            label8.Text = "CODIGO DE BARRA";
            // 
            // txtPorCodBarra
            // 
            txtPorCodBarra.Location = new Point(667, 30);
            txtPorCodBarra.Name = "txtPorCodBarra";
            txtPorCodBarra.Size = new Size(383, 27);
            txtPorCodBarra.TabIndex = 5;
            // 
            // panelCantidad
            // 
            panelCantidad.BackColor = Color.Transparent;
            panelCantidad.Controls.Add(btnCancel);
            panelCantidad.Controls.Add(panel1);
            panelCantidad.Dock = DockStyle.Left;
            panelCantidad.Location = new Point(0, 101);
            panelCantidad.Name = "panelCantidad";
            panelCantidad.Size = new Size(365, 847);
            panelCantidad.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(35, 795);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(165, 40);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(txtCambio1);
            panel1.Controls.Add(btnCobrar);
            panel1.Controls.Add(iconcambi);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(iconoprecio);
            panel1.Controls.Add(txtSubTotal);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtCantidadRecibida);
            panel1.Controls.Add(iconpre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(iconpreci);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 653);
            panel1.TabIndex = 2;
            // 
            // txtCambio1
            // 
            txtCambio1.BackColor = Color.White;
            txtCambio1.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtCambio1.ForeColor = SystemColors.MenuText;
            txtCambio1.Location = new Point(68, 522);
            txtCambio1.Name = "txtCambio1";
            txtCambio1.Size = new Size(155, 46);
            txtCambio1.TabIndex = 11;
            // 
            // btnCobrar
            // 
            btnCobrar.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCobrar.Location = new Point(32, 396);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(165, 46);
            btnCobrar.TabIndex = 14;
            btnCobrar.Text = "COBRAR";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // iconcambi
            // 
            iconcambi.BackColor = SystemColors.ActiveBorder;
            iconcambi.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconcambi.ForeColor = SystemColors.InactiveCaptionText;
            iconcambi.Location = new Point(32, 522);
            iconcambi.Name = "iconcambi";
            iconcambi.Size = new Size(30, 46);
            iconcambi.TabIndex = 12;
            iconcambi.Text = "$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(9, 491);
            label6.Name = "label6";
            label6.Size = new Size(104, 28);
            label6.TabIndex = 11;
            label6.Text = "CAMBIO";
            // 
            // iconoprecio
            // 
            iconoprecio.BackColor = SystemColors.ActiveBorder;
            iconoprecio.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconoprecio.ForeColor = SystemColors.InactiveCaptionText;
            iconoprecio.Location = new Point(32, 88);
            iconoprecio.Name = "iconoprecio";
            iconoprecio.Size = new Size(30, 46);
            iconoprecio.TabIndex = 10;
            iconoprecio.Text = "$";
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = Color.White;
            txtSubTotal.Enabled = false;
            txtSubTotal.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubTotal.ForeColor = SystemColors.Window;
            txtSubTotal.Location = new Point(68, 88);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(155, 46);
            txtSubTotal.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(7, 57);
            label5.Name = "label5";
            label5.Size = new Size(137, 28);
            label5.TabIndex = 9;
            label5.Text = "SUB TOTAL";
            // 
            // txtCantidadRecibida
            // 
            txtCantidadRecibida.BackColor = Color.White;
            txtCantidadRecibida.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtCantidadRecibida.ForeColor = SystemColors.MenuText;
            txtCantidadRecibida.Location = new Point(68, 313);
            txtCantidadRecibida.Name = "txtCantidadRecibida";
            txtCantidadRecibida.Size = new Size(155, 46);
            txtCantidadRecibida.TabIndex = 7;
            // 
            // iconpre
            // 
            iconpre.BackColor = SystemColors.ActiveBorder;
            iconpre.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconpre.ForeColor = SystemColors.InactiveCaptionText;
            iconpre.Location = new Point(32, 313);
            iconpre.Name = "iconpre";
            iconpre.Size = new Size(30, 46);
            iconpre.TabIndex = 6;
            iconpre.Text = "$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(7, 282);
            label4.Name = "label4";
            label4.Size = new Size(246, 28);
            label4.TabIndex = 5;
            label4.Text = "CANTIDAD RECIBIDA";
            // 
            // iconpreci
            // 
            iconpreci.BackColor = SystemColors.ActiveBorder;
            iconpreci.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconpreci.ForeColor = SystemColors.InactiveCaptionText;
            iconpreci.Location = new Point(32, 202);
            iconpreci.Name = "iconpreci";
            iconpreci.Size = new Size(30, 46);
            iconpreci.TabIndex = 4;
            iconpreci.Text = "$";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.ForeColor = SystemColors.Window;
            txtTotal.Location = new Point(68, 202);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(155, 46);
            txtTotal.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(7, 171);
            label3.Name = "label3";
            label3.Size = new Size(190, 28);
            label3.TabIndex = 3;
            label3.Text = "TOTAL A PAGAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(9, 14);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 2;
            label2.Text = "VENTA";
            // 
            // panelNomCaja
            // 
            panelNomCaja.BackColor = Color.Transparent;
            panelNomCaja.Controls.Add(label7);
            panelNomCaja.Location = new Point(369, 105);
            panelNomCaja.Name = "panelNomCaja";
            panelNomCaja.Size = new Size(102, 45);
            panelNomCaja.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(101, 40);
            label7.TabIndex = 10;
            label7.Text = "CAJA";
            // 
            // panelBuscarCodBarra
            // 
            panelBuscarCodBarra.BackColor = Color.Transparent;
            panelBuscarCodBarra.Controls.Add(numericInicio);
            panelBuscarCodBarra.Location = new Point(476, 103);
            panelBuscarCodBarra.Name = "panelBuscarCodBarra";
            panelBuscarCodBarra.Size = new Size(827, 47);
            panelBuscarCodBarra.TabIndex = 7;
            // 
            // numericInicio
            // 
            numericInicio.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericInicio.Location = new Point(662, 6);
            numericInicio.Name = "numericInicio";
            numericInicio.Size = new Size(47, 36);
            numericInicio.TabIndex = 8;
            numericInicio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panelDataView
            // 
            panelDataView.BackColor = Color.Transparent;
            panelDataView.Controls.Add(dataGridViewProdVent);
            panelDataView.Location = new Point(383, 177);
            panelDataView.Name = "panelDataView";
            panelDataView.Size = new Size(908, 455);
            panelDataView.TabIndex = 10;
            // 
            // dataGridViewProdVent
            // 
            dataGridViewProdVent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProdVent.BackgroundColor = Color.FromArgb(0, 0, 64);
            dataGridViewProdVent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdVent.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, PRECIO, CANTIDAD, TOTAL });
            dataGridViewProdVent.Dock = DockStyle.Fill;
            dataGridViewProdVent.GridColor = SystemColors.ControlText;
            dataGridViewProdVent.Location = new Point(0, 0);
            dataGridViewProdVent.Name = "dataGridViewProdVent";
            dataGridViewProdVent.RowHeadersWidth = 51;
            dataGridViewProdVent.RowTemplate.Height = 29;
            dataGridViewProdVent.Size = new Size(908, 455);
            dataGridViewProdVent.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            // 
            // PRECIO
            // 
            PRECIO.HeaderText = "PRECIO";
            PRECIO.MinimumWidth = 6;
            PRECIO.Name = "PRECIO";
            // 
            // CANTIDAD
            // 
            CANTIDAD.HeaderText = "CANTIDAD";
            CANTIDAD.MinimumWidth = 6;
            CANTIDAD.Name = "CANTIDAD";
            // 
            // TOTAL
            // 
            TOTAL.HeaderText = "TOTAL";
            TOTAL.MinimumWidth = 6;
            TOTAL.Name = "TOTAL";
            // 
            // FromCajaCobro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1303, 948);
            Controls.Add(panelDataView);
            Controls.Add(panelBuscarCodBarra);
            Controls.Add(panelNomCaja);
            Controls.Add(panelCantidad);
            Controls.Add(panelMenuSuperior);
            DoubleBuffered = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FromCajaCobro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FromCajaCobro";
            WindowState = FormWindowState.Maximized;
            panelMenuSuperior.ResumeLayout(false);
            panelMenuSuperior.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panelCantidad.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelNomCaja.ResumeLayout(false);
            panelNomCaja.PerformLayout();
            panelBuscarCodBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericInicio).EndInit();
            panelDataView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdVent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuSuperior;
        private Panel panelLogoCaja;
        private Panel panelCantidad;
        private Panel panel1;
        private TextBox iconpreci;
        private TextBox txtTotal;
        private Label label3;
        private Label label2;
        private TextBox iconoprecio;
        private TextBox txtSubTotal;
        private Label label5;
        private TextBox txtCantidadRecibida;
        private TextBox iconpre;
        private Label label4;
        private Button btnCancel;
        private TextBox iconcambi;
        private Label label6;
        private Panel panelNomCaja;
        private Label label7;
        private TextBox txtPorCodBarra;
        private Button btnBuscarPorCodBarra;
        private Label label8;
        private Panel panelBuscarCodBarra;
        private NumericUpDown numericInicio;
        private Panel panelDataView;
        private DataGridView dataGridViewProdVent;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn CANTIDAD;
        private DataGridViewTextBoxColumn TOTAL;
        private Button btnCobrar;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox pictureBoxClose;
        private TextBox txtCambio1;
    }
}