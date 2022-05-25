using Hotel.Data.Interfaces;
using Hotel.Comunes;
using Krypton.Toolkit;

namespace Hotel.UI.Administracion
{
    public partial class ListadoUsuarios : KryptonForm
    {
        private readonly IAdministracionRepositorio _administracion;
        private readonly CrearUsuarios _crearUsuario;
        public ListadoUsuarios(IAdministracionRepositorio administracion, CrearUsuarios crearUsuario)
        {
            InitializeComponent();
            this._administracion = administracion;
            this._crearUsuario = crearUsuario;
        }

        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = _administracion.GetUsuarios();

        }
        private void dgvUsuarios_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var height = 35 + dgvUsuarios.Rows.Cast<DataGridViewRow>().Sum(dr => dr.Height);
            dgvUsuarios.Height = height;
        }

        private void btCreate_Click_Click(object sender, EventArgs e)
        {
            _crearUsuario.Acciones = Acciones.Crear;
            _crearUsuario.ShowDialog();
            if (_crearUsuario.DialogResult != DialogResult.OK) return;
            dgvUsuarios.DataSource = _administracion.GetUsuarios();
            dgvUsuarios.Update();
            dgvUsuarios.Refresh();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0) return;
            var rows = dgvUsuarios.SelectedRows[0];

            _crearUsuario.Acciones = Acciones.Editar;
            _crearUsuario.idUsuario = (int)rows.Cells["IdUsuario"].Value;
            _crearUsuario.ShowDialog();
            if (_crearUsuario.DialogResult != DialogResult.OK) return;
            dgvUsuarios.DataSource = _administracion.GetUsuarios();
            dgvUsuarios.Update();
            dgvUsuarios.Refresh();
        }
    }
}
