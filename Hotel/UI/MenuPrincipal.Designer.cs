namespace Hotel.UI
{
    partial class MenuPrincipal
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtUsuarios = new FontAwesome.Sharp.IconButton();
            this.BtREPORTE = new FontAwesome.Sharp.IconButton();
            this.BtAdministracion = new FontAwesome.Sharp.IconButton();
            this.BtHotel = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.PtInicio = new System.Windows.Forms.PictureBox();
            this.PNSuperior = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.iconhome = new FontAwesome.Sharp.IconPictureBox();
            this.PanelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtInicio)).BeginInit();
            this.PNSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconhome)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(121)))), ((int)(((byte)(186)))));
            this.PanelMenu.Controls.Add(this.BtUsuarios);
            this.PanelMenu.Controls.Add(this.BtREPORTE);
            this.PanelMenu.Controls.Add(this.BtAdministracion);
            this.PanelMenu.Controls.Add(this.BtHotel);
            this.PanelMenu.Controls.Add(this.panelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.ForeColor = System.Drawing.Color.Black;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 566);
            this.PanelMenu.TabIndex = 1;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // BtUsuarios
            // 
            this.BtUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtUsuarios.FlatAppearance.BorderSize = 0;
            this.BtUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtUsuarios.ForeColor = System.Drawing.Color.White;
            this.BtUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.BtUsuarios.IconColor = System.Drawing.Color.White;
            this.BtUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtUsuarios.Location = new System.Drawing.Point(0, 320);
            this.BtUsuarios.Name = "BtUsuarios";
            this.BtUsuarios.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.BtUsuarios.Size = new System.Drawing.Size(220, 65);
            this.BtUsuarios.TabIndex = 5;
            this.BtUsuarios.Text = "USUARIOS";
            this.BtUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtUsuarios.UseVisualStyleBackColor = true;
            this.BtUsuarios.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // BtREPORTE
            // 
            this.BtREPORTE.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtREPORTE.FlatAppearance.BorderSize = 0;
            this.BtREPORTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtREPORTE.ForeColor = System.Drawing.Color.White;
            this.BtREPORTE.IconChar = FontAwesome.Sharp.IconChar.File;
            this.BtREPORTE.IconColor = System.Drawing.Color.White;
            this.BtREPORTE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtREPORTE.IconSize = 45;
            this.BtREPORTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtREPORTE.Location = new System.Drawing.Point(0, 260);
            this.BtREPORTE.Name = "BtREPORTE";
            this.BtREPORTE.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.BtREPORTE.Size = new System.Drawing.Size(220, 60);
            this.BtREPORTE.TabIndex = 4;
            this.BtREPORTE.Text = "REPORTE";
            this.BtREPORTE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtREPORTE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtREPORTE.UseVisualStyleBackColor = true;
            this.BtREPORTE.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // BtAdministracion
            // 
            this.BtAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtAdministracion.FlatAppearance.BorderSize = 0;
            this.BtAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAdministracion.ForeColor = System.Drawing.Color.White;
            this.BtAdministracion.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.BtAdministracion.IconColor = System.Drawing.Color.White;
            this.BtAdministracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtAdministracion.IconSize = 45;
            this.BtAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAdministracion.Location = new System.Drawing.Point(0, 200);
            this.BtAdministracion.Name = "BtAdministracion";
            this.BtAdministracion.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.BtAdministracion.Size = new System.Drawing.Size(220, 60);
            this.BtAdministracion.TabIndex = 3;
            this.BtAdministracion.Text = "Administracion";
            this.BtAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtAdministracion.UseVisualStyleBackColor = true;
            this.BtAdministracion.Click += new System.EventHandler(this.BtAdministracion_Click);
            // 
            // BtHotel
            // 
            this.BtHotel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtHotel.FlatAppearance.BorderSize = 0;
            this.BtHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtHotel.ForeColor = System.Drawing.Color.White;
            this.BtHotel.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.BtHotel.IconColor = System.Drawing.Color.White;
            this.BtHotel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtHotel.IconSize = 45;
            this.BtHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtHotel.Location = new System.Drawing.Point(0, 140);
            this.BtHotel.Name = "BtHotel";
            this.BtHotel.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.BtHotel.Size = new System.Drawing.Size(220, 60);
            this.BtHotel.TabIndex = 2;
            this.BtHotel.Text = "HOTEL";
            this.BtHotel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtHotel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtHotel.UseVisualStyleBackColor = true;
            this.BtHotel.Click += new System.EventHandler(this.BtHotel_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.PtInicio);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 2;
            // 
            // PtInicio
            // 
            this.PtInicio.Image = global::Hotel.Properties.Resources.Wyndham_Hotels;
            this.PtInicio.Location = new System.Drawing.Point(0, 31);
            this.PtInicio.Name = "PtInicio";
            this.PtInicio.Size = new System.Drawing.Size(220, 68);
            this.PtInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtInicio.TabIndex = 2;
            this.PtInicio.TabStop = false;
            this.PtInicio.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // PNSuperior
            // 
            this.PNSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(121)))), ((int)(((byte)(186)))));
            this.PNSuperior.Controls.Add(this.lbTitulo);
            this.PNSuperior.Controls.Add(this.iconhome);
            this.PNSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNSuperior.Location = new System.Drawing.Point(220, 0);
            this.PNSuperior.Name = "PNSuperior";
            this.PNSuperior.Size = new System.Drawing.Size(918, 75);
            this.PNSuperior.TabIndex = 2;
            
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbTitulo.Location = new System.Drawing.Point(65, 39);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(42, 15);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "HOME";
            // 
            // iconhome
            // 
            this.iconhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(121)))), ((int)(((byte)(186)))));
            this.iconhome.ForeColor = System.Drawing.Color.AliceBlue;
            this.iconhome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconhome.IconColor = System.Drawing.Color.AliceBlue;
            this.iconhome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconhome.Location = new System.Drawing.Point(27, 33);
            this.iconhome.Name = "iconhome";
            this.iconhome.Size = new System.Drawing.Size(32, 32);
            this.iconhome.TabIndex = 0;
            this.iconhome.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1138, 566);
            this.Controls.Add(this.PNSuperior);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.PanelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtInicio)).EndInit();
            this.PNSuperior.ResumeLayout(false);
            this.PNSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconhome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel PanelMenu;
        private FontAwesome.Sharp.IconButton BtUsuarios;
        private FontAwesome.Sharp.IconButton BtREPORTE;
        private FontAwesome.Sharp.IconButton BtAdministracion;
        private FontAwesome.Sharp.IconButton BtHotel;
        private Panel panelLogo;
        private PictureBox PtInicio;
        private Panel PNSuperior;
        private FontAwesome.Sharp.IconPictureBox iconhome;
        private Label label1;
        private Label lbTitulo;
    }
}