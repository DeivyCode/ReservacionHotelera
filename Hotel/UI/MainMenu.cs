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
        private readonly ListadoTipoHabitaciones _listadoTipoHabitaciones;
        public MainMenu(ListadoUsuarios listadoUsuarios, ListadoHoteles listadoHoteles, ListadoReservaciones listadoReservaciones, ListadoTipoHabitaciones listadoTipoHabitaciones)
        {
            _listadoUsuarios = listadoUsuarios;
            _listadoHoteles = listadoHoteles;
            _listadoReservaciones = listadoReservaciones;
            _listadoTipoHabitaciones = listadoTipoHabitaciones;
            InitializeComponent();
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

        private void InitialzieMdiForm(Form mdiChildren)
        {
            mdiChildren.MdiParent = this;
            mdiChildren.Size = PnContenedor.Size;
            mdiChildren.Show();
            OpenChildForm(mdiChildren);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            InitialzieMdiForm(_listadoHoteles);
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            InitialzieMdiForm(_listadoUsuarios);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            InitialzieMdiForm(_listadoReservaciones);
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            InitialzieMdiForm(_listadoTipoHabitaciones);
        }
    }
}
