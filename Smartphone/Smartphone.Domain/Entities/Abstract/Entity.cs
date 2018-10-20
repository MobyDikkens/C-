namespace Smartphone.Domain.Entities.Abstract
{
    public abstract class Entity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; }

        public Entity(TKey id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            return (obj is IEntity<TKey> entity) 
                   && entity.Id.GetHashCode() == GetHashCode();
        }

        public override string ToString()
        {
            return GetHashCode().ToString();
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}