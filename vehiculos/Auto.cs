namespace Vehiculo {
	class Auto : IVehiculo {
		private float pos = 0.0f;
		private float vel = 40.0f;

		public void mover(TimeSpan tiempo) {
			this.pos += tiempo.TotalSeconds * this.vel;
		}
	
		public float posicion() {
			return this.pos;
		}

		public void reiniciarPosicion() {
			this.pos = 0.0f;
		}

		public void establecerVelocidad(float v) {
			this.vel = v;
		}
	}
}
