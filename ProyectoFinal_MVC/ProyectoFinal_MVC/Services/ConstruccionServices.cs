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
        public async Task<Construccion> Getobj(Guid id)
        {
            return await this.repository.Getobj<Construccion>(id);
        }
        public async Task<List<Construccion>> GetAllConstruccion()
        {
            return await this.repository.GetAll<Construccion>();
        }
        public async Task Update(Construccion construccion)
        {
            this.repository.Update(construccion);
            await this.repository.Commit();
        }
        public async Task Delete(Construccion construccion)
        {
            this.repository.Delete(construccion);
            await this.repository.Commit();
        }
    }
}
