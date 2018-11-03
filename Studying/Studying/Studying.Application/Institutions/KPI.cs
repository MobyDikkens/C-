using System;
using System.Collections.Generic;
using Studying.Domain.Institution;
using Studying.Domain.Student;

namespace Studying.Application.Institutions
{
    public class KPI : Institution
    {
        private static Guid KPIType = Guid.NewGuid();
        
        private List<IStudent> _students;

        public override Guid InstitutionType => KPIType;
        public override IReadOnlyCollection<IStudent> Students => _students;

        public KPI(Guid id) : base(id)
        {
            if(id == Guid.Empty)
                throw new ArgumentException(nameof(id));
            
            _students = new List<IStudent>();
        }
        
        public override void Enter(IStudent student)
        {
            if(student == null)
                throw new ArgumentNullException(nameof(student));
            
            _students.Add(student);
        }

        public override IReadOnlyCollection<IStudent> Graduate()
        {
            foreach (var student in _students)
            {
                var graduationCertificate = CreateCertificate();
                
                student.Graduate(graduationCertificate);
            }

            return _students;
        }
    }
}