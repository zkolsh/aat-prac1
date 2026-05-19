namespace IJugador {
	public interface IJugador {
		bool correr(int minutos);
		bool cansado();
		void descansar(int minutos);
	}
}
