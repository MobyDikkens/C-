using System;
using Smartphone.Domain.Entities.Camera;
using Smartphone.Domain.Entities.OperationSystem;
using Smartphone.Domain.Entities.Processor;
using Smartphone.Domain.Factories;
using Smartphone.Domain.ValueObjects;

namespace Smartphone.Application.Factories
{
    public class AppleSmartphoneComponentsFactory : ISmarthoneComponentsFactory
    {
        public Camera CreateCamera()
        {
            return new DigitalCamera(Guid.NewGuid(), new NumberRange(1, 10), 15);
        }

        public OperationSystem GetOperationSystem()
        {
            return new IOS("12.0");
        }

        public Processor CreateProcessor()
        {
            return new IntelProcessor(Guid.NewGuid(), 8, new FloatingNumberRange(2.5, 4.3));
        }
    }
}