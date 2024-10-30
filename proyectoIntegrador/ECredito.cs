using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoIntegrador
{
    internal class ECredito
    {
        private int id_cliente;
        private int cant_creditos;
        public int IdCliente { get { return id_cliente; } set { id_cliente = value; } }
        public int CantCreditos { get { return cant_creditos; } set { cant_creditos = value; } }
        public ECredito(int id_cliente, int cant_creditos)
        {
            this.id_cliente = id_cliente;
            this.cant_creditos = cant_creditos;
        }
        public ECredito() { }
    }
}
