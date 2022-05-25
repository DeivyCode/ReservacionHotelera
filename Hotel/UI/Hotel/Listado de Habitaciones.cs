using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace Hotel.UI.Hotel
{
    public partial class Listado_de_Habitaciones : KryptonForm
    {
        public Listado_de_Habitaciones()
        {
            InitializeComponent();
        }

        private void Listado_de_Habitaciones_Load(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            var form = (Program.ServiceProvider.GetService(typeof(CrearHabitaciones)) as CrearHabitaciones);
            form.ShowDialog();

        }
    }
}
