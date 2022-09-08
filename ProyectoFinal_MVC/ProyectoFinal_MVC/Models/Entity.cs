namespace ProyectoFinal_MVC.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        //for ef
        protected Entity()
        {

        }
        protected Entity(Guid id)
        {
            Id = id;
        }
    }
}
