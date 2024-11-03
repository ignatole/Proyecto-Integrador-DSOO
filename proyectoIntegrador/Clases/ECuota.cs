namespace proyectoIntegrador.Transacciones
{
    internal class ECuota : Transaccion
    {
        public int IdPago { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? MedioPago { get; set; }
        public decimal Monto { get; set; }
        public bool TipoCuota { get; set; }
        public int IdCliente { get; set; }
        public ECuota(int id_pago, DateTime fecha_pago, DateTime? fecha_vencimiento, string medio_pago, decimal monto, bool tipo_cuota, int id_cliente)
        {
            IdPago = id_pago;
            FechaPago = fecha_pago;
            FechaVencimiento = fecha_vencimiento;
            MedioPago = medio_pago;
            Monto = monto;
            TipoCuota = tipo_cuota;
            IdCliente = id_cliente;
        }
        public ECuota() { }
        public int GetIdCuota() { return IdPago; }
    }
}
