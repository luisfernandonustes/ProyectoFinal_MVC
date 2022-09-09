using ProyectoFinal_MVC.Models;

namespace ProyectoFinal_MVC.Data
{
    public interface IRepository
    {
        public Task Save<T>(T obj) where T : Entity;
        public void Delete<T>(T obj) where T : Entity;
        public void Update<T>(T obj) where T : Entity;
        public Task<List<T>> GetAll<T>() where T : Entity;
        public Task<T> Getobj<T>(Guid id) where T : Entity;
        public Task Commit();
    }
}
