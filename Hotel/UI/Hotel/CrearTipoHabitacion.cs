using Hotel.Comunes;
using Hotel.Data.Interfaces;
using Hotel.Data.Models;
using Krypton.Toolkit;


namespace Hotel.UI.Hotel
{
    public partial class CrearTipoHabitacion : KryptonForm
    {
        private readonly IHotelRepository _hotelRepository;
        public Acciones Acciones { get; set; } = Acciones.Crear;
        public int IdHotel { get; set; }
        public int IdHabitacion { get; set; }
        private ICollection<Data.Models.Hotel> _hotelList;
        private ICollection<Habitacion> _habitacionesList;
        public CrearTipoHabitacion(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
            InitializeComponent();
        }


        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (!CrearEditarTipoHabitacion(acciones: Acciones))
            {
                MessageBox.Show($@"Error Creando tipo de habitacion {_hotelRepository.MessageError}", "!!!ATENCION!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(@"Tipo de habitacion creado satisfactoriamente", "!!!ATENCION!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Comunes.Comunes.ValidarLimpiarCampos(this, true);
            DialogResult = DialogResult.OK;
        }

        private void CrearTipoHabitacion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private bool CrearEditarTipoHabitacion(Acciones acciones)
        {

            try
            {
                if (!Comunes.Comunes.ValidarLimpiarCampos(this)) return false;

                var model = new TipoHabitacion
                {
                    IdHabitacion = IdHabitacion,
                    IdHotel = IdHotel,
                    Descripcion = txtDescripcion.Text,
                    NumHabitaciones = Convert.ToInt16(txtNumeroHabitaciones.Text),
                    Precio = decimal.Parse(txtPrecio.Text),
                };
                return (_hotelRepository.CrearEditarTipoHabitacion(model: model, acciones: acciones));
            }
            catch (Exception e)
            {
                MessageBox.Show($@"{e?.Message} {e?.InnerException} {_hotelRepository.MessageError}");
                return false;
            }

        }

        private void CbHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdHotel = _hotelList.Where(x => x.Nombre == CbHoteles.SelectedItem.ToString())
                                 .Select(x => x.IdHotel)
                                 .FirstOrDefault();
        }

        private void CbHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdHabitacion = _habitacionesList.Where(x => x.Nombre == CbHabitaciones.SelectedItem.ToString())
                .Select(x => x.IdHabitacion)
                .FirstOrDefault();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void CargarDatos()
        {
            _habitacionesList = _hotelRepository.ObtenerHabitaciones();
            _hotelList = _hotelRepository.ObtenerHoteles();

            CbHabitaciones.DataSource = _habitacionesList.Select(x => x.Nombre).ToList();
            CbHoteles.DataSource = _hotelList.Select(x => x.Nombre).ToList();

            if (Acciones == Acciones.Editar)
            {
                var selectedRecord = _hotelRepository.ObtenerTiposHabitacion().FirstOrDefault(x => x.IdHotel == IdHotel && x.IdHabitacion == IdHabitacion);

                CbHabitaciones.SelectedItem = selectedRecord.Habitacion.Nombre;
                CbHoteles.SelectedItem = selectedRecord.Hotel.Nombre;
                txtDescripcion.Text = selectedRecord.Descripcion;
                txtNumeroHabitaciones.Text = $@"{selectedRecord.NumHabitaciones}";
                txtPrecio.Text = $@"{selectedRecord.Precio}";
            }
            else
            {
                CbHabitaciones.SelectedItem = _habitacionesList.FirstOrDefault();
                CbHoteles.SelectedItem = _hotelList.FirstOrDefault();
            }

        }

        private void CrearTipoHabitacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Comunes.Comunes.ValidarLimpiarCampos(this, true);
        }
    }
}
