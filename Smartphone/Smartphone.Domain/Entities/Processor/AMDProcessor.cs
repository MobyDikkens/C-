using System;
using Smartphone.Domain.ValueObjects;

namespace Smartphone.Domain.Entities.Processor
{
    public class AMDProcessor : Processor
    {
        private const string AMDName = "AMD";
        
        public AMDProcessor(
            Guid id, 
            int generation, 
            FloatingNumberRange frequency) : base(id, AMDName, generation, frequency)
        {
        }
    }
}