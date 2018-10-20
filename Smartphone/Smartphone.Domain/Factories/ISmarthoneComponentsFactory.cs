using Smartphone.Domain.Entities.Camera;
using Smartphone.Domain.Entities.OperationSystem;
using Smartphone.Domain.Entities.Processor;

namespace Smartphone.Domain.Factories
{
    public interface ISmarthoneComponentsFactory
    {
        Camera CreateCamera();
        OperationSystem GetOperationSystem();
        Processor CreateProcessor();
    }
}