using Hotel.Data.Interfaces;
using Hotel.Data.Models;
using Krypton.Toolkit;

namespace Hotel.UI.Hotel
{
    public partial class CrearReservaciones : KryptonForm
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IAdministracionRepositorio _administracionRepositorio;
        private ICollection<Usuarios> _usuarios;
        private ICollection<Habitacion> _habitaciones;
        private ICollection<Data.Models.Hotel> _hoteles;
        private ICollection<TipoHabitacion> _tipoHabitaciones;
        private int _idHotel;
        private int _idHabitacion;
        private int _ClientId;

        public CrearReservaciones(IHotelRepository hotelRepository, IAdministracionRepositorio administracionRepositorio)
        {
            _hotelRepository = hotelRepository;
            _administracionRepositorio = administracionRepositorio;
            InitializeComponent();
        }

        private void CrearReservacion_Load(object sender, EventArgs e)
        {
            _usuarios = _administracionRepositorio.GetUsuarios();
            _habitaciones = _hotelRepository.ObtenerHabitaciones();
            _hoteles = _hotelRepository.ObtenerHoteles();
            _tipoHabitaciones = _hotelRepository.ObtenerTiposHabitacion();
            txtReservaId.Text = "0";
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            CbClient.DataSource = _usuarios.Select(x => x.Nombres + " " + x.Apellidos).ToList();
            CbHabitacion.DataSource = _tipoHabitaciones.Select(x => x.Habitacion.Nombre).Distinct().ToList();
            CbHotel.DataSource = _tipoHabitaciones.Select(x => x.Hotel.Nombre).Distinct().ToList();

            CbClient.SelectedItem = _usuarios.FirstOrDefault();
            CbHabitacion.SelectedItem = _tipoHabitaciones.Select(x => x.Habitacion.Nombre).FirstOrDefault();
            CbHotel.SelectedItem = _tipoHabitaciones.Select(x => x.Habitacion.Nombre).FirstOrDefault();


        }

        private bool GuardarReservacion()
        {
            if (!Comunes.Comunes.ValidarLimpiarCampos(this)) return false;

            var reserva = new Reserva
            {
                IdHotel = _idHotel,
                ClientId = _ClientId,
                IdHabitacion = _idHabitacion,
                FechaFin = DpFechaSalida.Value,
                FechaInicio = DpFechaEntrada.Value,
                Ocupacion = 1,
                Precio = decimal.Parse(txtPrecio.Text),
                NombreTomador = txtNombreTomador.Text,
                Cantidad = int.Parse(txtCantidad.Text),
            };
            return _hotelRepository.CrearReservacion(reserva);
        }

        private void CbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            _idHotel = _hoteles.Where(x => x.Nombre == CbHotel.SelectedItem?.ToString()?.Trim()).Select(z => z.IdHotel)
                .FirstOrDefault();
        }

        private void CbHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            _idHabitacion = _habitaciones.Where(x => x.Nombre == CbHabitacion.SelectedItem?.ToString()?.Trim()).Select(z => z.IdHabitacion)
                .FirstOrDefault();
        }

        private void CbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ClientId = _usuarios.Where(x => (x.Nombres + " " + x.Apellidos) == CbClient.SelectedItem?.ToString()?.Trim()).Select(z => z.IdUsuario)
                .FirstOrDefault();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {

            if (!GuardarReservacion())
            {
                MessageBox.Show($@"Error creando reservacion {_hotelRepository?.MessageError}", "!!! ATENCION !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Reservacion creada satisfactoriamente!!!", "!!! ATENCION !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Comunes.Comunes.ValidarLimpiarCampos(this, true);
            DialogResult = DialogResult.OK;
        }

    }
}
