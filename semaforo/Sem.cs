namespace Sem {
	public class Semaforo {
		public enum Color {
			Rojo,
			RojoAmarillo,
			Amarillo,
			Verde,
		}

		internal enum Comportamiento {
			Activo,
			Intermitente
		}

		private Color _color;
		private TimeSpan _time;
		private Comportamiento _behavior;

		public Semaforo(Color color) {
			this._color = color;

			switch (color) {
			case Color.Rojo:
				this._time = TimeSpan.Zero;
				break;

			case Color.RojoAmarillo:
				this._time = TimeSpan.FromSeconds(30);
				break;

			case Color.Verde:
				this._time = TimeSpan.FromSeconds(32);
				break;

			case Color.Amarillo:
				this._time = TimeSpan.FromSeconds(42);
				break;
			}
		}

		public void pasoDelTiempo(TimeSpan t) {
			this._time += t;

			switch (this._behavior) {
			case Comportamiento.Activo:
				pasoActivo();
				break;

			case Comportamiento.Intermitente:
				pasoIntermitente();
				break;
			}
		}

		public Color mostrarColor() {
			return this._color;
		}

		public void ponerEnIntermitente() {
			this._behavior = Comportamiento.Intermitente;
			pasoDelTiempo(TimeSpan.Zero);
		}

		public void sacarDeIntermitente() {
			this._behavior = Comportamiento.Activo;
			pasoDelTiempo(TimeSpan.Zero);
		}

		private void pasoActivo() {
			int interval = (int)(this._time.TotalSeconds) % (30 + 2 + 20 + 2);

			if (interval < 30) {
				this._color = Color.Rojo;
			} else if (interval < 32) {
				this._color = Color.RojoAmarillo;
			} else if (interval < 52) {
				this._color = Color.Verde;
			} else {
				this._color = Color.Amarillo;
			}
		}

		private void pasoIntermitente() {
			int interval = (int)(this._time.TotalSeconds) % 2;
			if (interval < 1) {
				this._color = Color.Amarillo;
			} else {
				this._color = Color.Rojo;
			}
		}
	}
}
