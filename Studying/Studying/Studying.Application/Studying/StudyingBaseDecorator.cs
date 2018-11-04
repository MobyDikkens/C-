using System;
using Studying.Application.Extensions;
using Studying.Domain.Studying;

namespace Studying.Application.Studying
{
    public abstract class StudyingBaseDecorator : IStudying
    {
        private IStudying _studying;
        
        public StudyingBaseDecorator(IStudying studying)
        {
            _studying = studying ?? throw new ArgumentNullException(nameof(studying));
            Profit += studying.Profit;
        }
        
        protected abstract Action StudyingStrategy { get; }
        
        public virtual int Profit { get; }
        
        public Action GetStudingStategy()
        {
            var baseStudingStrategy = _studying.GetStudingStategy();

            var mergedStudingStrategy = baseStudingStrategy.Merge(StudyingStrategy);

            return mergedStudingStrategy;
        }
    }
}