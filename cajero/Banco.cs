namespace NBanco {
	public class Banco {
		private List<CuentaBancaria> m_cuentas = new List<CuentaBancaria>();

		public void agregarCuenta(CuentaBancaria cuenta) {
			m_cuentas.Append(cuenta);
		}

		public bool transferir(CuentaBancaria origen, CuentaBancaria destino, int monto) {
			if (monto <= 0) return false;

			int srcIndex = -1;
			int dstIndex = -1;
			for (int i = 0; i < m_cuentas.Count; i++) {
				if (m_cuentas[i] == origen) {
					srcIndex = i;
				}

				if (m_cuentas[i] == destino) {
					dstIndex = i;
				}
			}

			if (srcIndex == -1 || dstIndex == -1) return false;
			if (!origen.extraer(monto)) return false;
			if (!destino.depositar(monto)) return false;
			return true;
		}
	}
}
