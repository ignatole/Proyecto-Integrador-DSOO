namespace proyectoIntegrador
{
    internal class ECliente : Transaccion
    {
        public string? Nombre;
        public string? Apellido;
        public int Dni;
        public string? Email;
        public string? Telefono;
        public DateTime FechaNac;
        public string? Sexo;
        public bool AptoFisico;
        public ECliente(int idCliente, string nombre, string apellido, int dni, string email, string telefono, DateTime fechaNac, string sexo)
            : base(idCliente)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Email = email;
            Telefono = telefono;
            FechaNac = fechaNac;
            Sexo = sexo;
        }
        public ECliente() { }

        public int getId() { return IdCliente; }
    }
}