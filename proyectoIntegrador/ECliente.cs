using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoIntegrador
{
    internal class ECliente
    {
        private int id_cliente; 
        private string? nombre; 
        private string? apellido; 
        private int dni; 
        private string? email; 
        private string? telefono;
        private DateTime fechaNac;
        private string? sexo;

        // GET - SET
        public string? Nombre { get { return nombre; } set { nombre = value; } }
        public string? Apellido { get { return apellido; } set { apellido = value; } }
        public string? Email { get { return email; } set { email = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public string? Telefono { get { return telefono; } set { telefono = value; } }
        public DateTime FechaNac { get { return fechaNac; } set { fechaNac = value; } }
        public string? Sexo { get { return sexo; } set { sexo = value; } }

        // Constructor basico
        public ECliente(int id_cliente, string nombre, string apellido, int dni, string email, string telefono, DateTime fechaNac, string sexo)
        {
            this.id_cliente = id_cliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni; 
            this.email = email;
            this.telefono = telefono;
            this.fechaNac = fechaNac;
            this.sexo = sexo;
        }
        // Constructor sin parametros
        public ECliente() { }

        //Metodo que retorna el id del cliente
        public int getId() { return id_cliente; }
    }
}
