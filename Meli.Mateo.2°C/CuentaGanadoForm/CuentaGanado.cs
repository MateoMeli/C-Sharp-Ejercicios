using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace VistaForm
{
    public partial class CuentaGanado : Form
    {
        private Bar bar;
        private Informe informe;
        public CuentaGanado()
        {
            InitializeComponent();
            bar = Bar.GetBar();
        }

        private void ButtonInformar_Click(object sender, EventArgs e)
        {
            informe = new Informe();
            informe.rtbSalidaDeTest.Text = (string)this.bar;
            informe.ShowDialog();
            
            
        }

        private void NudEpleados_ValueChanged(object sender, EventArgs e)
        {
            Empleado a = new Empleado("Pedro", 30);
            Empleado c = new Empleado("Raul", 25);
            if(bar + a && bar + c)
            {
               
            }
            
            
        }

        private void NudGente_ValueChanged(object sender, EventArgs e)
        {
            Gente a = new Gente("Lucas", 32);
            if(bar + a)
            {
            }
            
            
        }
    }
}
