namespace Cartas {
	public class Mano {
		private List<Carta> m_cartas = new List<Carta>();

		public void recibirCarta(Carta c) {
			m_cartas.Add(c);
		}

		public void mostrarMano() {
			Console.WriteLine(string.Join(", ", m_cartas));
		}

		public int cantidadDeCartas() {
			return m_cartas.Count;
		}
	}
}
