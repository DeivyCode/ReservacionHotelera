using Hotel.Data.Interfaces;
using Hotel.Data.Models;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.UI.Administracion
{
    public partial class ListadoUsuarios : MetroSetForm
    {
        private IAdministracionRepositorio administracion;
        public ListadoUsuarios(IAdministracionRepositorio administracion)
        {
            InitializeComponent();
            this.administracion = administracion;
            //admBindingSource.DataSource = 
        }

        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = administracion.GetUsuarios();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var height = 35;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                height += dr.Height;
            }
            dataGridView1.Height = height;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                var rows = dataGridView1.SelectedRows[0];
                var crearUsuario = (Program.ServiceProvider.GetService(typeof(CrearUsuarios)) as CrearUsuarios);

                crearUsuario.acciones = Comunes.Acciones.Editar;
                crearUsuario.idUsuario = (int)rows.Cells["IdUsuario"].Value;
                crearUsuario.ShowDialog();
                if (crearUsuario.DialogResult == DialogResult.OK)
                {
                    dataGridView1.DataSource = administracion.GetUsuarios();
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
            }
        }
    }
}
