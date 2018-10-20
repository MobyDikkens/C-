namespace Smartphone.Domain.Factories
{
    public interface ISmartphoneFactory
    {
        Aggregates.Smartphone CreateOne();
    }
}