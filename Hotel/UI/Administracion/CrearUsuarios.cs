using Hotel.Comunes;
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
    public partial class CrearUsuarios : MetroSetForm
    {
        private IAdministracionRepositorio administracion;
        public Acciones acciones;
        public int idUsuario;
        public CrearUsuarios(IAdministracionRepositorio administracion)
        {
            InitializeComponent();
            this.administracion = administracion;
            this.acciones = Acciones.Crear;
        }


        private bool GuardarEditarUsuarios(Acciones accion)
        {
            try
            {
                if (!ValidarLimpiarCampos(limpiarCampos: false)) return false;


                if (txtClave.Text.Trim().ToLower() != txtConfirmarClave.Text.Trim().ToLower())
                {
                    txtClave.Focus();
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
                    IdUsuario = accion == Acciones.Editar ? idUsuario : 0

                };
                if (accion == Acciones.Crear)
                {
                    if (!administracion.CrearUsuario(usuario)) return false;
                }
                else
                {
                    if (!administracion.EditarUsuario(usuario)) return false;
                }

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($@"{e?.Message} {e?.InnerException}");
                return false;
            }
        }



        private bool ValidarLimpiarCampos(bool limpiarCampos)
        {
            try
            {
                for (var i = 0; i < tabPage1.Controls.Count; i++)
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
                            MessageBox.Show($@"El campo {tabPage1.Controls[i].Tag} require la entrada de un valor");
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
            if (acciones == Acciones.Editar)
            {
                if (!GuardarEditarUsuarios(accion: Acciones.Editar))
                {
                    MessageBox.Show("Error Guardando Usuario");
                    return;
                }
                MessageBox.Show("!!!Usuario editado Satisfactoriamente!!!");
                DialogResult = DialogResult.OK;
                return;
            }

            if (GuardarEditarUsuarios(accion: Acciones.Crear))
            {
                MessageBox.Show("!!!Usuario creado Satisfactoriamente!!!");
                ValidarLimpiarCampos(limpiarCampos: true);
                DialogResult = DialogResult.OK;
                return;
            }
        }

        private void CrearUsuarios_Load(object sender, EventArgs e)
        {
            if (acciones != Acciones.Editar) return;
            var users = administracion.ObtenerUsuariosByCriteria(x => x.IdUsuario == idUsuario);
            foreach (var user in users)
            {
                txtCodigo.Text = user.Usuario;
                txtApellido.Text = user.Apellidos;
                txtNombre.Text = user.Nombres;
                txtCorreo.Text = user.Correo;
                txtClave.Text = user.Clave;
                txtConfirmarClave.Text = user.Clave;
                SwitchAdm.Switched = user.IsAdmin;
                SwitchEstado.Switched = user.IsActive;
            }

            //DialogResult = DialogResult.OK;
        }
    }
}
