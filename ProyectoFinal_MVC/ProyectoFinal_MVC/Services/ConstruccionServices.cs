using ProyectoFinal_MVC.Data;
using ProyectoFinal_MVC.Models;

namespace ProyectoFinal_MVC.Services
{
    public class ConstruccionServices
    {
        private readonly IRepository repository;
        public ConstruccionServices(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task Crear(Construccion construccion)
        {
            if (construccion is null)
                throw new Exception("Construccion es Nula");

            await this.repository.Save(construccion);
            await this.repository.Commit();
        }
        public async Task<List<Construccion>> GetAllConstruccion()
        {
            return await this.repository.GetAll<Construccion>();
        }
    }
}
