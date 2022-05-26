
using Hotel.Data.Interfaces;
using Hotel.Data.Models;
using Krypton.Toolkit;

namespace Hotel.UI
{
    public partial class Login : KryptonForm
    {
        private readonly IAdministracionRepositorio _administracionRepositorio;
        private static string logeedUser = string.Empty;
        public string LoggedUser { get; } = logeedUser;
        public Login(IAdministracionRepositorio administracionRepositorio)
        {
            InitializeComponent();
            this._administracionRepositorio = administracionRepositorio;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            var user = new Usuarios
            {
                Clave = txtContraseña.Text,
                Usuario = txtCodigoUsuario.Text,
            };

            if (!_administracionRepositorio.AutentificarUsuario(user))
            {
                MessageBox.Show("Usuario/Contraseña incorrecto.", "!!!ATENCION!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            logeedUser = txtCodigoUsuario.Text;
            DialogResult = DialogResult.OK;

        }
    }
}
