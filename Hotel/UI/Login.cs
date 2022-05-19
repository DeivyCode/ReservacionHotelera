using Hotel.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.UI
{
    public partial class Login : Form
    {
        private readonly IAdministracionRepositorio usuarioRepositorio;
        private readonly IHotelRepository hotelRepository;
        public Login(IAdministracionRepositorio usuarioRepositorio, IHotelRepository hotelRepository)
        {
            InitializeComponent();
            this.usuarioRepositorio = usuarioRepositorio;
            this.hotelRepository = hotelRepository;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();









        }

        private void btnovisible_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var obj = new Data.Models.Habitacion
            {
                Capacidad = 3,
                Nombre = "HABITACION 102"
            };
               var objEdit = new Data.Models.Habitacion
            {
                Capacidad = 6,
                Nombre = "HABITACION 102",
               IdHabitacion = 3
            };
            var obj1 = new Data.Models.Hotel
            {
                Nombre = "HOTEL PRAVIA",
                Descripcion = "HOTEL DE LUJO",
                Domicilio = "AVE MAXIMO GOMEZ #12",
                Localidad = "APT 1-B",
                Provincia = "PERAVIA, BANI",
                IdCategoria = 1,
                IdAdministrador = 1

            };
            var obj2 = new Data.Models.TipoHabitacion
            {
                IdHabitacion = 1,
                IdHotel = 1,
                Descripcion = "EJECUTIVA",
                Precio = 1650,
                NumHabitaciones = 2,
            };

            if (hotelRepository.CrearEditarHabitacion(model: objEdit, acciones: Comunes.Acciones.Editar))
            {
                MessageBox.Show("Work");
                return;
            }
            MessageBox.Show($"DON'T WORK {hotelRepository.MessageError}");
        }
    }
}
