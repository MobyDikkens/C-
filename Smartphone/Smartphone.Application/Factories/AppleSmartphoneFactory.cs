using System;
using Smartphone.Domain.Aggregates;
using Smartphone.Domain.Factories;

namespace Smartphone.Application.Factories
{
    public class AppleSmartphoneFactory : ISmartphoneFactory
    {
        private readonly ISmarthoneComponentsFactory _smarthoneComponentsFactory;

        public AppleSmartphoneFactory(ISmarthoneComponentsFactory smarthoneComponentsFactory)
        {
            _smarthoneComponentsFactory = smarthoneComponentsFactory ??
                                          throw new ArgumentNullException(nameof(smarthoneComponentsFactory));
        }

        public Domain.Aggregates.Smartphone CreateOne()
        {
            var camera = _smarthoneComponentsFactory.CreateCamera();
            var operationSystem = _smarthoneComponentsFactory.GetOperationSystem();
            var processor = _smarthoneComponentsFactory.CreateProcessor();

            var appleSmartphone = new Apple(Guid.NewGuid(), operationSystem, processor, camera);

            return appleSmartphone;
        }
    }
}