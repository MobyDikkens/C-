using System;
using Smartphone.Domain.ValueObjects;

namespace Smartphone.Domain.Entities.Camera
{
    public class DigitalCamera : Camera
    {
        public DigitalCamera(
            Guid id, 
            NumberRange zoom, 
            int megapixels) : base(id, zoom, megapixels)
        {
        }
    }
}