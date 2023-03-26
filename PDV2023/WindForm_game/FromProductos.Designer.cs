namespace WindForm_game
{
    partial class FromProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromProductos));
            label5 = new Label();
            txtBuscar = new TextBox();
            panel1 = new Panel();
            iconImagen = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            label2 = new Label();
            txtImagen = new TextBox();
            label3 = new Label();
            label7 = new Label();
            pictureBoxImagen = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtCodBarra = new TextBox();
            txtPrecio = new TextBox();
            comboConsola = new ComboBox();
            panelParaDataGrid = new Panel();
            dataGridProductos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            COD_BARRA = new DataGridViewTextBoxColumn();
            IMAGEN = new DataGridViewTextBoxColumn();
            UNIDAD = new DataGridViewTextBoxColumn();
            iconCrear = new FontAwesome.Sharp.IconPictureBox();
            iconAñadir = new FontAwesome.Sharp.IconPictureBox();
            iconEditar = new FontAwesome.Sharp.IconPictureBox();
            iconBorrar = new FontAwesome.Sharp.IconPictureBox();
            iconBuscar = new FontAwesome.Sharp.IconPictureBox();
            dialogResult = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            panelParaDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCrear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconAñadir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconBorrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconBuscar).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(678, 22);
            label5.Name = "label5";
            label5.Size = new Size(377, 44);
            label5.TabIndex = 27;
            label5.Text = "ALTA DE PRODUCTOS";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(1149, 131);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(236, 27);
            txtBuscar.TabIndex = 26;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(iconImagen);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtImagen);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBoxImagen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtCodBarra);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(comboConsola);
            panel1.Location = new Point(14, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 536);
            panel1.TabIndex = 25;
            // 
            // iconImagen
            // 
            iconImagen.BackColor = Color.White;
            iconImagen.BorderStyle = BorderStyle.Fixed3D;
            iconImagen.Enabled = false;
            iconImagen.ForeColor = SystemColors.ControlText;
            iconImagen.IconChar = FontAwesome.Sharp.IconChar.Camera;
            iconImagen.IconColor = SystemColors.ControlText;
            iconImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconImagen.IconSize = 40;
            iconImagen.Location = new Point(197, 408);
            iconImagen.Name = "iconImagen";
            iconImagen.Size = new Size(40, 40);
            iconImagen.TabIndex = 19;
            iconImagen.TabStop = false;
            iconImagen.Click += iconImagen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 27);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 83);
            label2.Name = "label2";
            label2.Size = new Size(168, 28);
            label2.TabIndex = 1;
            label2.Text = "DESCRIPCIÓN";
            // 
            // txtImagen
            // 
            txtImagen.Enabled = false;
            txtImagen.Location = new Point(269, 313);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(206, 27);
            txtImagen.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 199);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 2;
            label3.Text = "PRECIO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 310);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 17;
            label7.Text = "IMAGEN";
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.BackgroundImage = (Image)resources.GetObject("pictureBoxImagen.BackgroundImage");
            pictureBoxImagen.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxImagen.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxImagen.Enabled = false;
            pictureBoxImagen.Location = new Point(275, 351);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(200, 161);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagen.TabIndex = 11;
            pictureBoxImagen.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 135);
            label4.Name = "label4";
            label4.Size = new Size(227, 28);
            label4.TabIndex = 3;
            label4.Text = "CODIGO DE BARRA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(16, 256);
            label6.Name = "label6";
            label6.Size = new Size(122, 28);
            label6.TabIndex = 5;
            label6.Text = "CONSOLA";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(269, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(206, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(269, 83);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(206, 27);
            txtDescripcion.TabIndex = 7;
            // 
            // txtCodBarra
            // 
            txtCodBarra.Enabled = false;
            txtCodBarra.Location = new Point(269, 138);
            txtCodBarra.Name = "txtCodBarra";
            txtCodBarra.Size = new Size(206, 27);
            txtCodBarra.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(269, 202);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(206, 27);
            txtPrecio.TabIndex = 10;
            // 
            // comboConsola
            // 
            comboConsola.Enabled = false;
            comboConsola.FormattingEnabled = true;
            comboConsola.Items.AddRange(new object[] { "XBOX", "PLAYSTATION", "WI", "NINTENDO", "PC" });
            comboConsola.Location = new Point(269, 256);
            comboConsola.Name = "comboConsola";
            comboConsola.Size = new Size(206, 28);
            comboConsola.TabIndex = 9;
            // 
            // panelParaDataGrid
            // 
            panelParaDataGrid.BackColor = Color.Transparent;
            panelParaDataGrid.BorderStyle = BorderStyle.Fixed3D;
            panelParaDataGrid.Controls.Add(dataGridProductos);
            panelParaDataGrid.Location = new Point(673, 304);
            panelParaDataGrid.Name = "panelParaDataGrid";
            panelParaDataGrid.Size = new Size(975, 372);
            panelParaDataGrid.TabIndex = 24;
            // 
            // dataGridProductos
            // 
            dataGridProductos.AllowUserToDeleteRows = false;
            dataGridProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridProductos.BackgroundColor = SystemColors.ActiveCaption;
            dataGridProductos.BorderStyle = BorderStyle.Fixed3D;
            dataGridProductos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridProductos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridProductos.ColumnHeadersHeight = 29;
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridProductos.Columns.AddRange(new DataGridViewColumn[] { id, nombre, descripcion, PRECIO, COD_BARRA, IMAGEN, UNIDAD });
            dataGridProductos.GridColor = SystemColors.ActiveCaptionText;
            dataGridProductos.Location = new Point(3, 19);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.ReadOnly = true;
            dataGridProductos.RowHeadersWidth = 51;
            dataGridProductos.RowTemplate.Height = 29;
            dataGridProductos.Size = new Size(965, 339);
            dataGridProductos.TabIndex = 0;
            dataGridProductos.CellContentClick += dataGridProductos_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.HeaderText = "NOMBRE";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "DESCRIPCIÓN";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            // 
            // PRECIO
            // 
            PRECIO.HeaderText = "PRECIO";
            PRECIO.MinimumWidth = 6;
            PRECIO.Name = "PRECIO";
            PRECIO.ReadOnly = true;
            // 
            // COD_BARRA
            // 
            COD_BARRA.HeaderText = "COD_BARRA";
            COD_BARRA.MinimumWidth = 6;
            COD_BARRA.Name = "COD_BARRA";
            COD_BARRA.ReadOnly = true;
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
            UNIDAD.HeaderText = "UNIDAD";
            UNIDAD.MinimumWidth = 6;
            UNIDAD.Name = "UNIDAD";
            UNIDAD.ReadOnly = true;
            // 
            // iconCrear
            // 
            iconCrear.BackColor = SystemColors.Control;
            iconCrear.BorderStyle = BorderStyle.Fixed3D;
            iconCrear.ForeColor = SystemColors.ControlText;
            iconCrear.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            iconCrear.IconColor = SystemColors.ControlText;
            iconCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCrear.IconSize = 40;
            iconCrear.Location = new Point(1060, 242);
            iconCrear.Name = "iconCrear";
            iconCrear.Size = new Size(40, 40);
            iconCrear.TabIndex = 28;
            iconCrear.TabStop = false;
            iconCrear.Click += iconCrear_Click;
            // 
            // iconAñadir
            // 
            iconAñadir.BackColor = SystemColors.Control;
            iconAñadir.BorderStyle = BorderStyle.Fixed3D;
            iconAñadir.ForeColor = SystemColors.ControlText;
            iconAñadir.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconAñadir.IconColor = SystemColors.ControlText;
            iconAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconAñadir.IconSize = 40;
            iconAñadir.Location = new Point(738, 242);
            iconAñadir.Name = "iconAñadir";
            iconAñadir.Size = new Size(40, 40);
            iconAñadir.TabIndex = 29;
            iconAñadir.TabStop = false;
            iconAñadir.Click += iconAñadir_Click;
            // 
            // iconEditar
            // 
            iconEditar.BackColor = SystemColors.Control;
            iconEditar.BorderStyle = BorderStyle.Fixed3D;
            iconEditar.ForeColor = SystemColors.ControlText;
            iconEditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            iconEditar.IconColor = SystemColors.ControlText;
            iconEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEditar.IconSize = 40;
            iconEditar.Location = new Point(890, 242);
            iconEditar.Name = "iconEditar";
            iconEditar.Size = new Size(40, 40);
            iconEditar.TabIndex = 30;
            iconEditar.TabStop = false;
            iconEditar.Click += iconEditar_Click;
            // 
            // iconBorrar
            // 
            iconBorrar.BackColor = SystemColors.Control;
            iconBorrar.BorderStyle = BorderStyle.Fixed3D;
            iconBorrar.ForeColor = SystemColors.ControlText;
            iconBorrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconBorrar.IconColor = SystemColors.ControlText;
            iconBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBorrar.IconSize = 40;
            iconBorrar.Location = new Point(1266, 242);
            iconBorrar.Name = "iconBorrar";
            iconBorrar.Size = new Size(40, 40);
            iconBorrar.TabIndex = 31;
            iconBorrar.TabStop = false;
            iconBorrar.Click += iconBorrar_Click;
            // 
            // iconBuscar
            // 
            iconBuscar.BackColor = SystemColors.Control;
            iconBuscar.BorderStyle = BorderStyle.Fixed3D;
            iconBuscar.ForeColor = SystemColors.ControlText;
            iconBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconBuscar.IconColor = SystemColors.ControlText;
            iconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBuscar.IconSize = 40;
            iconBuscar.Location = new Point(1396, 124);
            iconBuscar.Name = "iconBuscar";
            iconBuscar.Size = new Size(40, 40);
            iconBuscar.TabIndex = 32;
            iconBuscar.TabStop = false;
            iconBuscar.Click += iconBuscar_Click;
            // 
            // dialogResult
            // 
            dialogResult.FileName = "openFileDialog1";
            // 
            // FromProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1650, 676);
            Controls.Add(iconBuscar);
            Controls.Add(iconBorrar);
            Controls.Add(iconEditar);
            Controls.Add(iconAñadir);
            Controls.Add(iconCrear);
            Controls.Add(label5);
            Controls.Add(txtBuscar);
            Controls.Add(panel1);
            Controls.Add(panelParaDataGrid);
            DoubleBuffered = true;
            Name = "FromProductos";
            Text = "Form1";
            Load += FromProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            panelParaDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCrear).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconAñadir).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconBorrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtBuscar;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtImagen;
        private Label label3;
        private Label label7;
        private PictureBox pictureBoxImagen;
        private Label label4;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtCodBarra;
        private TextBox txtPrecio;
        private ComboBox comboConsola;
        private Panel panelParaDataGrid;
        private DataGridView dataGridProductos;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn COD_BARRA;
        private DataGridViewTextBoxColumn IMAGEN;
        private DataGridViewTextBoxColumn UNIDAD;
        private FontAwesome.Sharp.IconPictureBox iconCrear;
        private FontAwesome.Sharp.IconPictureBox iconAñadir;
        private FontAwesome.Sharp.IconPictureBox iconEditar;
        private FontAwesome.Sharp.IconPictureBox iconBorrar;
        private FontAwesome.Sharp.IconPictureBox iconImagen;
        private FontAwesome.Sharp.IconPictureBox iconBuscar;
        private OpenFileDialog dialogResult;
    }
}