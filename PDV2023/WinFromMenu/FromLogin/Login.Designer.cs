namespace WinFromMenu
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panelFondoLogin = new Panel();
            pictureBoxLogin = new PictureBox();
            labelUsuario = new Label();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnIniciar = new Button();
            pictureVisible = new FontAwesome.Sharp.IconPictureBox();
            pictureNoVisible = new FontAwesome.Sharp.IconPictureBox();
            panelFondoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureVisible).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureNoVisible).BeginInit();
            SuspendLayout();
            // 
            // panelFondoLogin
            // 
            panelFondoLogin.Controls.Add(pictureBoxLogin);
            panelFondoLogin.Location = new Point(293, 12);
            panelFondoLogin.Name = "panelFondoLogin";
            panelFondoLogin.Size = new Size(229, 175);
            panelFondoLogin.TabIndex = 0;
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.BackColor = Color.Transparent;
            pictureBoxLogin.BackgroundImage = (Image)resources.GetObject("pictureBoxLogin.BackgroundImage");
            pictureBoxLogin.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLogin.Dock = DockStyle.Fill;
            pictureBoxLogin.Location = new Point(0, 0);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(229, 175);
            pictureBoxLogin.TabIndex = 0;
            pictureBoxLogin.TabStop = false;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.BackColor = Color.Transparent;
            labelUsuario.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.ForeColor = SystemColors.Window;
            labelUsuario.Location = new Point(324, 211);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(160, 40);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(288, 331);
            label1.Name = "label1";
            label1.Size = new Size(234, 40);
            label1.TabIndex = 2;
            label1.Text = "CONTRASEÑA";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(288, 254);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 36);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(288, 392);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 36);
            txtPassword.TabIndex = 4;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Transparent;
            btnIniciar.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.Location = new Point(334, 465);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(150, 45);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "ENTRAR";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // pictureVisible
            // 
            pictureVisible.BackColor = Color.Transparent;
            pictureVisible.ForeColor = SystemColors.Window;
            pictureVisible.IconChar = FontAwesome.Sharp.IconChar.Eye;
            pictureVisible.IconColor = SystemColors.Window;
            pictureVisible.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pictureVisible.IconSize = 40;
            pictureVisible.Location = new Point(602, 392);
            pictureVisible.Name = "pictureVisible";
            pictureVisible.Size = new Size(40, 40);
            pictureVisible.TabIndex = 6;
            pictureVisible.TabStop = false;
            pictureVisible.Click += pictureVisible_Click;
            // 
            // pictureNoVisible
            // 
            pictureNoVisible.BackColor = Color.Transparent;
            pictureNoVisible.ForeColor = SystemColors.Window;
            pictureNoVisible.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            pictureNoVisible.IconColor = SystemColors.Window;
            pictureNoVisible.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pictureNoVisible.IconSize = 40;
            pictureNoVisible.Location = new Point(648, 392);
            pictureNoVisible.Name = "pictureNoVisible";
            pictureNoVisible.Size = new Size(40, 40);
            pictureNoVisible.TabIndex = 7;
            pictureNoVisible.TabStop = false;
            pictureNoVisible.Click += pictureNoVisible_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(798, 522);
            Controls.Add(pictureNoVisible);
            Controls.Add(pictureVisible);
            Controls.Add(btnIniciar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(labelUsuario);
            Controls.Add(panelFondoLogin);
            DoubleBuffered = true;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelFondoLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureVisible).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureNoVisible).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFondoLogin;
        private PictureBox pictureBoxLogin;
        private Label labelUsuario;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnIniciar;
        private FontAwesome.Sharp.IconPictureBox pictureVisible;
        private FontAwesome.Sharp.IconPictureBox pictureNoVisible;
    }
}