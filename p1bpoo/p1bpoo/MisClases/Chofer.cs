using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Chofer
    {
        public string Nombre { get; set; }
        public int Edad { get; private set; }
        private string tipoLicencia;
        public string TipoLicencia
        {
            get { return tipoLicencia; }
            set
            {
                if (!EdadParaLicencia(Edad, value))
                {
                    throw new Exception($"La edad no es adecuada para el tipo de licencia {value}");
                }
                tipoLicencia = value;
            }
        }


        public Chofer(string nombre, int edad, string tipoLicencia)
        {
            if (!EdadParaLicencia(edad, tipoLicencia))
            {
                throw new Exception("La edad no es adecuada para el tipo de licencia {0}");
            }
            Nombre = nombre;
            Edad = edad;
            TipoLicencia = tipoLicencia;
        }

        private bool EdadParaLicencia(int edad, string tipoLicencia)
        {
            if ((tipoLicencia == "A" || tipoLicencia == "a") && edad >= 25)
            {
                return true;
            }
            if ((tipoLicencia == "B" || tipoLicencia == "b") && edad >= 23)
            {
                return true;
            }
            if ((tipoLicencia == "C" || tipoLicencia == "c") && edad >= 18)
            {
                return true;
            }
            if ((tipoLicencia == "M" || tipoLicencia == "m") && edad >= 16)
            {
                return true;
            }
            return false;
        }

        public void mostrarInformacion()
        {
            Console.WriteLine("El piloto es: {0}", Nombre);
            Console.WriteLine("Edad: {0}", Edad);
            Console.WriteLine("Tipo de Licencia: {0}", TipoLicencia);
        }
    }
}