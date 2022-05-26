using Hotel.Comunes;
using Hotel.Data.Interfaces;
using Hotel.Data.Models;
using Krypton.Toolkit;

namespace Hotel.UI.Administracion
{
    public partial class CrearUsuarios : KryptonForm
    {
        private readonly IAdministracionRepositorio _administracion;
        public Acciones Acciones { get; set; } = Acciones.Crear;
        public int idUsuario;
        public CrearUsuarios(IAdministracionRepositorio administracion)
        {
            InitializeComponent();
            this._administracion = administracion;
        }


        private bool GuardarEditarUsuarios(Acciones accion)
        {
            try
            {
                if (!Comunes.Comunes.ValidarLimpiarCampos(this)) return false;


                if (!string.Equals(txtClave.Text.Trim(), txtConfirmarClave.Text.Trim(), StringComparison.CurrentCultureIgnoreCase))
                {
                    txtClave.Focus();
                    MessageBox.Show("Las contraseñas no cooindicen, porfavor verifica tu contraseña");
                    return false;
                }
                var usuario = new Usuarios
                {
                    Usuario = txtCodigo.Text,
                    Nombres = txtNombre.Text,
                    Apellidos = txtApellido.Text,
                    Clave = txtClave.Text,
                    Correo = txtCorreo.Text,
                    IsActive = ckIsActive.Checked,
                    IsAdmin = ckIsActive.Checked,
                    IdUsuario = accion == Acciones.Editar ? idUsuario : 0

                };
                if (accion == Acciones.Crear)
                {
                    if (!_administracion.CrearUsuario(usuario)) return false;
                }
                else
                {
                    if (!_administracion.EditarUsuario(usuario)) return false;
                }

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($@"{e?.Message} {e?.InnerException}");
                return false;
            }
        }




        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (Acciones == Acciones.Editar)
            {
                if (!GuardarEditarUsuarios(accion: Acciones.Editar))
                {
                    MessageBox.Show("Error Guardando Usuario");
                    return;
                }
                MessageBox.Show("!!!Usuario editado Satisfactoriamente!!!");
                DialogResult = DialogResult.OK;
                return;
            }

            if (GuardarEditarUsuarios(accion: Acciones.Crear))
            {
                MessageBox.Show("!!!Usuario creado Satisfactoriamente!!!");
                DialogResult = DialogResult.OK;
            }
        }

        private void CrearUsuarios_Load(object sender, EventArgs e)
        {

            if (this.Acciones == Acciones.Editar)
            {
                var users = _administracion.ObtenerUsuariosByCriteria(x => x.IdUsuario == idUsuario);
                foreach (var user in users)
                {
                    txtCodigo.Text = user.Usuario;
                    txtApellido.Text = user.Apellidos;
                    txtNombre.Text = user.Nombres;
                    txtCorreo.Text = user.Correo;
                    txtClave.Text = user.Clave;
                    txtConfirmarClave.Text = user.Clave;
                    ckIsAdmin.Checked = user.IsAdmin;
                    ckIsActive.Checked = user.IsActive;
                }

            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
