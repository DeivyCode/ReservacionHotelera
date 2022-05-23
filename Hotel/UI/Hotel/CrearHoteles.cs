using Hotel.Comunes;
using Hotel.Data.Interfaces;
using Hotel.Data.Models;
using Krypton.Toolkit;

namespace Hotel.UI.Hotel
{
    public partial class CrearHoteles : KryptonForm
    {
        private readonly IAdministracionRepositorio _administracion;
        private readonly IHotelRepository _hotelRepository;
        private ICollection<Categorias> _categorias;
        private ICollection<Administrador> _administradores;
        private int _IdAdminitrador;
        private int _IdCategoria;
        public Acciones Acciones;
        public int IdHotel { get; set; }
        public CrearHoteles(IAdministracionRepositorio administracion, IHotelRepository hotelRepository)
        {
            _administracion = administracion;
            _hotelRepository = hotelRepository;
            Acciones = Acciones.Crear;
            InitializeComponent();
        }

        private void CrearHoteles_Load(object sender, EventArgs e)
        {
            if (Acciones == Acciones.Editar)
            {
                CargarDataInputs();
            }

            _categorias = _administracion.ObtenerCategorias(x => x.IsActive == true);
            _administradores = _administracion.ObtenerAdministradores(x => x.IsActive == true);
            cbCategoria.DataSource = _categorias.Select(x => x.CategoriaNombre).ToList();
            cbAdministradores.DataSource = _administradores.Select(x => x.NombreAdministrador).ToList();
            cbCategoria.SelectedIndexChanged += CbCategoria_SelectedIndexChanged;
            cbAdministradores.SelectedIndexChanged += CbAdministradores_SelectedIndexChanged;
        }

        private void CbAdministradores_SelectedIndexChanged(object sender, EventArgs e)
        {
            _IdAdminitrador = _administradores
                .Where(x => x.NombreAdministrador == cbAdministradores.SelectedItem.ToString())
                .Select(x => x.IdAdministrador).FirstOrDefault();
        }

        private void CbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            _IdCategoria = _categorias
                .Where(x => x.CategoriaNombre == cbCategoria.SelectedItem.ToString())
                .Select(x => x.Id).FirstOrDefault();

        }

        private bool CrearEditarHotel(Acciones acciones)
        {
            try
            {
                if (!Comunes.Comunes.ValidarCampos(this)) return false;
                var hotel = new Data.Models.Hotel
                {
                    Nombre = txtNombreHotel.Text,
                    IdCategoria = _IdCategoria,
                    IdAdministrador = _IdAdminitrador,
                    Domicilio = txtDomicilio.Text,
                    Descripcion = txtDescripcion.Text,
                    Localidad = txtLocalidad.Text,
                    Provincia = txtProvincia.Text,
                    IdHotel = acciones == Acciones.Editar ? IdHotel : 0
                };
                return _hotelRepository.CrearEditarHotel(model: hotel, acciones: Acciones);
            }
            catch (Exception e)
            {
                MessageBox.Show($@"{_hotelRepository.MessageError} {e?.Message}");
                return false;
            }
        }


        private void CargarDataInputs()
        {
            var hotel = _hotelRepository.ObtenerHoteles().FirstOrDefault(x => x.IdHotel == IdHotel);
            txtDescripcion.Text = hotel!.Descripcion;
            txtDomicilio.Text = hotel.Domicilio;
            txtLocalidad.Text = hotel.Localidad;
            txtNombreHotel.Text = hotel.Nombre;
            txtProvincia.Text = hotel.Provincia;
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (!CrearEditarHotel(acciones: this.Acciones))
            {
                MessageBox.Show(@"Error Creando hotel");
                return;
            }

            MessageBox.Show("!!Hotel creado satisfactoriamente!!");
            DialogResult = DialogResult.OK;
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
