namespace ProyectoFinal_MVC.Models
{
    public class EmpresaConstructora : Entity
    {
        public string Name { get; private set; }
        public string Direccion { get; private set; }
        public string Tipo { get; private set; }
        public List<Trabajador> Trabajadores { get; private set; }
        public List<Construccion> Construcciones { get; private set; }
        ///<sumary>
        ///for ef
        ///</sumay>
        private EmpresaConstructora() : base()
        {

        }
        private EmpresaConstructora(Guid id, string name, string direccion, string tipo) : base(id)
        {
            Name = name;
            Direccion = direccion;
            Tipo = tipo;
        }
        public static EmpresaConstructora Build(Guid id, string name, string direccion, string tipo)
        {
            return new EmpresaConstructora(id, name , direccion, tipo);
        }
    }
}
