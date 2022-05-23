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
        private int _idHotel;
        private int _idHabitacion;
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
            DialogResult = DialogResult.OK;
        }

        private void CrearTipoHabitacion_Load(object sender, EventArgs e)
        {
            _habitacionesList = _hotelRepository.ObtenerHabitaciones();
            _hotelList = _hotelRepository.ObtenerHoteles();

            CbHabitaciones.DataSource = _habitacionesList.Select(x => x.Nombre).ToList();
            CbHoteles.DataSource = _hotelList.Select(x => x.Nombre).ToList();

            CbHabitaciones.SelectedItem = _habitacionesList.FirstOrDefault();
            CbHoteles.SelectedItem = _hotelList.FirstOrDefault();
        }

        private bool CrearEditarTipoHabitacion(Acciones acciones)
        {

            try
            {
                if (!Comunes.Comunes.ValidarCampos(this)) return false;

                var model = new TipoHabitacion
                {
                    IdHabitacion = _idHabitacion,
                    IdHotel = _idHotel,
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
            _idHotel = _hotelList.Where(x => x.Nombre == CbHoteles.SelectedItem.ToString())
                                 .Select(x => x.IdHotel)
                                 .FirstOrDefault();
        }

        private void CbHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            _idHabitacion = _habitacionesList.Where(x => x.Nombre == CbHabitaciones.SelectedItem.ToString())
                .Select(x => x.IdHabitacion)
                .FirstOrDefault();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
