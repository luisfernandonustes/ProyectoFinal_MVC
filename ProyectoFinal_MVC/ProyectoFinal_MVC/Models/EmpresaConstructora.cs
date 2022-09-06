namespace ProyectoFinal_MVC.Models
{
    public class EmpresaConstructora : Entity
    {
        public string Name { get; private set; }
        public string Direccion { get; private set; }
        public string TipoDeConstruccion { get; private set; }
        public List<Trabajador> Trabajadores { get; private set; }
        ///<sumary>
        ///for ef
        ///</sumay>
        private EmpresaConstructora() : base()
        {

        }
        private EmpresaConstructora(Guid id, string name, string direccion, string tipoDeConstruccion) : base(id)
        {
            Name = name;
            Direccion = direccion;
            TipoDeConstruccion = tipoDeConstruccion;
        }
        public EmpresaConstructora Build(Guid id, string name, string direccion, string tipoDeConstruccion)
        {
            return new EmpresaConstructora(id, name , direccion, tipoDeConstruccion);
        }
    }
}
