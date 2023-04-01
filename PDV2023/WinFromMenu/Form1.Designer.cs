namespace WinFromMenu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnCaja = new Button();
            btnSubMenuUser = new Button();
            panelSubUser = new Panel();
            btnBuscarUsers = new Button();
            btnUpdateUsers = new Button();
            btnDeleteUsers = new Button();
            btnAddUsers = new Button();
            panelDebajo = new Panel();
            buttonBuscar = new Button();
            buttonModificar = new Button();
            buttonDelet = new Button();
            buttonAdd = new Button();
            buttonSubMenu = new Button();
            panelFoto = new Panel();
            panelForm = new Panel();
            panel1.SuspendLayout();
            panelSubUser.SuspendLayout();
            panelDebajo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnCaja);
            panel1.Controls.Add(btnSubMenuUser);
            panel1.Controls.Add(panelSubUser);
            panel1.Controls.Add(panelDebajo);
            panel1.Controls.Add(buttonSubMenu);
            panel1.Controls.Add(panelFoto);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 851);
            panel1.TabIndex = 0;
            // 
            // btnCaja
            // 
            btnCaja.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCaja.Location = new Point(3, 758);
            btnCaja.Name = "btnCaja";
            btnCaja.Size = new Size(244, 81);
            btnCaja.TabIndex = 2;
            btnCaja.Text = "CAJA";
            btnCaja.UseVisualStyleBackColor = true;
            btnCaja.Click += btnCaja_Click;
            // 
            // btnSubMenuUser
            // 
            btnSubMenuUser.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubMenuUser.Location = new Point(3, 128);
            btnSubMenuUser.Name = "btnSubMenuUser";
            btnSubMenuUser.Size = new Size(244, 81);
            btnSubMenuUser.TabIndex = 3;
            btnSubMenuUser.Text = "SUBMENU USUARIOS";
            btnSubMenuUser.UseVisualStyleBackColor = true;
            btnSubMenuUser.Click += btnSubMenuUser_Click;
            // 
            // panelSubUser
            // 
            panelSubUser.Controls.Add(btnBuscarUsers);
            panelSubUser.Controls.Add(btnUpdateUsers);
            panelSubUser.Controls.Add(btnDeleteUsers);
            panelSubUser.Controls.Add(btnAddUsers);
            panelSubUser.Location = new Point(3, 210);
            panelSubUser.Name = "panelSubUser";
            panelSubUser.Size = new Size(244, 229);
            panelSubUser.TabIndex = 2;
            panelSubUser.Visible = false;
            // 
            // btnBuscarUsers
            // 
            btnBuscarUsers.Dock = DockStyle.Top;
            btnBuscarUsers.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarUsers.Location = new Point(0, 165);
            btnBuscarUsers.Name = "btnBuscarUsers";
            btnBuscarUsers.Size = new Size(244, 55);
            btnBuscarUsers.TabIndex = 5;
            btnBuscarUsers.Text = "BUSCAR";
            btnBuscarUsers.UseVisualStyleBackColor = true;
            btnBuscarUsers.Click += btnBuscarUsers_Click;
            // 
            // btnUpdateUsers
            // 
            btnUpdateUsers.Dock = DockStyle.Top;
            btnUpdateUsers.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateUsers.Location = new Point(0, 110);
            btnUpdateUsers.Name = "btnUpdateUsers";
            btnUpdateUsers.Size = new Size(244, 55);
            btnUpdateUsers.TabIndex = 4;
            btnUpdateUsers.Text = "MODIFICAR";
            btnUpdateUsers.UseVisualStyleBackColor = true;
            btnUpdateUsers.Click += btnUpdateUsers_Click;
            // 
            // btnDeleteUsers
            // 
            btnDeleteUsers.Dock = DockStyle.Top;
            btnDeleteUsers.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteUsers.Location = new Point(0, 55);
            btnDeleteUsers.Name = "btnDeleteUsers";
            btnDeleteUsers.Size = new Size(244, 55);
            btnDeleteUsers.TabIndex = 3;
            btnDeleteUsers.Text = "ELIMINAR";
            btnDeleteUsers.UseVisualStyleBackColor = true;
            btnDeleteUsers.Click += btnDeleteUsers_Click;
            // 
            // btnAddUsers
            // 
            btnAddUsers.Dock = DockStyle.Top;
            btnAddUsers.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddUsers.Location = new Point(0, 0);
            btnAddUsers.Name = "btnAddUsers";
            btnAddUsers.Size = new Size(244, 55);
            btnAddUsers.TabIndex = 2;
            btnAddUsers.Text = "AÑADIR";
            btnAddUsers.UseVisualStyleBackColor = true;
            btnAddUsers.Click += btnAddUsers_Click;
            // 
            // panelDebajo
            // 
            panelDebajo.Controls.Add(buttonBuscar);
            panelDebajo.Controls.Add(buttonModificar);
            panelDebajo.Controls.Add(buttonDelet);
            panelDebajo.Controls.Add(buttonAdd);
            panelDebajo.Location = new Point(3, 524);
            panelDebajo.Name = "panelDebajo";
            panelDebajo.Size = new Size(244, 229);
            panelDebajo.TabIndex = 1;
            panelDebajo.Visible = false;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Dock = DockStyle.Top;
            buttonBuscar.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBuscar.Location = new Point(0, 165);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(244, 55);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "BUSCAR";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Dock = DockStyle.Top;
            buttonModificar.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModificar.Location = new Point(0, 110);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(244, 55);
            buttonModificar.TabIndex = 4;
            buttonModificar.Text = "MODIFICAR";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonDelet
            // 
            buttonDelet.Dock = DockStyle.Top;
            buttonDelet.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelet.Location = new Point(0, 55);
            buttonDelet.Name = "buttonDelet";
            buttonDelet.Size = new Size(244, 55);
            buttonDelet.TabIndex = 3;
            buttonDelet.Text = "ELIMINAR";
            buttonDelet.UseVisualStyleBackColor = true;
            buttonDelet.Click += buttonDelet_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Top;
            buttonAdd.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(0, 0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(244, 55);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "AÑADIR";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSubMenu
            // 
            buttonSubMenu.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSubMenu.Location = new Point(3, 441);
            buttonSubMenu.Name = "buttonSubMenu";
            buttonSubMenu.Size = new Size(244, 81);
            buttonSubMenu.TabIndex = 1;
            buttonSubMenu.Text = "SUBMENU PRODUCTOS";
            buttonSubMenu.UseVisualStyleBackColor = true;
            buttonSubMenu.Click += buttonSubMenu_Click;
            // 
            // panelFoto
            // 
            panelFoto.BackColor = SystemColors.ControlDark;
            panelFoto.BackgroundImage = (Image)resources.GetObject("panelFoto.BackgroundImage");
            panelFoto.BackgroundImageLayout = ImageLayout.Stretch;
            panelFoto.Dock = DockStyle.Top;
            panelFoto.Location = new Point(0, 0);
            panelFoto.Name = "panelFoto";
            panelFoto.Size = new Size(250, 125);
            panelFoto.TabIndex = 1;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.Transparent;
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(250, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(908, 851);
            panelForm.TabIndex = 1;
            panelForm.Paint += panelForm_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1158, 851);
            Controls.Add(panelForm);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panelSubUser.ResumeLayout(false);
            panelDebajo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelFoto;
        private Panel panelDebajo;
        private Button buttonSubMenu;
        private Panel panelForm;
        private Button buttonAdd;
        private Button buttonDelet;
        private Button buttonModificar;
        private Button buttonBuscar;
        private Button btnSubMenuUser;
        private Panel panelSubUser;
        private Button btnBuscarUsers;
        private Button btnUpdateUsers;
        private Button btnDeleteUsers;
        private Button btnAddUsers;
        private Button btnCaja;
    }
}