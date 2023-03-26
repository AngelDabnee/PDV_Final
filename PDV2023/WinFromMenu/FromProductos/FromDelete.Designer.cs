namespace WinFromMenu
{
    partial class FromDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromDelete));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            buttonDelet = new Button();
            pictureBox1 = new PictureBox();
            pictureBoxClose = new FontAwesome.Sharp.IconPictureBox();
            panelDataGridView = new Panel();
            dataGridProductos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            DESCRIPCION = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            CODIGOBARRA = new DataGridViewTextBoxColumn();
            IMAGEN = new DataGridViewTextBoxColumn();
            UNIDAD = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtImagen = new TextBox();
            label3 = new Label();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtCodBarra = new TextBox();
            txtPrecio = new TextBox();
            comboConsola = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(buttonDelet);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(panelDataGridView);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtImagen);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtCodBarra);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(comboConsola);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1303, 948);
            panel1.TabIndex = 27;
            // 
            // buttonDelet
            // 
            buttonDelet.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelet.Location = new Point(1104, 637);
            buttonDelet.Name = "buttonDelet";
            buttonDelet.Size = new Size(150, 45);
            buttonDelet.TabIndex = 25;
            buttonDelet.Text = "BORRAR";
            buttonDelet.UseVisualStyleBackColor = true;
            buttonDelet.Click += buttonDelet_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(974, 476);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BackColor = Color.Transparent;
            pictureBoxClose.Dock = DockStyle.Right;
            pictureBoxClose.ForeColor = SystemColors.Window;
            pictureBoxClose.IconChar = FontAwesome.Sharp.IconChar.X;
            pictureBoxClose.IconColor = SystemColors.Window;
            pictureBoxClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pictureBoxClose.IconSize = 40;
            pictureBoxClose.Location = new Point(1263, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(40, 734);
            pictureBoxClose.TabIndex = 23;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // panelDataGridView
            // 
            panelDataGridView.Controls.Add(dataGridProductos);
            panelDataGridView.Dock = DockStyle.Bottom;
            panelDataGridView.Location = new Point(0, 734);
            panelDataGridView.Name = "panelDataGridView";
            panelDataGridView.Size = new Size(1303, 214);
            panelDataGridView.TabIndex = 20;
            // 
            // dataGridProductos
            // 
            dataGridProductos.AllowUserToDeleteRows = false;
            dataGridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridProductos.BackgroundColor = Color.FromArgb(0, 0, 64);
            dataGridProductos.BorderStyle = BorderStyle.Fixed3D;
            dataGridProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductos.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, DESCRIPCION, PRECIO, CODIGOBARRA, IMAGEN, UNIDAD });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridProductos.Dock = DockStyle.Fill;
            dataGridProductos.GridColor = SystemColors.ControlText;
            dataGridProductos.Location = new Point(0, 0);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.ReadOnly = true;
            dataGridProductos.RowHeadersWidth = 51;
            dataGridProductos.RowTemplate.Height = 29;
            dataGridProductos.Size = new Size(1303, 214);
            dataGridProductos.TabIndex = 0;
            dataGridProductos.CellContentClick += dataGridProductos_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            DESCRIPCION.HeaderText = "DESCRIPCION";
            DESCRIPCION.MinimumWidth = 6;
            DESCRIPCION.Name = "DESCRIPCION";
            DESCRIPCION.ReadOnly = true;
            // 
            // PRECIO
            // 
            PRECIO.HeaderText = "PRECIO";
            PRECIO.MinimumWidth = 6;
            PRECIO.Name = "PRECIO";
            PRECIO.ReadOnly = true;
            // 
            // CODIGOBARRA
            // 
            CODIGOBARRA.HeaderText = "CODIGO BARRA";
            CODIGOBARRA.MinimumWidth = 6;
            CODIGOBARRA.Name = "CODIGOBARRA";
            CODIGOBARRA.ReadOnly = true;
            // 
            // IMAGEN
            // 
            IMAGEN.HeaderText = "IMAGEN";
            IMAGEN.MinimumWidth = 6;
            IMAGEN.Name = "IMAGEN";
            IMAGEN.ReadOnly = true;
            // 
            // UNIDAD
            // 
            UNIDAD.HeaderText = "CONSOLA";
            UNIDAD.MinimumWidth = 6;
            UNIDAD.Name = "UNIDAD";
            UNIDAD.ReadOnly = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(91, 86);
            label1.Name = "label1";
            label1.Size = new Size(148, 38);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(91, 142);
            label2.Name = "label2";
            label2.Size = new Size(227, 38);
            label2.TabIndex = 1;
            label2.Text = "DESCRIPCIÓN";
            // 
            // txtImagen
            // 
            txtImagen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtImagen.Enabled = false;
            txtImagen.Location = new Point(433, 369);
            txtImagen.Margin = new Padding(6);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(821, 27);
            txtImagen.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(97, 258);
            label3.Name = "label3";
            label3.Size = new Size(132, 38);
            label3.TabIndex = 2;
            label3.Text = "PRECIO";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(97, 369);
            label7.Name = "label7";
            label7.Size = new Size(138, 38);
            label7.TabIndex = 17;
            label7.Text = "IMAGEN";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(91, 194);
            label4.Name = "label4";
            label4.Size = new Size(300, 38);
            label4.TabIndex = 3;
            label4.Text = "CODIGO DE BARRA";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(97, 315);
            label6.Name = "label6";
            label6.Size = new Size(163, 38);
            label6.TabIndex = 5;
            label6.Text = "CONSOLA";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(433, 86);
            txtNombre.Margin = new Padding(6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(821, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(433, 142);
            txtDescripcion.Margin = new Padding(6);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(821, 27);
            txtDescripcion.TabIndex = 7;
            // 
            // txtCodBarra
            // 
            txtCodBarra.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCodBarra.Enabled = false;
            txtCodBarra.Location = new Point(433, 194);
            txtCodBarra.Margin = new Padding(6);
            txtCodBarra.Name = "txtCodBarra";
            txtCodBarra.Size = new Size(821, 27);
            txtCodBarra.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(433, 258);
            txtPrecio.Margin = new Padding(6);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(821, 27);
            txtPrecio.TabIndex = 10;
            // 
            // comboConsola
            // 
            comboConsola.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboConsola.Enabled = false;
            comboConsola.FormattingEnabled = true;
            comboConsola.Items.AddRange(new object[] { "XBOX", "PLAYSTATION", "WI", "NINTENDO", "PC" });
            comboConsola.Location = new Point(433, 315);
            comboConsola.Margin = new Padding(6);
            comboConsola.Name = "comboConsola";
            comboConsola.Size = new Size(821, 28);
            comboConsola.TabIndex = 9;
            // 
            // FromDelet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1303, 948);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FromDelet";
            Text = "FromDelet";
            WindowState = FormWindowState.Maximized;
            Load += FromDelet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox pictureBoxClose;
        private Panel panelDataGridView;
        private DataGridView dataGridProductos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn DESCRIPCION;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn CODIGOBARRA;
        private DataGridViewTextBoxColumn IMAGEN;
        private DataGridViewTextBoxColumn UNIDAD;
        private Label label1;
        private Label label2;
        private TextBox txtImagen;
        private Label label3;
        private Label label7;
        private Label label4;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtCodBarra;
        private TextBox txtPrecio;
        private ComboBox comboConsola;
        private PictureBox pictureBox1;
        private Button buttonDelet;
    }
}