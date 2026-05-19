namespace Formas {
	public class Circulo : IForma {
		private float radio { get; set; }

		public Circulo(float r) {
			this.radio = r;
		}

		public float CalcularArea() {
			return 3.1415f * radio * radio;
		}

		public float CalcularPerimetro() {
			return 3.1415f * 2.0f * radio;
		}

		public void MostrarInformacion() {
			Console.WriteLine($"Circulo: Área = {CalcularArea()}, Perímetro = {CalcularPerimetro()}");
		}
	}
}
