using System;
using Studing.Application.Extensions;
using Studing.Domain.Studing;

namespace Studing.Application.Studing
{
    public class VisitConferencesStudingDecorator : StudingBaseDecorator
    {
        private static Action VisitConferenceStudingStrategy = () => Console.WriteLine("Visiting conference...");
        
        public VisitConferencesStudingDecorator(IStuding studing) : base(studing)
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