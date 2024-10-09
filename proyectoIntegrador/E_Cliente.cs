using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoIntegrador
{
    internal class E_Cliente
    {
        private int id_cliente; 
        private string? nombre; 
        private string? apellido; 
        private int dni; 
        private string? email; 
        private string? telefono;

        // GET - SET
        public string? Nombre { get { return nombre; } set { nombre = value; } }
        public string? Apellido { get { return apellido; } set { apellido = value; } }
        public string? Email { get { return email; } set { email = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public string? Telefono { get { return telefono; } set { telefono = value; } }

        // Constructor basico
        public E_Cliente(int id_cliente, string nombre, string apellido, int dni, string email, string telefono)
        {
            this.id_cliente = id_cliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni; 
            this.email = email;
            this.telefono = telefono;
        }

        //Metodo  que retorna el id del cliente
        public int getId() { return id_cliente; }
    }
}
