using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuentaGanadoForm;
using Entidades;

namespace VistaForm
{
    public partial class CuentaGanado : Form
    {
        private Bar bar;
        private Informe informe;
        private Datos datos;
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

        private void NudEmpleados_ValueChanged(object sender, EventArgs e)
        {
            int empleadosActuales = (int)nudEmpleados.Value;
            if(bar.Empleados.Count < empleadosActuales)
            {
                datos = new Datos(bar, typeof(Empleado));
                datos.ShowDialog();
                nudEmpleados.Value = bar.Empleados.Count;
            }else if(bar.Empleados.Count > empleadosActuales)
            {
                bar.Empleados.RemoveAt(bar.Empleados.Count);
            }

            
            
        }

        private void NudGente_ValueChanged(object sender, EventArgs e)
        {
            int genteActual = (int)nudGente.Value;
            if(bar.Gente.Count < genteActual)
            {
                datos = new Datos(bar, typeof(Gente));
                datos.ShowDialog();
                nudGente.Value = bar.Gente.Count;
            }else if(bar.Gente.Count > genteActual)
            {
                bar.Gente.RemoveAt(bar.Gente.Count);
            }
            
            
        }
    }
}
