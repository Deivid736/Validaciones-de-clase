using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.Interfaces;

namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        private Chofer piloto = null;
        private int estadoVehiculo = 0;
        private int velocidad = 0;

        protected List<string> TiposLicenciaAceptada = new List<string> { "A", "B", "C" };
        protected int VelocidadMaxima = 240;
        protected int CapacidadTanque = 16;
        protected double ConsumoCombustible = 0.43; // Calculo de consumo, esto por cada 37km (promedio reales) se consume en galon de gasolina.

        public string asignarPiloto(Chofer elPiloto)
        { //Metodo que asigna un piloto al vehiculo
            if (elPiloto == null)
            {
                return "No se puede signar un piloto nulo";
            }
            if (!TiposLicenciaAceptada.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene el tipo de licencia adecuada para este vehiculo";
            }
            if (piloto != null)
            {
                return "El piloto ya esta asignado";
            }
            piloto = elPiloto;
            return "Piloto asignado";
        }

        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Año: {0}", this.Year);
            Console.WriteLine("Velocidad Actual: {0} KMS / Hora", this.velocidad);
            Console.WriteLine("Velocidad Máxima: {0} KMS / Hora", this.VelocidadMaxima);
            string estado = estadoVehiculo == 0 ? "Apagado" : (velocidad > 0 ? "En Movimiento" : "Encendido");
            Console.WriteLine("Estado del Vehículo: {0}", estado);
        }

        public string Encender()
        {
            if (asignarPiloto == null)
            {
                return "No se puede encender el vehiculo sin piloto";
            }
            if (estadoVehiculo == 0)
            {
                estadoVehiculo = 1;
                return "El vehiculo esta encendido";
            }
            else
            {
                return "El vehiculo ya esta encendido";
            }
        }

        public virtual void acelerar(int cuanto)
        {
            if (estadoVehiculo == 0)
            {
                Console.WriteLine("El vehiculo se encuentra apagado", velocidad);
                return;
            }
            if (estadoVehiculo == 1)
            {
                velocidad += cuanto;
                Console.WriteLine("vas a {0} KMS / Hora", velocidad);
            }
            if (velocidad > VelocidadMaxima)
            {
                Console.WriteLine("Vas a {0} KMS / Hora, Se esta excediendo la velocidad maxima", velocidad);
            }
        }

        //Metodos añadidos para la clase Vehiculo
        public virtual void frenar(int cuanto) //Un metodo virtual que le dice al vehiculo que frene o disminuya la velocidad.
        {
            velocidad -= cuanto;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);

            if (velocidad == 0)
            {
                Console.WriteLine("Vehiculo encendido");
                estadoVehiculo = 1;
            }
        }

        public virtual void apagar() //Un metodo virtual que le dice al vehiculo que se apague.
        {
            velocidad = 0;
            Console.WriteLine("El vehiculo esta apagado");

            if (estadoVehiculo == 1)
            {
                Console.WriteLine("El vehiculo esta apagado");
                estadoVehiculo = 0;
            }
        }
    }

}
