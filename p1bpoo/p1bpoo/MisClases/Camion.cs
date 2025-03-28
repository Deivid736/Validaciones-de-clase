using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Camion : Vehiculo
    {

        public Camion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            CapacidadTanque = 100;
            ConsumoCombustible = 0.75;
            VelocidadMaxima = 140;
            TiposLicenciaAceptada = new List<string> { "A", "a" };
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
        }

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
        }

    }
}