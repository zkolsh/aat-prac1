namespace Cartas {
	class Mazo {
		private List<Carta> m_cartas = new List<Carta>();

		public Mazo() {
			Palo[] ps = {Palo.Spades, Palo.Clubs, Palo.Hearts, Palo.Diamonds};
			Numero[] ns = {
				Numero.N1,
				Numero.N2,
				Numero.N3,
				Numero.N4,
				Numero.N5,
				Numero.N6,
				Numero.N7,
				Numero.N8,
				Numero.N9,
				Numero.K,
				Numero.Q,
				Numero.J,
				Numero.A,
			};

			foreach (Palo p in ps) {
				foreach (Numero n in ns) {
					m_cartas.Add(new Carta(p, n));
				}
			}
		}

		public void barajar() {
			Random rand = new Random();

			for (int i = m_cartas.Count - 1; i > 0; i--) {
				int j = rand.Next(i + 1);

				(m_cartas[i], m_cartas[j]) = (m_cartas[j], m_cartas[i]);
			}
		}

		public Carta robarCarta() {
			Carta c = m_cartas.Last();
			m_cartas.RemoveAt(m_cartas.Count - 1);
			return c;
		}

		public int cuantasCartasQuedan() {
			return m_cartas.Count;
		}
	}
}
