namespace Formas {
	public class Triangulo : IForma {
		private float basef { get; set; }
		private float alturaf { get; set; }

		public Triangulo(float basef, float alturaf) {
			this.basef = basef;
			this.alturaf = alturaf;
		}

		public float CalcularArea() {
			return (basef * alturaf) / 2.0f;
		}

		public float CalcularPerimetro() {
			float hip = (float)(Math.Sqrt(basef * basef + alturaf * alturaf));
			return 2 * hip + basef;
		}

		public void MostrarInformacion() {
			Console.WriteLine($"Tirangulo: Área = {CalcularArea()}, Perímetro = {CalcularPerimetro()}");
		}
	}
}
