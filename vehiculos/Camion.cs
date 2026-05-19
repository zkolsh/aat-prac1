namespace Vehiculo {
	class Camion : IVehiculo {
		private float pos = 0.0F;

		public void mover(TimeSpan tiempo) {
			pos += (float)tiempo.TotalSeconds * 30.0F;
		}
	
		public float posicion() {
			return pos;
		}

		public void reiniciarPosicion() {
			pos = 0.0F;
		}
	}
}
