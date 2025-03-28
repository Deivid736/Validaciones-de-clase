using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class CarroDeCombustion : Vehiculo
    {
        private int cargaGasolina;
        private int kilometraje;
        private int capacidadGasolina;

        public CarroDeCombustion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            CapacidadTanque = 18; //Galones
            ConsumoCombustible = 2; //Litro km
            VelocidadMaxima = 220; // Km/h
            TiposLicenciaAceptada = new List<string> { "C" };
            capacidadGasolina = 75;
            cargaGasolina = 50;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            cargaGasolina--;
        }

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
            cargaGasolina--;
        }

        public int NivelGasolina() { return cargaGasolina; } //Metodo que regresa el nivel de gasolina.
        public void cargarGasolina()
        {
            cargaGasolina++;
        }

        public int nivelKilometraje() { return kilometraje; } //Metodo que regresa el nivel de kilometraje.
        public void recorrido(int cuanto)
        {
            kilometraje += cuanto;
        }

        public int CapacidadGasolina // Propiedad que regresa la capacidad de gasolina.
        {
            get { return capacidadGasolina; }
            private set{
                if (value > 0) capacidadGasolina = value; 
            }
        }

    }

}