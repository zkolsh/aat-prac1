namespace NBanco {
	public class CuentaBancaria {
		protected int saldo;

		public virtual bool depositar(int monto) {
			if (monto <= 0) return false;
			saldo += monto;
			return true;
		}

		public virtual bool extraer(int monto) {
			return false;
		}

		public void mostrarSaldo() {
			Console.WriteLine(saldo);
		}
	}
}
