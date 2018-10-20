using System;
using Smartphone.Domain.Entities.Abstract;
using Smartphone.Domain.Entities.Camera;
using Smartphone.Domain.Entities.OperationSystem;
using Smartphone.Domain.Entities.Processor;

namespace Smartphone.Domain.Aggregates
{
    public abstract class Smartphone : Entity<Guid>
    {
        public string Name { get; }
        public OperationSystem System { get; }
        public Processor Processor { get; }
        public Camera Camera { get; }
        
        public Smartphone(
            Guid id,
            string name,
            OperationSystem system,
            Processor processor,
            Camera camera) : base(id)
        {
            if(id == Guid.Empty)
                throw new ArgumentException();
            
            if(string.IsNullOrEmpty(name))
                throw new ArgumentException(nameof(name));

            Name = name;
            System = system ?? throw new ArgumentNullException(nameof(system));
            Processor = processor ?? throw new ArgumentNullException(nameof(processor));
            Camera = camera ?? throw new ArgumentNullException(nameof(camera));
        }
    }
}