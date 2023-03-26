namespace WinFromMenu
{
    partial class FromBuscarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromBuscarUsuarios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtImagen = new TextBox();
            pictureBoxClose = new FontAwesome.Sharp.IconPictureBox();
            pictureBoxImagen = new PictureBox();
            iconBuscar = new FontAwesome.Sharp.IconPictureBox();
            txtBuscar = new TextBox();
            panelDataGridView = new Panel();
            dataGridProductos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            DESCRIPCION = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            CODIGOBARRA = new DataGridViewTextBoxColumn();
            IMAGEN = new DataGridViewTextBoxColumn();
            UNIDAD = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconBuscar).BeginInit();
            panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            SuspendLayout();
            // 
            // txtImagen
            // 
            txtImagen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtImagen.Enabled = false;
            txtImagen.Location = new Point(540, 548);
            txtImagen.Margin = new Padding(6);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(110, 27);
            txtImagen.TabIndex = 43;
            txtImagen.Visible = false;
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
            pictureBoxClose.Size = new Size(40, 593);
            pictureBoxClose.TabIndex = 42;
            pictureBoxClose.TabStop = false;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.BackgroundImage = (Image)resources.GetObject("pictureBoxImagen.BackgroundImage");
            pictureBoxImagen.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxImagen.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxImagen.Enabled = false;
            pictureBoxImagen.Location = new Point(814, 289);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(330, 286);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagen.TabIndex = 41;
            pictureBoxImagen.TabStop = false;
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
            iconBuscar.Location = new Point(1191, 120);
            iconBuscar.Name = "iconBuscar";
            iconBuscar.Size = new Size(40, 40);
            iconBuscar.TabIndex = 40;
            iconBuscar.TabStop = false;
            iconBuscar.Click += iconBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(112, 129);
            txtBuscar.Margin = new Padding(6);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(1010, 27);
            txtBuscar.TabIndex = 39;
            // 
            // panelDataGridView
            // 
            panelDataGridView.Controls.Add(dataGridProductos);
            panelDataGridView.Dock = DockStyle.Bottom;
            panelDataGridView.Location = new Point(0, 593);
            panelDataGridView.Name = "panelDataGridView";
            panelDataGridView.Size = new Size(1303, 355);
            panelDataGridView.TabIndex = 38;
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
            dataGridProductos.Size = new Size(1303, 355);
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
            // FromBuscarUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1303, 948);
            Controls.Add(txtImagen);
            Controls.Add(pictureBoxClose);
            Controls.Add(pictureBoxImagen);
            Controls.Add(iconBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(panelDataGridView);
            DoubleBuffered = true;
            Name = "FromBuscarUsuarios";
            Text = "FromBuscarUsuarios";
            Load += FromBuscarUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconBuscar).EndInit();
            panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtImagen;
        private FontAwesome.Sharp.IconPictureBox pictureBoxClose;
        private PictureBox pictureBoxImagen;
        private FontAwesome.Sharp.IconPictureBox iconBuscar;
        private TextBox txtBuscar;
        private Panel panelDataGridView;
        private DataGridView dataGridProductos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn DESCRIPCION;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn CODIGOBARRA;
        private DataGridViewTextBoxColumn IMAGEN;
        private DataGridViewTextBoxColumn UNIDAD;
    }
}