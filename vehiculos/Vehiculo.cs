namespace Vehiculo {
	public interface IVehiculo {
		void mover(TimeSpan tiempo);
		float posicion();
		void reiniciarPosicion();
	}
}
