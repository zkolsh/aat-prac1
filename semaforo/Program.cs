using System;
using Sem;

namespace Program {
	class Program {
		public static void Main(string[] args) {
			Console.WriteLine("HOLA");
			Semaforo sem = new Semaforo(Semaforo.Color.Rojo);
			sem.pasoDelTiempo(TimeSpan.FromSeconds(15));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(7));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(25));
			Console.WriteLine(sem.mostrarColor());
			sem.ponerEnIntermitente();
			sem.pasoDelTiempo(TimeSpan.FromSeconds(0.25));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(0.25));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(0.25));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(0.25));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(0.25));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(0.25));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(0.25));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(1.75));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(1.35));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(2.5));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(1.95));
			Console.WriteLine(sem.mostrarColor());
			sem.sacarDeIntermitente();
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(1.5));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(12));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(57));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(1));
			Console.WriteLine(sem.mostrarColor());
			sem.pasoDelTiempo(TimeSpan.FromSeconds(100));
			Console.WriteLine(sem.mostrarColor());
		}
	}
}
