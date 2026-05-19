namespace Cartas {
	public enum Palo {
		Spades,
		Clubs,
		Hearts,
		Diamonds
	}

	public enum Numero {
		N1,
		N2,
		N3,
		N4,
		N5,
		N6,
		N7,
		N8,
		N9,
		K,
		Q,
		J,
		A
	}

	public class Carta {
		public Carta (Palo p, Numero n) {
			palo = p;
			numero = n;
		}

		public Palo palo{get;}
		public Numero numero{get;}

		public override String ToString() {
			return palo.ToString() + " " + numero.ToString();
		}
	}
}
