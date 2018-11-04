using System;
using Studying.Application.Extensions;
using Studying.Domain.Studying;

namespace Studying.Application.Studying
{
    public class ReadBooksStudyingDecorator : StudyingBaseDecorator
    {
        private static Action ReadBooksStudingStrategy = () => Console.WriteLine("Reading books...");
        private static int ReadBooksStudyingProfit = 50;
        
        public ReadBooksStudyingDecorator(IStudying studying) : base(studying)
        {
        }

        public override int Profit => ReadBooksStudyingProfit;
        protected override Action StudyingStrategy => ReadBooksStudingStrategy;
    }
}