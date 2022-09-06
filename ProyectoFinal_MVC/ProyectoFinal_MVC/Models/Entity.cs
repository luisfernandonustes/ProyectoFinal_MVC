namespace ProyectoFinal_MVC.Models
{
    public class Entity
    {
        public Guid Id { get; set; }
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
