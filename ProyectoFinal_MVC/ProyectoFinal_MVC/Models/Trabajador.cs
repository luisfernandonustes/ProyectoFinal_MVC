namespace ProyectoFinal_MVC.Models
{
    public class Trabajador : Entity
    {
        public string Name { get; private set; }
        public string DocumentoIdentidad { get; private set; }
        public string Profesion { get; private set; }
        public string TipoDeTrabajador { get; private set; }
        public DateTime FechaDeNacimiento { get; private set; }
        public Guid EmpresaConstructoraId { get; private set; }
        public EmpresaConstructora EmpresaConstructora { get; private set; }
        ///<summary>
        ///for
        /// </summary>
        private Trabajador() : base()
        {

        }
        private Trabajador(Guid id, string name, string documentoIdentidad, string profesion, string tipoDeTrabajador, DateTime fechaDeNacimiento, Guid empresaConstructoraId) : base(id)
        {
            Name = name;
            DocumentoIdentidad = documentoIdentidad;
            Profesion = profesion;
            TipoDeTrabajador = tipoDeTrabajador;
            FechaDeNacimiento = fechaDeNacimiento;
            EmpresaConstructoraId = empresaConstructoraId;
        }
        public static Trabajador Build(Guid id, string name, string documentoIdentidad, string profesion,string TipoDeTrabajador, DateTime fechaDeNacimiento, Guid empresaConstructoraId)
        {
            return new Trabajador(id, name, documentoIdentidad, profesion, TipoDeTrabajador, fechaDeNacimiento, empresaConstructoraId);
        }
    }
}
