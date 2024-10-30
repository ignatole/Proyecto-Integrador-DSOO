using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoIntegrador
{
    internal class EActividad
    {
        private int id_cliente;
        private int id_actividad;
        public int IdCliente { get { return id_cliente; } set { id_cliente = value; } }
        public int IdActividad { get { return id_actividad; } set { id_actividad = value; } }
        public EActividad() { }
    }
}
