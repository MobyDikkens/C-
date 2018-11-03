using System;
using Studying.Application.Extensions;
using Studying.Domain.Studying;

namespace Studying.Application.Studying
{
    public class ReadBooksStudyingDecorator : StudyingBaseDecorator
    {
        private static Action ReadBooksStudingStrategy = () => Console.WriteLine("Reading books...");
        
        public ReadBooksStudyingDecorator(IStudying studying) : base(studying)
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