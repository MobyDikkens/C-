namespace Studying.Domain.Core
{
    public interface IEntity<TKey>
    {
        TKey Id { get; }
    }
}