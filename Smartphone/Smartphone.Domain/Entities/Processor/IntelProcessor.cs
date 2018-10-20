using System;
using Smartphone.Domain.ValueObjects;

namespace Smartphone.Domain.Entities.Processor
{
    public class IntelProcessor : Processor
    {
        private const string IntelName = "Intel";
        
        public IntelProcessor(
            Guid id, 
            int generation, 
            FloatingNumberRange frequency) : base(id, IntelName, generation, frequency)
        {
        }
    }
}