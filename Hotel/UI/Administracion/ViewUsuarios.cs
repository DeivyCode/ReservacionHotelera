using Hotel.Data.Interfaces;
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
    public partial class ViewUsuarios : MetroSetForm
    {
        private IAdministracionRepositorio administracion;

        public ViewUsuarios(IAdministracionRepositorio administracion)
        {
            InitializeComponent();
            this.administracion = administracion;
        }



    }
}
