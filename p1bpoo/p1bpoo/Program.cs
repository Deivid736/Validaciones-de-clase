
using p1bpoo.MisClases;

//Vehiculo miCarrito = new Vehiculo(2026,"Azul","Alfa Romeo");
//Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");
//CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");
//CarroDeCombustion miFerrari = new CarroDeCombustion(2004, "Rojo", "Ferrari");
//Motocicleta miMoto = new Motocicleta(2013, "Gris", "Yamaha mt-09");
//Camion miCamion = new Camion(2010, "Blanco", "Kenworth");

//miBYD.InformacionVehiculo();
//miBYD.cargarBateria();
//Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria());

//miFerrari.InformacionVehiculo();
//miFerrari.cargarGasolina();
//Console.WriteLine("El nivel de gasolina es: {0}", miFerrari.NivelGasolina());


Chofer piloto1 = new Chofer("Deivid", 25, "A");
Chofer piloto2 = new Chofer("Alberto", 21, "M");


piloto1.mostrarInformacion();
piloto2.mostrarInformacion();
Vehiculo sedan = new Vehiculo(2025, "Blanco", "Toyota");


string respuesta;
respuesta = sedan.asignarPiloto(piloto1);
Console.WriteLine(respuesta);
respuesta = sedan.Encender();
Console.WriteLine(respuesta);
sedan.acelerar(25);


