namespace ProyectoFinal_MVC.Models
{
    public class Trabajador : Entity
    {
        public string Name { get; private set; }
        public string DocumentoIdentidad { get; private set; }
        public string Profesion { get; private set; }
        public DateTime FechaDeNacimiento { get; private set; }
        public Guid EmpresaConstructoraId { get; private set; }
        public EmpresaConstructora EmpresaConstructora { get; private set; }
        ///<summary>
        ///for
        /// </summary>
        private Trabajador() : base()
        {

        }
        private Trabajador(Guid id, string name, string documentoIdentidad, string profesion, DateTime fechaDeNacimiento, Guid empresaConstructoraId) : base(id)
        {
            Name = name;
            DocumentoIdentidad = documentoIdentidad;
            Profesion = profesion;
            FechaDeNacimiento = fechaDeNacimiento;
            EmpresaConstructoraId = empresaConstructoraId;
        }
        public Trabajador Build(Guid id, string name, string documentoIdentidad, string profesion, DateTime fechaDeNacimiento, Guid empresaConstructoraId)
        {
            return new Trabajador(id, name, documentoIdentidad, profesion, fechaDeNacimiento, empresaConstructoraId);
        }
    }
}
