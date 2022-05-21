using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;


namespace Hotel.UI

{
    public partial class MenuPrincipal : Form
    {
        //declaraciones 

        private IconButton currentBtn;

        private Panel leftborderBtn;




        private IconButton[] MyIconButton = new IconButton[5];

        

        public MenuPrincipal()
        {

            InitializeComponent();
            leftborderBtn = new Panel();
            leftborderBtn.Size = new Size(7, 60);
            PanelMenu.Controls.Add(leftborderBtn);
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            

        }

        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95,   77, 221);
          

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

                leftborderBtn.BackColor = color;    
                leftborderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftborderBtn.Visible = true;
                leftborderBtn.BringToFront();

                //icono de inicio
                iconhome.IconChar = currentBtn.IconChar;
                iconhome.IconColor = color;

            }

        }
        private void disableButton()
        {
          if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(2, 121, 186);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
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
                item.Location = new System.Drawing.Point(3, 6+(x*5));
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
            ActivateButton(sender, RGBcolors.color1 );
        }
        private void BtAdministracion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color2);
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color3);
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color4);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        { 
        }
        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            disableButton();
            leftborderBtn.Visible = false;
            iconhome.IconChar = currentBtn.IconChar;
            iconhome.IconColor = Color.AliceBlue;   
        }

       


        private void PNSuperior_Paint(object sender, MouseEventArgs e)

        {
           



        }
    }
}
