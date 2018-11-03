using System;
using Studing.Application.Extensions;
using Studing.Domain.Studing;

namespace Studing.Application.Studing
{
    public class ReadBooksStudingDecorator : StudingBaseDecorator
    {
        private static Action ReadBooksStudingStrategy = () => Console.WriteLine("Reading books...");
        
        public ReadBooksStudingDecorator(IStuding studing) : base(studing)
        {
        }

        public override Action GetStudingStategy()
        {
            var baseStudingStrategy = base.GetStudingStategy();

            var mergedStudingStrategy = baseStudingStrategy.Merge(ReadBooksStudingStrategy);

            return mergedStudingStrategy;
        }
    }
}