using Hotel.Comunes;
using Hotel.Data.Interfaces;
using Krypton.Toolkit;

namespace Hotel.UI.Hotel
{
    public partial class ListadoHoteles : KryptonForm
    {
        private readonly IHotelRepository _hotelRepository;
        public ListadoHoteles(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
            InitializeComponent();
        }


        private void CargarData()
        {
            var data = _hotelRepository.ObtenerHoteles();
            kryptonDataGridView1.DataSource = data.Select(x => new
            {
                Categoria = x.Categoria.CategoriaNombre,
                Administrador = x.Administrador.NombreAdministrador,
                x.Descripcion,
                x.Domicilio,
                x.IdHotel,
                x.Nombre,
                x.Provincia,
                x.Localidad,
            }).ToList();
        }

        private void ListadoHoteles_Load(object sender, EventArgs e)
        {
            CargarData();
            txtBusqueda.TextChanged += TxtBusqueda_TextChanged;
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = _hotelRepository.ObtenerHoteles()
                .Where(x => x.Nombre.Contains(txtBusqueda.Text.Trim().ToUpper()) ||
                            x.Provincia.Contains(txtBusqueda.Text.Trim().ToUpper()) ||
                            x.Domicilio.Contains(txtBusqueda.Text.Trim().ToUpper()) ||
                            x.Localidad.Contains(txtBusqueda.Text.Trim().ToUpper()) ||
                            x.Categoria.CategoriaNombre.Contains(txtBusqueda.Text.Trim().ToUpper()) ||
                            x.Administrador.NombreAdministrador.Contains(txtBusqueda.Text.Trim().ToUpper()))
                .Select(x => new
                {
                    Categoria = x.Categoria.CategoriaNombre,
                    Administrador = x.Administrador.NombreAdministrador,
                    x.Descripcion,
                    x.Domicilio,
                    x.IdHotel,
                    x.Nombre,
                    x.Provincia,
                    x.Localidad,
                }).ToList();
            kryptonDataGridView1.Update();
            kryptonDataGridView1.Refresh();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            var form = (Program.ServiceProvider.GetService(typeof(CrearHoteles)) as CrearHoteles);
            form!.Acciones = Acciones.Crear;
            form.ShowDialog();

            CargarData();
            kryptonDataGridView1.Update();
            kryptonDataGridView1.Refresh();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(@"Debe seleccionar un registro");
                return;
            }

            var form = (Program.ServiceProvider.GetService(typeof(CrearHoteles)) as CrearHoteles);
            form!.Acciones = Acciones.Editar;
            form.IdHotel = (int)kryptonDataGridView1.SelectedRows[0].Cells["IdHotel"].Value;
            form.ShowDialog();

            CargarData();
            kryptonDataGridView1.Update();
            kryptonDataGridView1.Refresh();
        }

        private void kryptonDataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var height = 35 + kryptonDataGridView1.Rows.Cast<DataGridViewRow>().Sum(dr => dr.Height);
            kryptonDataGridView1.Height = height;
        }

        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
