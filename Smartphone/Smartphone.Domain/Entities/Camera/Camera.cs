using System;
using Smartphone.Domain.Entities.Abstract;
using Smartphone.Domain.ValueObjects;

namespace Smartphone.Domain.Entities.Camera
{
    public class Camera : Entity<Guid>
    {
        public NumberRange Zoom { get; }
        
        public int Megapixels { get; }
        
        public Camera(
            Guid id,
            NumberRange zoom,
            int megapixels) : base(id)
        {
            if(id == Guid.Empty)
                throw new ArgumentException(nameof(id));
            
            if(megapixels <= 0)
                throw new ArgumentException(nameof(megapixels));

            Zoom = zoom;
            Megapixels = megapixels;
        }
    }
}