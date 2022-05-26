using Hotel.Comunes;
using Hotel.Data.Interfaces;
using Krypton.Toolkit;

namespace Hotel.UI.Hotel
{
    public partial class ListadoHabitaciones : KryptonForm
    {
        private readonly CrearHabitaciones _crearHabitaciones;
        private readonly IHotelRepository _hotelRepository;
        public ListadoHabitaciones(CrearHabitaciones crearHabitaciones, IHotelRepository hotelRepository)
        {
            _crearHabitaciones = crearHabitaciones;
            _hotelRepository = hotelRepository;
            InitializeComponent();
        }


        private void CargarData()
        {
            var data = _hotelRepository.ObtenerHabitaciones();
            dgvHabitaciones.DataSource = data.Select(x => new
            {
                x.Nombre,
                x.IdHabitacion,
                x.Capacidad,
            }).ToList();
            kryptonHeader1.Values.Description = $@"{data.Count}";
        }
        private void Listado_de_Habitaciones_Load(object sender, EventArgs e)
        {
            CargarData();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            dgvHabitaciones.DataSource = _hotelRepository.ObtenerHabitaciones()
                .Where(x => x.Nombre.Contains(txtBusqueda.Text.Trim().ToUpper())).ToList();
            dgvHabitaciones.Update();
            dgvHabitaciones.Refresh();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {

            _crearHabitaciones.Acciones = Acciones.Crear;
            _crearHabitaciones.ShowDialog();
            if (_crearHabitaciones.DialogResult != DialogResult.OK) return;
            CargarData();
            dgvHabitaciones.Update();
            dgvHabitaciones.Refresh();
        }

        private void dgvHabitaciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var height = 35 + dgvHabitaciones.Rows.Cast<DataGridViewRow>().Sum(dr => dr.Height);
            dgvHabitaciones.Height = height;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {

            if (dgvHabitaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show(@"Debe seleccionar un registro");
                return;
            }

            _crearHabitaciones.Acciones = Acciones.Editar;
            _crearHabitaciones.IdHabitacion = (int)dgvHabitaciones.SelectedRows[0].Cells["IdHabitacion"].Value;
            _crearHabitaciones.ShowDialog();
            if (_crearHabitaciones.DialogResult != DialogResult.OK) return;
            CargarData();
            dgvHabitaciones.Update();
            dgvHabitaciones.Refresh();
        }
    }
}
