using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krypton.Toolkit;

namespace Hotel.Comunes
{
    public class Comunes
    {
        /// <summary>
        /// Valida los text box que esten en el formulario
        /// espefificamente los de tipo KryptonTextBox
        /// </summary>
        /// <param name="form"></param>
        /// <param name="limpiarCampos"></param>
        /// <returns>bool</returns>
        public static bool ValidarLimpiarCampos(Form form, bool limpiarCampos = false)
        {
            for (var i = 0; i < form.Controls.Count; i++)
            {
                if (limpiarCampos)
                {
                    if (form.Controls[i].GetType() == typeof(KryptonTextBox))
                    {
                        form.Controls[i].Text = string.Empty;
                        continue;
                    }
                }
                if (form.Controls[i].GetType() != typeof(KryptonTextBox)) continue;

                if (!string.IsNullOrEmpty(form.Controls[i].Text)) continue;
                form.Controls[i].Focus();
                MessageBox.Show($@"Este campo requiere la entrada de un valor {form.Controls[i].Name}");
                return false;
            }

            return true;
        }
    }
}
