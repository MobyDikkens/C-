using System;
using Smartphone.Domain.Entities.Camera;
using Smartphone.Domain.Entities.OperationSystem;
using Smartphone.Domain.Entities.Processor;

namespace Smartphone.Domain.Aggregates
{
    public class Apple : Smartphone
    {
        private const string AppleName = "Apple";
        
        public Apple(
            Guid id, 
            OperationSystem system, 
            Processor processor, 
            Camera camera) : base(id, AppleName, system, processor, camera)
        {
        }
    }
}