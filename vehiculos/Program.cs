using Vehiculo;

namespace Program {
	class Program {
		public static void Main(string[] args) {
			Carrera c = new Carrera();
			IVehiculo a = new Bicicleta();
			IVehiculo b = new Camion();
			a.mover(TimeSpan.FromSeconds(10));
			Console.WriteLine(a.posicion());
			c.competir(TimeSpan.FromSeconds(04), a, b);
		}
	}
}
