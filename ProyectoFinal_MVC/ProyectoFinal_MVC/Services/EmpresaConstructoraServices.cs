using ProyectoFinal_MVC.Data;
using ProyectoFinal_MVC.Models;

namespace ProyectoFinal_MVC.Services
{
    public class EmpresaConstructoraServices
    {
        private readonly IRepository repository;
        public EmpresaConstructoraServices(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task Crear(EmpresaConstructora empresaConstructora)
        {
            if (empresaConstructora == null)
                throw new Exception("Empresa Constuctora es Nula");
            await this.repository.Save(empresaConstructora);
            await this.repository.Commit();
        }
        public async Task<List<EmpresaConstructora>> GetAllEmpresaConstructora()
        {
            return await this.repository.GetAll<EmpresaConstructora>();
        }
        public async Task<EmpresaConstructora> Getobj(Guid id)
        {
            return await this.repository.Getobj<EmpresaConstructora>(id);
        }
        public async Task Update(EmpresaConstructora empresaConstructora)
        {
            this.repository.Update(empresaConstructora);
            await this.repository.Commit();
        }
        public async Task Delete(EmpresaConstructora empresaConstructora)
        {
            this.repository.Delete(empresaConstructora);
            await this.repository.Commit();
        }
    }
}
