﻿using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Hotel.UI.Administracion;
using Hotel.UI.Hotel;

namespace Hotel.UI

{
    public partial class MenuPrincipal : Form
    {
        //declaraciones 
        private IconButton currentBtn;
        private Panel leftborderBtn;
        private IconButton[] MyIconButton = new IconButton[5];
        private Form currentChildform;
        bool a ;







        public MenuPrincipal()
        {

            InitializeComponent();
            leftborderBtn = new Panel();
            leftborderBtn.Size = new Size(7, 60);
            PanelMenu.Controls.Add(leftborderBtn);

            //bordes
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            CustomizeDesing();



        }

        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
        }



        //metodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableButton();

                //boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.AliceBlue;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //border

                //leftborderBtn.BackColor = color;
                //leftborderBtn.Location = new Point(0, currentBtn.Location.Y);
                //leftborderBtn.Visible = true;
                //leftborderBtn.BringToFront();

                //icono de inicio
                iconhome.IconChar = currentBtn.IconChar;
                iconhome.IconColor = color;

         


            }

        }
        private void disableButton()
        {
            if (currentBtn != null)

            {


                currentBtn.BackColor = Color.FromArgb(153, 180, 209);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childform)
        {



            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            PnContenedor.Controls.Add(childform);
            PnContenedor.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lbTitulo.Text = childform.Text;

        }

        private void CustomComponentes()
        {
            for (int i = 0; i < MyIconButton.Count(); i++)
            {
                MyIconButton[i] = new IconButton();
            }
            int x = 10;
            foreach (var item in MyIconButton)
            {

                item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                item.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                item.ForeColor = System.Drawing.Color.White;
                item.IconChar = FontAwesome.Sharp.IconChar.Home;
                item.IconColor = System.Drawing.Color.White;
                item.IconFont = FontAwesome.Sharp.IconFont.Auto;
                item.IconSize = 38;
                item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                item.Location = new System.Drawing.Point(3, 6 + (x * 5));
                item.Name = $"iconButto{x}";
                item.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
                item.Size = new System.Drawing.Size(197, 43);
                item.TabIndex = 0;
                item.Text = $"Home";
                item.UseVisualStyleBackColor = true;
                PanelMenu.Controls.Add(item);
                x++;
            }

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            CustomComponentes();
        }
        private void BtHotel_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color1);
            ShowSubMenu(panelDesplegableHotel);

        }
        private void BtAdministracion_Click(object sender, EventArgs e)
        {
            a = true;
            ActivateButton(sender, RGBcolors.color2);
            ShowSubMenu(PanelDesplegableAdministracion);

           
        }
        private void BTtipodehabitaciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color3);
            HideSubMenu();
        }
        private void iconButton4_Click(object sender, EventArgs e)


        {
            CerrarFormulariosHijos();
            disableButton();
            var form = (Program.ServiceProvider.GetService(typeof(ListadoUsuarios)) as ListadoUsuarios);
            form.MdiParent = this;
            form.Show();
            OpenChildForm(form);
            HideSubMenu();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
          
        
           
        }
        private void reset()

        {
          

            disableButton();
            leftborderBtn.Visible = false;
            iconhome.IconChar = iconreseticonhome.IconChar;
            iconhome.IconColor = Color.AliceBlue;
            lbTitulo.Text = "HOME";

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PNSuperior_Paint(object sender, MouseEventArgs e)

        {
        }
        private void PNSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void iconMaximizarformulario_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void CustomizeDesing()
        {
            panelDesplegableHotel.Visible = false;
            PanelDesplegableAdministracion.Visible = false;

        }
        private void HideSubMenu()
        {
            if (panelDesplegableHotel.Visible == true)
                panelDesplegableHotel.Visible = false;
            if (PanelDesplegableAdministracion.Visible == true)
                PanelDesplegableAdministracion.Visible = false;
        }
        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void BTregistrodeHabitaciones_Click_1(object sender, EventArgs e)
        {
            disableButton();

            var form = (Program.ServiceProvider.GetService(typeof(CrearHabitaciones)) as CrearHabitaciones);
            form.MdiParent = this;
            form.Show();
            OpenChildForm(form);
            HideSubMenu();

        }

        private void BTcrearHoteles_Click(object sender, EventArgs e)
            
        {
            CerrarFormulariosHijos();
            disableButton();
            var form = (Program.ServiceProvider.GetService(typeof(ListadoHoteles)) as ListadoHoteles);
            form.MdiParent = this;
            form.Show();
            OpenChildForm(form);
            HideSubMenu();

        }


        private void BTtipodehabitaciones_Click_1(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            disableButton();
            var form = (Program.ServiceProvider.GetService(typeof(CrearTipoHabitacion)) as CrearTipoHabitacion);
            form.MdiParent = this;
            form.Show();
            OpenChildForm(form);
            HideSubMenu();
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            disableButton();
            HideSubMenu();
        }

        private void CerrarFormulariosHijos ()
        {
          
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

        }

        private void iconhome_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            HideSubMenu();
            reset();
        }
    }
}
