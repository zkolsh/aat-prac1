namespace NBanco {
	public class CajaDeAhorro: CuentaBancaria {
		public override bool extraer(int monto) {
			if (saldo - monto <= 0) return false;
			saldo -= monto;
			return true;
		}
	}
}
