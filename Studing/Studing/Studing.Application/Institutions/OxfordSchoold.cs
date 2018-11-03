using System;
using System.Collections.Generic;
using Studing.Domain.Institution;
using Studing.Domain.Student;

namespace Studing.Application.Institutions
{
    public class OxfordSchool : Institution
    {
        private static Guid OxfordSchoolType = Guid.NewGuid();
        
        private List<IStudent> _students;

        public override Guid InstitutionType => OxfordSchoolType;
        public override IReadOnlyCollection<IStudent> Students => _students;

        public OxfordSchool(Guid id) : base(id)
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