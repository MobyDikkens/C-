using System;
using Studying.Domain.Studying;

namespace Studying.Application.Studying
{
    public class StudyingBase : IStudying
    {
        private static Action StudyingStrategy = () => Console.WriteLine("Making tasks...");
        private static int KPIStudyingProfit = 50;
        
        public Action GetStudingStategy() => StudyingStrategy;

        public int Profit => KPIStudyingProfit;
    }
}