namespace Smartphone.Domain.Entities.Abstract
{
    public interface IEntity<TKey>
    {
        TKey Id { get; }
    }
}