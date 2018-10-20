using System;
using Smartphone.Domain.Entities.Abstract;
using Smartphone.Domain.ValueObjects;

namespace Smartphone.Domain.Entities.Processor
{
    public class Processor : Entity<Guid>
    {
        public string Name { get; }
        public int Generation { get; }
        public FloatingNumberRange Frequency { get; }
        
        public Processor(
            Guid id,
            string name,
            int generation,
            FloatingNumberRange frequency) : base(id)
        {
            if(id == Guid.Empty)
                throw new ArgumentException();
            
            if(string.IsNullOrEmpty(name))
                throw new ArgumentException(nameof(name));
            
            if(generation <= 0)
                throw new ArgumentException(nameof(generation));

            Name = name;
            Frequency = frequency;
            Generation = generation;
        }
    }
}