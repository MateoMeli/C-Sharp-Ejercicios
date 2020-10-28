using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class FileManager
    {
        public void EscribirArchivoTexto(string ruta, string nombre, string texto, bool anexar)
        {
            StreamWriter streamWriter = null;
            try
            {
                string rutaCompleta = ruta + @"\" + nombre + ".txt";
                streamWriter = new StreamWriter(rutaCompleta, anexar);
                streamWriter.WriteLine(texto);
            }
            finally
            {
                if(streamWriter != null)
                    streamWriter.Close();
            }
        }

        public string LeerArchivoTexto(string ruta, string nombre)
        {
            StreamReader streamReader = null;
            try
            {
                string rutaCompleta = ruta + @"\" + nombre + ".txt";
                streamReader = new StreamReader(rutaCompleta);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();
            }
        }
    }
}
