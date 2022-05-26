using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Comunes;
using Hotel.Data.Interfaces;
using Krypton.Toolkit;

namespace Hotel.UI.Hotel
{
    public partial class ListadoTipoHabitaciones : KryptonForm
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly CrearTipoHabitacion _crearTipoHabitacion;
        public ListadoTipoHabitaciones(IHotelRepository hotelRepository, CrearTipoHabitacion crearTipoHabitacion)
        {
            _hotelRepository = hotelRepository;
            _crearTipoHabitacion = crearTipoHabitacion;
            InitializeComponent();
        }

        private void CargarDatos()
        {
            var data = _hotelRepository.ObtenerTiposHabitacion().Select(x => new
            {
                x.IdHotel,
                x.IdHabitacion,
                NombreHotel = x.Hotel.Nombre,
                NombreHabitacion = x.Habitacion.Nombre,
                x.Descripcion,
                x.Precio,
                x.NumHabitaciones,
            }).ToList();

            dgvTipoHabitacion.DataSource = data;
            kryptonHeader1.Values.Description = @$"{data.Count}";
        }

        private void ListadoTipoHabitaciones_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            _crearTipoHabitacion.Acciones = Acciones.Crear;
            _crearTipoHabitacion.ShowDialog();
            if (_crearTipoHabitacion.DialogResult != DialogResult.OK) return;
            CargarDatos();
            dgvTipoHabitacion.Update();
            dgvTipoHabitacion.Refresh();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dgvTipoHabitacion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro");
                return;
            }

            _crearTipoHabitacion.Acciones = Acciones.Editar;
            _crearTipoHabitacion.IdHotel = (int)dgvTipoHabitacion.SelectedRows[0].Cells["IdHotel"].Value;
            _crearTipoHabitacion.IdHabitacion = (int)dgvTipoHabitacion.SelectedRows[0].Cells["IdHabitacion"].Value;
            _crearTipoHabitacion.ShowDialog();
            if (_crearTipoHabitacion.DialogResult != DialogResult.OK) return;
            CargarDatos();
            dgvTipoHabitacion.Update();
            dgvTipoHabitacion.Refresh();

        }
    }
}
