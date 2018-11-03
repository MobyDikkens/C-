using System;
using Studying.Domain.Studying;

namespace Studying.Application.Studying
{
    public abstract class StudyingBaseDecorator : IStudying
    {
        private IStudying _studyingStrategy;

        public StudyingBaseDecorator(IStudying studying)
        {
            _studyingStrategy = studying ?? throw new ArgumentNullException(nameof(studying));
        }

        public virtual Action GetStudingStategy()
        {
            return _studyingStrategy.GetStudingStategy();
        }
    }
}