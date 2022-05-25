using Hotel.UI.Administracion;
using Hotel.UI.Hotel;
using Krypton.Toolkit;

namespace Hotel.UI
{
    public partial class MainMenu : KryptonForm
    {
        private readonly ListadoUsuarios _listadoUsuarios;
        private readonly ListadoHoteles _listadoHoteles;
        private readonly ListadoReservaciones _listadoReservaciones;
        public MainMenu(ListadoUsuarios listadoUsuarios, ListadoHoteles listadoHoteles, ListadoReservaciones listadoReservaciones)
        {
            _listadoUsuarios = listadoUsuarios;
            _listadoHoteles = listadoHoteles;
            _listadoReservaciones = listadoReservaciones;
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

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            _listadoReservaciones.MdiParent = this;
            _listadoReservaciones.Size = PnContenedor.Size;
            _listadoReservaciones.Show();
            OpenChildForm(_listadoReservaciones);
        }
    }
}
