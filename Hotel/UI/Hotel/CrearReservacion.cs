using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            txtReservaId.Text = "0";
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            CbClient.DataSource = _usuarios.Select(x => x.Nombres + " " + x.Apellidos).ToList();
            CbHabitacion.DataSource = _habitaciones.Select(x => x.Nombre).ToList();
            CbHotel.DataSource = _hoteles.Select(x => x.Nombre).ToList();

            CbClient.SelectedItem = _usuarios.FirstOrDefault();
            CbHabitacion.SelectedItem = _habitaciones.FirstOrDefault();
            CbHotel.SelectedItem = _hoteles.FirstOrDefault();


        }

        private bool GuardarReservacion()
        {
            if (!Comunes.Comunes.ValidarCampos(this)) return false;

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
                MessageBox.Show($@"Error creando reservacion", "!!! ATENCION !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Reservacion creada satisfactoriamente!!!", "!!! ATENCION !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
