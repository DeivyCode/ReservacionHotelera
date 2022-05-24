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
using Hotel.Comunes;

namespace Hotel.UI.Administracion
{
    public partial class ListadoUsuarios : MetroSetForm
    {
        private readonly IAdministracionRepositorio _administracion;
        private readonly CrearUsuarios _crearUsuario;
        public ListadoUsuarios(IAdministracionRepositorio administracion, CrearUsuarios crearUsuario)
        {
            InitializeComponent();
            this._administracion = administracion;
            this._crearUsuario = crearUsuario;
        }

        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _administracion.GetUsuarios();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var height = 35 + dataGridView1.Rows.Cast<DataGridViewRow>().Sum(dr => dr.Height);
            dataGridView1.Height = height;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var rows = dataGridView1.SelectedRows[0];


            _crearUsuario.acciones = Comunes.Acciones.Editar;
            _crearUsuario.idUsuario = (int)rows.Cells["IdUsuario"].Value;
            _crearUsuario.ShowDialog();
            if (_crearUsuario.DialogResult != DialogResult.OK) return;
            dataGridView1.DataSource = _administracion.GetUsuarios();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void btCrearUsuarios_Click(object sender, EventArgs e)
        {
            _crearUsuario.acciones = Acciones.Crear;
            _crearUsuario.ShowDialog();
            if (_crearUsuario.DialogResult != DialogResult.OK) return;
            dataGridView1.DataSource = _administracion.GetUsuarios();
            dataGridView1.Update();
            dataGridView1.Refresh();

        }

       

    
    }
}
