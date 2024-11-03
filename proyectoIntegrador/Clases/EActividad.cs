namespace proyectoIntegrador
{
    internal class EActividad : Transaccion
    {
        public int IdActividad { get; set; }

        public EActividad(int idCliente, int idActividad) : base(idCliente)
        {
            IdActividad = idActividad;
        }

        public EActividad() { }
    }
}