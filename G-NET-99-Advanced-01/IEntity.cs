namespace G_NET_99_Advanced_01
{
    //Q12
    public interface IEntity
    {
        int Id { get; set; }
    }
    public class EntityManager<T> where T : class, IEntity, new()
    {
        public T CreateEntity(int id)
        {
            T entity = new T(); // new() constraint
            entity.Id = id;     // IEntity constraint
            return entity;
        }
    }
}
