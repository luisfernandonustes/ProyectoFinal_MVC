namespace ProyectoFinal_MVC.Models
{
    public class Construccion : Entity
    {
        public string Name { get; private set; }
        public string LugarDeConstruccion { get; private set; }
        public string Tipo { get; private set; }
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaFinal { get; private set; }
        public Guid EmpresaConstructoraId { get; private set; }
        public EmpresaConstructora EmpresaConstructora { get; private set; }
        ///<sumary>
        ///for ef
        ///</sumay>
        private Construccion() : base()
        {

        }
        private Construccion(Guid id, string name, string lugarDeConstruccion, string tipo, DateTime fechaInicio, DateTime fechaFinal, 
            Guid empresaConstructoraId) : base(id)
        {
            Name = name;
            LugarDeConstruccion = lugarDeConstruccion;
            Tipo = tipo;
            FechaInicio = fechaInicio;
            FechaFinal = fechaFinal;
            EmpresaConstructoraId = empresaConstructoraId;
        }
        public static Construccion Build(Guid id, string name, string lugarDeConstruccion, string tipo, DateTime fechaInicio, 
            DateTime fechaFinal, Guid empresaConstructoraId)
        {
            return new Construccion(id, name, lugarDeConstruccion, tipo, fechaInicio, fechaFinal, empresaConstructoraId);
        }
    }
}
