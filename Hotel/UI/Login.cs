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
        private readonly IUsuarioRepositorio usuarioRepositorio;

        public Login(IUsuarioRepositorio usuarioRepositorio)
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
            };

            if (usuarioRepositorio.AutentificarUsuario(user))
            {
                MessageBox.Show("Authenticated");
                return;
            }
            MessageBox.Show("Not Authenticated");
        }
    }
}
