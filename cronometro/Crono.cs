namespace Crono {
	public class Cronometro {
		private int _min;
		private int _sec;

		public void reiniciar() {
			this._min = this._sec = 0;
		}

		public void incrementarTiempo() {
			this._sec++;
			while (this._sec > 59) {
				this._min++;
				this._sec -= 60;
			}
		}

		public string mostrarTiempo() {
			return (this._min.ToString() + " minutos, " + this._sec.ToString() + " segundos");
		}
	}
}
