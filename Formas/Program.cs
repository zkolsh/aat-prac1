namespace Formas {
	internal class Program {
		static void Main(string[] args) {
			List<IForma> formas = new List<IForma>();
			formas.Add(new Triangulo(6, 7));
			formas.Add(new Cuadrado(4));
			formas.Add(new Circulo(9));
			formas.Add(new Rectangulo(11, 1));
			formas.Add(new Circulo(1));
			formas.Add(new Cuadrado(6));
			formas.Add(new Cuadrado(1));
			formas.Add(new Circulo(6));
			formas.Add(new Triangulo(2, 4));
			formas.Add(new Cuadrado(7));
			formas.Add(new Circulo(12));
			formas.Add(new Cuadrado(4));
			formas.Add(new Triangulo(8, 11));
			formas.Add(new Cuadrado(10));
			formas.Add(new Rectangulo(7, 3));
			formas.Add(new Triangulo(11, 1));
			formas.Add(new Cuadrado(2));

			Console.WriteLine(">>> Perimetros");
			foreach (IForma forma in formas) {
				Console.WriteLine(forma.CalcularPerimetro());
			}

			Console.WriteLine(">>> Áreas");
			foreach (IForma forma in formas) {
				Console.WriteLine(forma.CalcularArea());
			}
		}
	}
}
