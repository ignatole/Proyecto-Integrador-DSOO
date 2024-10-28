using System;

namespace proyectoIntegrador
{
    internal class EPago
    {
        private int id_pago;
        private int id_socio;
        private DateTime fecha_vencimiento;
        private bool pagada;
        private DateTime fecha_cuota;
        private string? medio_pago;
        private decimal monto; 

        public int Id_pago { get { return id_pago; } set { id_pago = value; } }
        public int Id_socio { get { return id_socio; } set { id_socio = value; } }
        public DateTime Fecha_vencimiento { get { return fecha_vencimiento; } set { fecha_vencimiento = value; } }
        public bool Pagada { get { return pagada; } set { pagada = value; } }
        public DateTime Fecha_cuota { get { return fecha_cuota; } set { fecha_cuota = value; } }
        public string? Medio_pago { get { return medio_pago; } set { medio_pago = value; } }
        public decimal Monto { get { return monto; } set { monto = value; } } 

        public EPago(int id_pago, int id_socio, DateTime fecha_cuota, DateTime fecha_vencimiento, bool pagada, string medio_pago, decimal monto)
        {
            this.id_pago = id_pago;
            this.id_socio = id_socio;
            this.fecha_cuota = fecha_cuota;
            this.fecha_vencimiento = fecha_vencimiento;
            this.pagada = pagada;
            this.medio_pago = medio_pago;
            this.monto = monto; 
        }

        public EPago() { }
    }
}
