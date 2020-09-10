using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void saludar_onClick(object sender, EventArgs e)
        {
            string nombre = this.textBoxNombre.Text;

            if (ValidarNombre(nombre))
            {
                nombre = nombre.Trim();
                string mensaje = $"Hola {nombre}!!!";

                MensajeForm mensajeForm = new MensajeForm();
                mensajeForm.Mensaje = mensaje;

                mensajeForm.ShowDialog();

                //MessageBox.Show($"Hola {nombre}!!!", "Saludo", MessageBoxButtons.YesNoCancel,
                    //MessageBoxIcon.Information);
            }

            DialogResult result = MessageBox.Show("¿Desea continuar?", "ALERTA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.No)
            {
                this.Close();
            }
            

        }

        private bool ValidarNombre(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Debe ingresar un nombre", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
