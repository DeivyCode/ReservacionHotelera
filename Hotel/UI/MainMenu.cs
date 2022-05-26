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
        private readonly ListadoHabitaciones _listadoHabitaciones;
        private readonly Login _login;
        public MainMenu(ListadoUsuarios listadoUsuarios, ListadoHoteles listadoHoteles, ListadoReservaciones listadoReservaciones, ListadoTipoHabitaciones listadoTipoHabitaciones, Login login, ListadoHabitaciones listadoHabitaciones)
        {
            _listadoUsuarios = listadoUsuarios;
            _listadoHoteles = listadoHoteles;
            _listadoReservaciones = listadoReservaciones;
            _listadoTipoHabitaciones = listadoTipoHabitaciones;
            _login = login;
            _listadoHabitaciones = listadoHabitaciones;
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

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LbLoggedUser.Text = $"Logeado\n {_login.LoggedUser}";
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            InitialzieMdiForm(_listadoHabitaciones);
        }
    }
}
