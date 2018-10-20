using System;
using Smartphone.Domain.ValueObjects;

namespace Smartphone.Domain.Entities.Camera
{
    public class AnalogueCamera : Camera
    {
        public AnalogueCamera(
            Guid id, 
            NumberRange zoom, 
            int megapixels) : base(id, zoom, megapixels)
        {
        }
    }
}