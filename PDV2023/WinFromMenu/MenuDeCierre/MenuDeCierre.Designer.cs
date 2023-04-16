namespace WinFromMenu
{
    partial class MenuDeCierre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDeCierre));
            btnLogin = new Button();
            btnCerrar = new Button();
            panelBoton = new Panel();
            panelCerrarApp = new Panel();
            btnCerrarApp = new FontAwesome.Sharp.IconPictureBox();
            panelBoton.SuspendLayout();
            panelCerrarApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarApp).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(841, 345);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(292, 56);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "INICIAR";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.Location = new Point(841, 688);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(292, 56);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelBoton
            // 
            panelBoton.BackColor = Color.Transparent;
            panelBoton.Controls.Add(panelCerrarApp);
            panelBoton.Controls.Add(btnLogin);
            panelBoton.Controls.Add(btnCerrar);
            panelBoton.Dock = DockStyle.Fill;
            panelBoton.Location = new Point(0, 0);
            panelBoton.Name = "panelBoton";
            panelBoton.Size = new Size(1158, 851);
            panelBoton.TabIndex = 2;
            // 
            // panelCerrarApp
            // 
            panelCerrarApp.Controls.Add(btnCerrarApp);
            panelCerrarApp.Dock = DockStyle.Top;
            panelCerrarApp.Location = new Point(0, 0);
            panelCerrarApp.Name = "panelCerrarApp";
            panelCerrarApp.Size = new Size(1158, 55);
            panelCerrarApp.TabIndex = 2;
            // 
            // btnCerrarApp
            // 
            btnCerrarApp.BackColor = Color.Transparent;
            btnCerrarApp.Dock = DockStyle.Right;
            btnCerrarApp.ForeColor = SystemColors.Control;
            btnCerrarApp.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarApp.IconColor = SystemColors.Control;
            btnCerrarApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarApp.IconSize = 40;
            btnCerrarApp.Location = new Point(1118, 0);
            btnCerrarApp.Name = "btnCerrarApp";
            btnCerrarApp.Size = new Size(40, 55);
            btnCerrarApp.TabIndex = 0;
            btnCerrarApp.TabStop = false;
            btnCerrarApp.Click += btnCerrarApp_Click;
            // 
            // MenuDeCierre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1158, 851);
            Controls.Add(panelBoton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuDeCierre";
            Text = "MenuDeCierre";
            WindowState = FormWindowState.Maximized;
            panelBoton.ResumeLayout(false);
            panelCerrarApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrarApp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnCerrar;
        private Panel panelBoton;
        private Panel panelCerrarApp;
        private FontAwesome.Sharp.IconPictureBox btnCerrarApp;
    }
}