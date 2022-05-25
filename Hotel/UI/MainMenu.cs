using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.UI.Administracion;
using Hotel.UI.Hotel;
using Krypton.Toolkit;

namespace Hotel.UI
{
    public partial class MainMenu : KryptonForm
    {
        private readonly ListadoUsuarios _listadoUsuarios;
        private readonly ListadoHoteles _listadoHoteles;
        public MainMenu(ListadoUsuarios listadoUsuarios, ListadoHoteles listadoHoteles)
        {
            _listadoUsuarios = listadoUsuarios;
            _listadoHoteles = listadoHoteles;
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            _listadoHoteles.MdiParent = this;
            _listadoHoteles.Size = PnContenedor.Size;
            _listadoHoteles.Show();
            OpenChildForm(_listadoHoteles);
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            _listadoUsuarios.MdiParent = this;
            _listadoUsuarios.Size = PnContenedor.Size;
            _listadoUsuarios.Show();
            OpenChildForm(_listadoUsuarios);
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
            LbTituloChildForm.Text = childform.Text;

        }
    }
}
