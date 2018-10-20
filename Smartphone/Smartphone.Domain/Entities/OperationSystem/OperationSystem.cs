using System;
using Smartphone.Domain.Entities.Abstract;

namespace Smartphone.Domain.Entities.OperationSystem
{
    public abstract class OperationSystem : Entity<string>
    {
        public string Name { get; }
        public string Version { get; }

        protected OperationSystem(
            string name, 
            string version) : base(name + version)
        {
            Name = !string.IsNullOrEmpty(name) ? name : throw new ArgumentException(nameof(name));
            Version = !string.IsNullOrEmpty(version) ? version : throw new ArgumentException(nameof(version));
        }
    }
}