namespace NBanco {
	public class CuentaCorriente: CuentaBancaria {
		private int limite;

		public CuentaCorriente(int lim) {
			limite = lim;
		}

		public override bool extraer(int monto) {
			if (saldo - monto <= -limite) return false;
			saldo -= monto;
			return true;
		}
	}
}
