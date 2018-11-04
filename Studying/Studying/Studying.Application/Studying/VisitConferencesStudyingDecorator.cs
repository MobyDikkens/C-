using System;
using Studying.Application.Extensions;
using Studying.Domain.Studying;

namespace Studying.Application.Studying
{
    public class VisitConferencesStudyingDecorator : StudyingBaseDecorator
    {
        private static Action VisitConferenceStudingStrategy = () => Console.WriteLine("Visiting conference...");
        private static int VisitConferenceStudingProfit = 100;
        
        public VisitConferencesStudyingDecorator(IStudying studying) : base(studying)
        {
        }

        protected override Action StudyingStrategy => VisitConferenceStudingStrategy;
        public override int Profit => VisitConferenceStudingProfit;
    }
}