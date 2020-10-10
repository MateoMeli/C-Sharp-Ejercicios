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

namespace CuentaGanadoForm
{
    public partial class Form1 : Form
    {
        private Bar bar;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInformar_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            //form.rtbSalidaDeTest.Text = this.bar.ToString();
            form.ShowDialog();
            
            
        }

        private void numericUpDownEmpleados_ValueChanged(object sender, EventArgs e)
        {
            //Empleado a = new Empleado("Pedro", 30);
            //bar += a;
            
        }

        private void numericUpDownGente_ValueChanged(object sender, EventArgs e)
        {
            //Gente a = new Gente(32);
            //bar += a;
            
        }
    }
}
