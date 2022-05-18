using Hotel.Data.Interfaces;
using Hotel.Data.Models;
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

        public Login(IAdministracionRepositorio usuarioRepositorio)
        {
            InitializeComponent();
            this.usuarioRepositorio = usuarioRepositorio;
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
            var user = new Usuarios
            {
                Clave = claveTxt.Text.ToLower(),
                Usuario = userTxt.Text.ToLower(),
                Apellidos ="for testing",
                Nombres = "Standard User",
                Correo ="stard.test@mail.com",
                IsAdmin = false,
            };

            if (usuarioRepositorio.CrearUsuario(user))
            {
                MessageBox.Show("User Created");
                return;
            }
            MessageBox.Show("Error Creating User");
        }
    }
}
