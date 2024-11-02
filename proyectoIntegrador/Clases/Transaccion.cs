namespace proyectoIntegrador
{
    internal class Transaccion
    {
        public int IdCliente { get; set; }
        public Transaccion() { }
        public Transaccion(int idCliente)
        {
            IdCliente = idCliente;
        }
    }
}