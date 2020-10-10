using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        private DirectorTecnico dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            this.dt = new DirectorTecnico(textBoxNombre.ToString(), textBoxApellido.ToString(),
                (int)numericUpDownEdad.Value, (int)numericUpDownDni.Value,
                (int)numericUpDownExperiencia.Value);

        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = new DialogResult();
            if(this.dt is null)
            {
                mensaje = MessageBox.Show("El dt no ha sido instanciado");
            }else if (textBoxNombre is null || textBoxApellido is null ||
               (int)numericUpDownDni.Value <= 0
               || (int)numericUpDownEdad.Value <= 0
               || (int)numericUpDownExperiencia.Value <= 0)
            {
                mensaje = MessageBox.Show("El dt no es apto");
            }
            else
            {
                mensaje = MessageBox.Show("El dt es apto");
            }
        }
    }
}
