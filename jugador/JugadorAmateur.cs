namespace JugadorAmateur {
	public class JugadorAmateur: IJugador.IJugador {
		int tiempo;

		public bool correr(int minutos) {
			if (tiempo <= 20) {
				tiempo += minutos;
				return tiempo > 20;
			} else {
				return false;
			};
		}

		public bool cansado() {
			return tiempo > 20;
		}

		public void descansar(int minutos) {
			tiempo = Math.Max(0, tiempo - minutos);
		}
	}
}
