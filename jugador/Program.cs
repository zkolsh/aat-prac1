namespace Program {
	class Program {
		static void maraton(IJugador.IJugador j) {
			j.correr(7);
			j.correr(7);
			j.descansar(5);
			j.correr(7);
			if (!j.cansado()) {
				Console.WriteLine("Vuelta 1 completa");
			} else {
				Console.WriteLine("Fin");
			};

			j.correr(7);
			j.correr(7);
			j.descansar(5);
			j.correr(7);
			if (!j.cansado()) {
				Console.WriteLine("Vuelta 2 completa");
			} else {
				Console.WriteLine("Fin");
			};

			j.correr(7);
			j.correr(7);
			j.descansar(5);
			j.correr(7);
			if (!j.cansado()) {
				Console.WriteLine("Vuelta 3 completa");
			} else {
				Console.WriteLine("Fin");
			};
		}

		public static void Main(string[] args) {
			IJugador.IJugador a = new JugadorAmateur.JugadorAmateur();
			maraton(a);

			IJugador.IJugador b = new JugadorAmateur.JugadorAmateur();
			maraton(b);
		}
	}
}
