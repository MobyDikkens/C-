using System;
using Studing.Application.Extensions;
using Studing.Domain.Studing;

namespace Studing.Application.Studing
{
    public class ListenLectionsStudingDecorator : StudingBaseDecorator
    {
        private static Action ListenLectionsStudingStrategy = () => Console.WriteLine("Listen lections...");
        
        public ListenLectionsStudingDecorator(IStuding studing) : base(studing)
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