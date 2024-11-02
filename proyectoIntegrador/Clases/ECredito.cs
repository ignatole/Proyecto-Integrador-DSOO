namespace proyectoIntegrador
{
    internal class ECredito : Transaccion
    {
        public int CantCreditos { get; set; }
        public ECredito(int idCliente, int cantCreditos) : base(idCliente)
        {
            CantCreditos = cantCreditos;
        }
        public ECredito() { }
    }
}