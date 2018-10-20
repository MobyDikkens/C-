using System;
using Smartphone.Domain.Entities.Camera;
using Smartphone.Domain.Entities.OperationSystem;
using Smartphone.Domain.Entities.Processor;

namespace Smartphone.Domain.Aggregates
{
    public class Samsung : Smartphone
    {
        private const string SamsungName = "Samsung";


        public Samsung(
            Guid id, 
            OperationSystem system, 
            Processor processor, 
            Camera camera) : base(id, SamsungName, system, processor, camera)
        {
        }
    }
}