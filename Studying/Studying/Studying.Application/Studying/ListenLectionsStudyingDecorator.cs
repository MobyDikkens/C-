using System;
using Studying.Application.Extensions;
using Studying.Domain.Studying;

namespace Studying.Application.Studying
{
    public class ListenLectionsStudyingDecorator : StudyingBaseDecorator
    {
        private static Action ListenLectionsStudingStrategy = () => Console.WriteLine("Listen lections...");
        private static int ListenLectionsStudyingProfit = 35;
        
        public ListenLectionsStudyingDecorator(IStudying studying) : base(studying)
        {
        }

        protected override Action StudyingStrategy => ListenLectionsStudingStrategy;
        public override int Profit => ListenLectionsStudyingProfit;
    }
}