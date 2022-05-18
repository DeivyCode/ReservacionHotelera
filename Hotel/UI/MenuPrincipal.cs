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

namespace Hotel.UI
{
    public partial class MenuPrincipal : Form
    {
        private IconButton[] MyIconButton = new IconButton[5];

        public MenuPrincipal()
        {

            InitializeComponent();

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
                PanelLateral.Controls.Add(item);
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
    }
}
