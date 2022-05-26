﻿using Hotel.Comunes;
using Hotel.Data.Interfaces;
using Hotel.Data.Models;
using Krypton.Toolkit;

namespace Hotel.UI.Hotel
{
    public partial class CrearHabitaciones : KryptonForm
    {
        private readonly IHotelRepository _hotelRepository;
        public Acciones Acciones { get; set; } = Acciones.Crear;
        public int IdHabitacion { get; set; }
        public CrearHabitaciones(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {

            if (!Comunes.Comunes.ValidarLimpiarCampos(this)) return;

            var habitacion = new Habitacion
            {
                Nombre = txtNombreHabitacion.Text,
                Capacidad = short.Parse(txtCapacidad.Text),
                IdHabitacion = Acciones == Acciones.Editar ? IdHabitacion : 0
            };
            if (!_hotelRepository.CrearEditarHabitacion(model: habitacion, acciones: Acciones))
            {
                MessageBox.Show($@"Error creando habitacion {_hotelRepository.MessageError}");
                return;
            }

            MessageBox.Show("Habitacion Creada satisfactoriamente!!!");
            DialogResult = DialogResult.OK;
            Comunes.Comunes.ValidarLimpiarCampos(this, true);
        }

        private void CrearHabitaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
