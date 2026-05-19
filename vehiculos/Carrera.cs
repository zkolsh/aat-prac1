using Vehiculo;

namespace Program {
	class Carrera {
		public void competir(TimeSpan t, IVehiculo a, IVehiculo b) {
			Console.WriteLine(a.posicion());
			a.reiniciarPosicion();
			a.mover(t);
			b.reiniciarPosicion();
			b.mover(t);
			if (a.posicion() == b.posicion()) {
				Console.WriteLine("Empate");
				Console.WriteLine(a.posicion());
				Console.WriteLine(b.posicion());
				Console.WriteLine(t);
			} else if (a.posicion() > b.posicion()) {
				Console.WriteLine("A ganó");
			} else {
				Console.WriteLine("B ganó");
			}
		}
	}
}
