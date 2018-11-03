using System;
using Studying.Application.Extensions;
using Studying.Domain.Studying;

namespace Studying.Application.Studying
{
    public class VisitConferencesStudyingDecorator : StudyingBaseDecorator
    {
        private static Action VisitConferenceStudingStrategy = () => Console.WriteLine("Visiting conference...");
        
        public VisitConferencesStudyingDecorator(IStudying studying) : base(studying)
        {
        }

        public override Action GetStudingStategy()
        {
            var baseStudingStrategy = base.GetStudingStategy();

            var mergedStudingStrategy = baseStudingStrategy.Merge(VisitConferenceStudingStrategy);

            return mergedStudingStrategy;
        }
    }
}