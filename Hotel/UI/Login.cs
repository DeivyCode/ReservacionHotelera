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
        public MainMenu()
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
            if(usuarioRepositorio.AutentificarUsuario("a", "e"))
            {
                MessageBox.Show("work");
            }
            
        }
    }
}
