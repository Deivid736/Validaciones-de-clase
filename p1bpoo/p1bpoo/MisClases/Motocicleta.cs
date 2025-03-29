using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Motocicleta : Vehiculo
    {

        public Motocicleta(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            CapacidadTanque = 10;
            ConsumoCombustible = 0.25;
            VelocidadMaxima = 180;
            TiposLicenciaAceptada = new List<string> { "M", "m" };
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto + 12);
        }

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto - 8);
        }

        public void Hacercaballito(int velocidad)
        {
            if (velocidad == 30)
            {
                Console.WriteLine("Haciendo Caballito");
            }
            else
            {
                Console.WriteLine("No se puede hacer caballito");
            }
        }

    }
}