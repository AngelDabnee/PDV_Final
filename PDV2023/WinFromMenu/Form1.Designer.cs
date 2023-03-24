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
            panelDebajo = new Panel();
            buttonDelet = new Button();
            buttonAdd = new Button();
            buttonSubMenu = new Button();
            panelFoto = new Panel();
            panelForm = new Panel();
            buttonModificar = new Button();
            panel1.SuspendLayout();
            panelDebajo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panelDebajo);
            panel1.Controls.Add(buttonSubMenu);
            panel1.Controls.Add(panelFoto);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 666);
            panel1.TabIndex = 0;
            // 
            // panelDebajo
            // 
            panelDebajo.Controls.Add(buttonModificar);
            panelDebajo.Controls.Add(buttonDelet);
            panelDebajo.Controls.Add(buttonAdd);
            panelDebajo.Location = new Point(3, 192);
            panelDebajo.Name = "panelDebajo";
            panelDebajo.Size = new Size(244, 321);
            panelDebajo.TabIndex = 1;
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
            buttonSubMenu.Location = new Point(3, 131);
            buttonSubMenu.Name = "buttonSubMenu";
            buttonSubMenu.Size = new Size(244, 55);
            buttonSubMenu.TabIndex = 1;
            buttonSubMenu.Text = "SUBMENU";
            buttonSubMenu.UseVisualStyleBackColor = true;
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
            panelForm.Size = new Size(908, 666);
            panelForm.TabIndex = 1;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1158, 666);
            Controls.Add(panelForm);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
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
    }
}