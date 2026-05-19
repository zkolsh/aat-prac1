namespace JugadorProfesional {
	public class JugadorProfesional: IJugador.IJugador {
		int tiempo;

		public bool correr(int minutos) {
			if (tiempo <= 40) {
				tiempo += minutos;
				return tiempo > 40;
			} else {
				return false;
			};
		}

		public bool cansado() {
			return tiempo > 40;
		}

		public void descansar(int minutos) {
			tiempo = Math.Max(0, tiempo - minutos);
		}
	}
}
