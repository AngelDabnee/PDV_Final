namespace WinFromMenu
{
    partial class FromUpdateUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromUpdateUsers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnUpdateUsers = new Button();
            btnGuardarUsers = new Button();
            btnFotoUsers = new Button();
            pictureBoxUsers = new PictureBox();
            txtCelular = new TextBox();
            label7 = new Label();
            comboBoxRol = new ComboBox();
            label8 = new Label();
            txtApellido = new TextBox();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtImagen = new TextBox();
            label3 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPass = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            panelDataGridView = new Panel();
            dataGridUsers = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            APELLIDO = new DataGridViewTextBoxColumn();
            CELULAR = new DataGridViewTextBoxColumn();
            PASSWORD = new DataGridViewTextBoxColumn();
            EMAIL = new DataGridViewTextBoxColumn();
            ROL = new DataGridViewTextBoxColumn();
            FOTO = new DataGridViewTextBoxColumn();
            pictureBoxClose = new FontAwesome.Sharp.IconPictureBox();
            openFileDialogModificar = new OpenFileDialog();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsers).BeginInit();
            panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnUpdateUsers);
            panel2.Controls.Add(btnGuardarUsers);
            panel2.Controls.Add(btnFotoUsers);
            panel2.Controls.Add(pictureBoxUsers);
            panel2.Location = new Point(791, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 569);
            panel2.TabIndex = 30;
            // 
            // btnUpdateUsers
            // 
            btnUpdateUsers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateUsers.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateUsers.Location = new Point(3, 436);
            btnUpdateUsers.Name = "btnUpdateUsers";
            btnUpdateUsers.Size = new Size(150, 45);
            btnUpdateUsers.TabIndex = 26;
            btnUpdateUsers.Text = "MODIFICAR";
            btnUpdateUsers.UseVisualStyleBackColor = true;
            btnUpdateUsers.Click += btnAñadirUsers_Click;
            // 
            // btnGuardarUsers
            // 
            btnGuardarUsers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarUsers.Enabled = false;
            btnGuardarUsers.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarUsers.Location = new Point(284, 436);
            btnGuardarUsers.Name = "btnGuardarUsers";
            btnGuardarUsers.Size = new Size(150, 45);
            btnGuardarUsers.TabIndex = 25;
            btnGuardarUsers.Text = "GUARDAR";
            btnGuardarUsers.UseVisualStyleBackColor = true;
            btnGuardarUsers.Click += btnGuardarUsers_Click;
            // 
            // btnFotoUsers
            // 
            btnFotoUsers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFotoUsers.Enabled = false;
            btnFotoUsers.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFotoUsers.Location = new Point(148, 335);
            btnFotoUsers.Name = "btnFotoUsers";
            btnFotoUsers.Size = new Size(150, 45);
            btnFotoUsers.TabIndex = 24;
            btnFotoUsers.Text = "EXAMINAR";
            btnFotoUsers.UseVisualStyleBackColor = true;
            btnFotoUsers.Click += btnFotoUsers_Click;
            // 
            // pictureBoxUsers
            // 
            pictureBoxUsers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxUsers.BackColor = Color.Transparent;
            pictureBoxUsers.BackgroundImage = (Image)resources.GetObject("pictureBoxUsers.BackgroundImage");
            pictureBoxUsers.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxUsers.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxUsers.Enabled = false;
            pictureBoxUsers.Location = new Point(62, 38);
            pictureBoxUsers.Name = "pictureBoxUsers";
            pictureBoxUsers.Size = new Size(333, 291);
            pictureBoxUsers.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUsers.TabIndex = 23;
            pictureBoxUsers.TabStop = false;
            // 
            // txtCelular
            // 
            txtCelular.Enabled = false;
            txtCelular.Location = new Point(450, 562);
            txtCelular.Margin = new Padding(6);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(312, 27);
            txtCelular.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(70, 551);
            label7.Name = "label7";
            label7.Size = new Size(157, 38);
            label7.TabIndex = 45;
            label7.Text = "CELULAR";
            // 
            // comboBoxRol
            // 
            comboBoxRol.Enabled = false;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "ADMIN", "USUARIO" });
            comboBoxRol.Location = new Point(450, 489);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(312, 28);
            comboBoxRol.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(70, 333);
            label8.Name = "label8";
            label8.Size = new Size(357, 38);
            label8.TabIndex = 43;
            label8.Text = "CONFIRMA PASSWORD";
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(450, 205);
            txtApellido.Margin = new Padding(6);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(312, 27);
            txtApellido.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(70, 205);
            label5.Name = "label5";
            label5.Size = new Size(168, 38);
            label5.TabIndex = 41;
            label5.Text = "APELLIDO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 129);
            label1.Name = "label1";
            label1.Size = new Size(148, 38);
            label1.TabIndex = 32;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(70, 277);
            label2.Name = "label2";
            label2.Size = new Size(187, 38);
            label2.TabIndex = 33;
            label2.Text = "PASSWORD";
            // 
            // txtImagen
            // 
            txtImagen.Enabled = false;
            txtImagen.Location = new Point(450, 644);
            txtImagen.Margin = new Padding(6);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(312, 27);
            txtImagen.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(70, 413);
            label3.Name = "label3";
            label3.Size = new Size(112, 38);
            label3.TabIndex = 34;
            label3.Text = "EMAIL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(76, 633);
            label6.Name = "label6";
            label6.Size = new Size(97, 38);
            label6.TabIndex = 35;
            label6.Text = "FOTO";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(450, 140);
            txtNombre.Margin = new Padding(6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(312, 27);
            txtNombre.TabIndex = 36;
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(450, 277);
            txtPassword.Margin = new Padding(6);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(312, 27);
            txtPassword.TabIndex = 37;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Enabled = false;
            txtConfirmPass.Location = new Point(450, 339);
            txtConfirmPass.Margin = new Padding(6);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(312, 27);
            txtConfirmPass.TabIndex = 38;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(450, 413);
            txtEmail.Margin = new Padding(6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(312, 27);
            txtEmail.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(76, 478);
            label4.Name = "label4";
            label4.Size = new Size(78, 38);
            label4.TabIndex = 47;
            label4.Text = "ROL";
            // 
            // panelDataGridView
            // 
            panelDataGridView.Controls.Add(dataGridUsers);
            panelDataGridView.Dock = DockStyle.Bottom;
            panelDataGridView.Location = new Point(0, 734);
            panelDataGridView.Name = "panelDataGridView";
            panelDataGridView.Size = new Size(1303, 214);
            panelDataGridView.TabIndex = 48;
            // 
            // dataGridUsers
            // 
            dataGridUsers.AllowUserToDeleteRows = false;
            dataGridUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridUsers.BackgroundColor = Color.FromArgb(0, 0, 64);
            dataGridUsers.BorderStyle = BorderStyle.Fixed3D;
            dataGridUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsers.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, APELLIDO, CELULAR, PASSWORD, EMAIL, ROL, FOTO });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridUsers.Dock = DockStyle.Fill;
            dataGridUsers.GridColor = SystemColors.ControlText;
            dataGridUsers.Location = new Point(0, 0);
            dataGridUsers.Name = "dataGridUsers";
            dataGridUsers.ReadOnly = true;
            dataGridUsers.RowHeadersWidth = 51;
            dataGridUsers.RowTemplate.Height = 29;
            dataGridUsers.Size = new Size(1303, 214);
            dataGridUsers.TabIndex = 0;
            dataGridUsers.CellContentClick += dataGridUsers_CellContentClick;
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
            // APELLIDO
            // 
            APELLIDO.HeaderText = "APELLIDO";
            APELLIDO.MinimumWidth = 6;
            APELLIDO.Name = "APELLIDO";
            APELLIDO.ReadOnly = true;
            // 
            // CELULAR
            // 
            CELULAR.HeaderText = "CELULAR";
            CELULAR.MinimumWidth = 6;
            CELULAR.Name = "CELULAR";
            CELULAR.ReadOnly = true;
            // 
            // PASSWORD
            // 
            PASSWORD.HeaderText = "PASSWORD";
            PASSWORD.MinimumWidth = 6;
            PASSWORD.Name = "PASSWORD";
            PASSWORD.ReadOnly = true;
            // 
            // EMAIL
            // 
            EMAIL.HeaderText = "EMAIL";
            EMAIL.MinimumWidth = 6;
            EMAIL.Name = "EMAIL";
            EMAIL.ReadOnly = true;
            // 
            // ROL
            // 
            ROL.HeaderText = "ROL";
            ROL.MinimumWidth = 6;
            ROL.Name = "ROL";
            ROL.ReadOnly = true;
            // 
            // FOTO
            // 
            FOTO.HeaderText = "FOTO";
            FOTO.MinimumWidth = 6;
            FOTO.Name = "FOTO";
            FOTO.ReadOnly = true;
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
            pictureBoxClose.TabIndex = 49;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // openFileDialogModificar
            // 
            openFileDialogModificar.FileName = "openFileDialog1";
            // 
            // FromUpdateUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1303, 948);
            Controls.Add(pictureBoxClose);
            Controls.Add(panelDataGridView);
            Controls.Add(label4);
            Controls.Add(txtCelular);
            Controls.Add(label7);
            Controls.Add(comboBoxRol);
            Controls.Add(label8);
            Controls.Add(txtApellido);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtImagen);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(txtNombre);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtEmail);
            Controls.Add(panel2);
            DoubleBuffered = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FromUpdateUsers";
            Text = "FromUpdateUsers";
            Load += FromUpdateUsers_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsers).EndInit();
            panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnUpdateUsers;
        private Button btnGuardarUsers;
        private Button btnFotoUsers;
        private PictureBox pictureBoxUsers;
        private TextBox txtCelular;
        private Label label7;
        private ComboBox comboBoxRol;
        private Label label8;
        private TextBox txtApellido;
        private Label label5;
        private Label label1;
        private Label label2;
        private TextBox txtImagen;
        private Label label3;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtPassword;
        private TextBox txtConfirmPass;
        private TextBox txtEmail;
        private Label label4;
        private Panel panelDataGridView;
        private DataGridView dataGridUsers;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDO;
        private DataGridViewTextBoxColumn CELULAR;
        private DataGridViewTextBoxColumn PASSWORD;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn ROL;
        private DataGridViewTextBoxColumn FOTO;
        private FontAwesome.Sharp.IconPictureBox pictureBoxClose;
        private OpenFileDialog openFileDialogModificar;
    }
}