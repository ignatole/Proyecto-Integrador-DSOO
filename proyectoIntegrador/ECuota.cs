using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoIntegrador
{
    internal class ECuota
    {
        private int id_pago;
        private DateTime fecha_pago;
        private DateTime? fecha_vencimiento; // Puede ser null
        private string? medio_pago;
        private decimal monto;
        private bool tipo_cuota; // true para mensual, false para actividad
        private int id_cliente;

        // GET - SET
        public int IdPago { get { return id_pago; } set { id_pago = value; } }
        public DateTime FechaPago { get { return fecha_pago; } set { fecha_pago = value; } }
        public DateTime? FechaVencimiento { get { return fecha_vencimiento; } set { fecha_vencimiento = value; } }
        public string? MedioPago { get { return medio_pago; } set { medio_pago = value; } }
        public decimal Monto { get { return monto; } set { monto = value; } }
        public bool TipoCuota { get { return tipo_cuota; } set { tipo_cuota = value; } }
        public int IdCliente { get { return id_cliente; } set { id_cliente = value; } }

        // Constructor básico
        public ECuota(int id_pago, DateTime fecha_pago, DateTime? fecha_vencimiento, string medio_pago, decimal monto, bool tipo_cuota, int id_cliente)
        {
            this.id_pago = id_pago;
            this.fecha_pago = fecha_pago;
            this.fecha_vencimiento = fecha_vencimiento;
            this.medio_pago = medio_pago;
            this.monto = monto;
            this.tipo_cuota = tipo_cuota;
            this.id_cliente = id_cliente;
        }

        // Constructor sin parámetros
        public ECuota() { }

        // Método que retorna el ID de la cuota
        public int GetIdCuota() { return id_pago; }
    }
}
