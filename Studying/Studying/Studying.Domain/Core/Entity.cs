namespace Studying.Domain.Core
{
    public abstract class Entity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; }

        public Entity(TKey id)
        {
            Id = id;
        }
    }
}