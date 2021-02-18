using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Entidades
{
    public delegate void AvanceInfectados(int dia, long poblacion);
    public delegate void FinInfectacion();
    public static class GrupoDePrueba<T> where T : Microorganismo
    {
        private static T enfermedad;
        private static long poblacion;

        public static event FinInfectacion FinalizaSimulacion;
        public static event AvanceInfectados InformeDeAvance;
        public static long Poblacion
        {
            get
            {
                return poblacion;
            }
            set
            {
                poblacion = value;
            }
        }

        static GrupoDePrueba()
        {
            Poblacion = 10000000;
        }

        public static void InfectarPoblacion(Object obj)
        {
            int dia = 1;
            if (obj is T)
            {
                enfermedad = (T)obj;
                if(InformeDeAvance != null && FinalizaSimulacion != null)
                {
                    long contagiados = enfermedad.IndiceDeContagios;
                    while (contagiados <= Poblacion)
                    {
                        InformeDeAvance.Invoke(dia++, Poblacion);
                        Thread.Sleep(750);
                    }
                    FinalizaSimulacion.Invoke();
                }
            }
        }

    }
}
