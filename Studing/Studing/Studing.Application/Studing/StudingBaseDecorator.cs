using System;
using Studing.Domain.Studing;

namespace Studing.Application.Studing
{
    public abstract class StudingBaseDecorator : IStuding
    {
        private IStuding _studingStrategy;

        public StudingBaseDecorator(IStuding studing)
        {
            _studingStrategy = studing ?? throw new ArgumentNullException(nameof(studing));
        }

        public virtual Action GetStudingStategy()
        {
            return _studingStrategy.GetStudingStategy();
        }
    }
}