using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace _20210211___Pandemia___alumnos
{
    public partial class SimuladorForm : Form
    {
        private Thread hilo;
        
        public SimuladorForm()
        {
            InitializeComponent();
            this.cmbMicroorganismo.SelectedIndex = 0;
            GrupoDePrueba<Microorganismo>.InformeDeAvance += Informe;
            GrupoDePrueba<Microorganismo>.FinalizaSimulacion += Final;
        }

        private void Ejecutar<T>(T enfermedad)  where T : Microorganismo
        {
            this.txtEvolucion.Text = enfermedad.Informe();
            hilo = new Thread(Informe);
        }

        public void Informe(int dia, long infectados)
        {
            this.txtEvolucion.Text = $"Dia {dia}: {infectados} infectados de la poblacion total";
            
        }

        private void Final()
        {
            this.txtEvolucion.Text = "¡Toda la poblacion fue infectada!";
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            Microorganismo nuevo;
            if(this.cmbMicroorganismo.SelectedIndex == 0)
            {
                nuevo = new Covid19("Cepa Argentina");
            }
            else
            {
                nuevo = new Gripe("Gripe Cubana", ETipo.Bacteria, EContagiosidad.Moderada);
            }
            if(nuevo is Covid19)
            {
                GrupoDePrueba<Covid19>.InfectarPoblacion(nuevo);
            }
            else 
            {
                GrupoDePrueba<Gripe>.InfectarPoblacion(nuevo);
            }
            Ejecutar<Microorganismo>(nuevo);
        }

        private void SimuladorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hilo != null && this.hilo.IsAlive)
            {
                this.hilo.Abort();
            }
        }
    }
}
