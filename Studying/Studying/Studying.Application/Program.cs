using System;
using Studying.Application.Institutions;
using Studying.Application.Student;
using Studying.Application.Studying;
using Studying.Domain.Studying;

namespace Studying.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudying studying = new StudyingBase();
            studying = new ReadBooksStudyingDecorator(studying);
            studying = new VisitConferencesStudyingDecorator(studying);
            
            var kpi = new KPI(Guid.NewGuid(), new []{studying}, 100, student => student.TotalPoints > 60);

            var student1 = new UniversityStudent();
            
            kpi.Enter(student1);
            
            kpi.TickTerm();
        }
    }
}