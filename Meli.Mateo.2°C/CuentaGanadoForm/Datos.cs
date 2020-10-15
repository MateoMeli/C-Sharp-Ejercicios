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

namespace CuentaGanadoForm
{
    public partial class Datos : Form
    {
        private Bar bar;
        private Type tipo;

        public Datos()
        {
            InitializeComponent();
        }
        public Datos(Bar bar, Type tipo) : this()
        {
            this.bar = bar;
            this.tipo = tipo;
        }
        public string Nombre
        {
            get
            {
                return this.textNombre.Text;
            }

        }
        public string Edad
        {
            get
            {
                return this.textEdad.Text;
            }

        }
        public string Dni
        {
            get
            {
                return this.textDni.Text;
            }

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if(this.tipo == typeof(Empleado))
            {
                Empleado empleado = EmpleadoNuevo(Nombre, Edad, Dni);
                bool empleadoAgregado = bar + empleado;
                if(empleadoAgregado)
                {
                    this.Close();
                }
            }
            else if(this.tipo == typeof(Gente))
            {
                Gente gente = GenteNueva(Edad);
                bool genteAgregada = bar + gente;
                if (genteAgregada)
                {
                    this.Close();
                }
            }
        }
        private Gente GenteNueva(string edad)
        {
            Gente nuevo;
            short edadAux;
            if(short.TryParse(edad, out edadAux))
            {
                nuevo = new Gente(edadAux);
                if (nuevo.Validar())
                {
                    return nuevo;
                }
            }
            return null;
            

        }
        private Empleado EmpleadoNuevo(string nombre, string edad, string dni)
        {
            Empleado empleado;
            short edadAux;
            int dniAux;
            short.TryParse(edad, out edadAux);
            int.TryParse(dni, out dniAux);
            if (string.IsNullOrEmpty(dni))
            {
                empleado = new Empleado(nombre, edadAux);
                if (empleado.Validar())
                {
                    return empleado;
                }
            }
            else
            {
                empleado = new Empleado(nombre, edadAux, dniAux);
                if (empleado.Validar())
                {
                    return empleado;
                }
            }
            return empleado;
        }

        private void datos_Load(object sender, EventArgs e)
        {
            LlenarSegunTipo();
        }
        private void LlenarSegunTipo()
        {
            if(this.tipo == typeof(Gente))
            {
                this.textNombre.Enabled = false;
                this.textDni.Enabled = false;
            }
        }
    }
}
