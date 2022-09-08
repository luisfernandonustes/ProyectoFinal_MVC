using ProyectoFinal_MVC.Data;
using ProyectoFinal_MVC.Models;

namespace ProyectoFinal_MVC.Services
{
    public class TrabajadorServices
    {
        private readonly IRepository repository;
        public TrabajadorServices(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task Crear(Trabajador trabajador)
        {
            if (trabajador is null)
                throw new Exception("Trabajador es Nulo");

            await this.repository.Save(trabajador);
            await this.repository.Commit();
        }
        public async Task<List<Trabajador>> GetAllTrabajador()
        {
            return await this.repository.GetAll<Trabajador>();
        }
    }
}
