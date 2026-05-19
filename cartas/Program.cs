namespace Cartas {
	class Program {
		public static void Main(String[] args) {
			Mazo mazo = new Mazo();
			mazo.barajar();
			Mano jugador1 = new Mano();
			Mano jugador2 = new Mano();

			for (int i = 0; i < 3; i++) {
				jugador1.recibirCarta(mazo.robarCarta());
				jugador2.recibirCarta(mazo.robarCarta());
			}

			jugador1.mostrarMano();
			jugador2.mostrarMano();

			Console.WriteLine(mazo.cuantasCartasQuedan());
		}
	}
}
