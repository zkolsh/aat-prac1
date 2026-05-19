namespace Vehiculo {
	class Bicicleta : IVehiculo {
		private float pos = 0.0F;

		public void mover(TimeSpan tiempo) {
			pos += (float)(tiempo.TotalSeconds) * 10.0F;
		}
	
		public float posicion() {
			return pos;
		}

		public void reiniciarPosicion() {
			pos = 0.0F;
		}
	}
}
