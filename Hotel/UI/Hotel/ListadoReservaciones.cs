using System.Collections;
using Hotel.Data.Interfaces;
using Hotel.Data.Models;
using Krypton.Toolkit;

namespace Hotel.UI.Hotel
{
    public partial class ListadoReservaciones : KryptonForm
    {

        private readonly IHotelRepository _hotelRepository;
        private readonly CrearReservaciones _crearReservaciones;
        public ListadoReservaciones(IHotelRepository hotelRepository, CrearReservaciones crearReservaciones)
        {
            _hotelRepository = hotelRepository;
            _crearReservaciones = crearReservaciones;
            InitializeComponent();
        }

        private void ListadoReservaciones_Load(object sender, EventArgs e)
        {
            //dgvReservaciones.DataSource = _hotelRepository.ObtenerReservaciones();
            dgvReservaciones.DataSource = CargarReservaciones();
        }

        private void dgvReservaciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var height = 35 + dgvReservaciones.Rows.Cast<DataGridViewRow>().Sum(dr => dr.Height);
            dgvReservaciones.Height = height;
        }

        private ICollection CargarReservaciones()
        {
            var data = _hotelRepository.ObtenerReservaciones().Select(x => new
            {
                x.IdReserva,
                Huesped = x.Usuarios.Nombres + " " + x.Usuarios.Apellidos,
                NombreHotel = x.Habitaciones.Hotel.Nombre,
                NombreHabitacion = x.Habitaciones.Habitacion.Nombre,
                x.FechaInicio,
                x.FechaFin,
                x.Cantidad,
                x.Precio,
                x.NombreTomador,
                x.ClientId,
            }).ToList();

            return data;
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            _crearReservaciones.ShowDialog();
            if (_crearReservaciones.DialogResult != DialogResult.OK) return;

            dgvReservaciones.DataSource = CargarReservaciones();
            dgvReservaciones.Update();
            dgvReservaciones.Refresh();
        }
    }
}
