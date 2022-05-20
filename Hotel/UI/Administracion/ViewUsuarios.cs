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
    public partial class ViewUsuarios : MetroSetForm
    {
        private IAdministracionRepositorio administracion;

        public ViewUsuarios(IAdministracionRepositorio administracion)
        {
            InitializeComponent();
            this.administracion = administracion;
        }


        private bool GuardarUsuarios()
        {
            try
            {
                if (!ValidarLimpiarCampos(limpiarCampos: false)) return false;


                if (txtClave.Text.Trim().ToLower() != txtConfirmarClave.Text.Trim().ToLower())
                {   txtClave.Focus();
                    MessageBox.Show("Las contraseñas no cooindicen, porfavor verifica tu contraseña");
                    return false;
                }
                var usuario = new Usuarios
                {
                    Usuario = txtCodigo.Text,
                    Nombres = txtNombre.Text,
                    Apellidos = txtApellido.Text,
                    Clave = txtClave.Text,
                    Correo = txtCorreo.Text,
                    IsActive = SwitchEstado.Switched,
                    IsAdmin = SwitchAdm.Switched,

                };
                if (!administracion.CrearUsuario(usuario)) return false;

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e?.Message} {e?.InnerException}");
                return false;
            }
        }



        private bool ValidarLimpiarCampos(bool limpiarCampos)
        {
            try
            {
                for (int i = 0; i < tabPage1.Controls.Count; i++)
                {
                    if (tabPage1.Controls[i].GetType() == typeof(TextBox))
                    {
                        if (limpiarCampos)
                        {
                            tabPage1.Controls[i].Text = "";
                            continue;
                        }
                        else if (String.IsNullOrEmpty(tabPage1.Controls[i].Text))
                        {
                            MessageBox.Show($"El campo {tabPage1.Controls[i].Tag} require la entra de un valor");
                            tabPage1.Controls[i].Focus();
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (GuardarUsuarios())
            {
                MessageBox.Show("!!!Usuario creado Satisfactoriamente!!!");
                ValidarLimpiarCampos(limpiarCampos: true);
            }
        }
    }
}
