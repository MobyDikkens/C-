using System;
using Studying.Application.Extensions;
using Studying.Domain.Studying;

namespace Studying.Application.Studying
{
    public class ListenLectionsStudyingDecorator : StudyingBaseDecorator
    {
        private static Action ListenLectionsStudingStrategy = () => Console.WriteLine("Listen lections...");
        
        public ListenLectionsStudyingDecorator(IStudying studying) : base(studying)
        {
        }

        public override Action GetStudingStategy()
        {
            var baseStudingStrategy = base.GetStudingStategy();

            var mergedStudingStrategy = baseStudingStrategy.Merge(ListenLectionsStudingStrategy);

            return mergedStudingStrategy;
        }
    }
}