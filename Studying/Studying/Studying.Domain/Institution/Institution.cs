using System;
using System.Collections.Generic;
using System.Linq;
using Studying.Domain.Core;
using Studying.Domain.Graduation;
using Studying.Domain.Student;
using Studying.Domain.Studying;

namespace Studying.Domain.Institution
{
    public abstract class Institution : Entity<Guid>, IInstitution
    {
        private readonly int _daysInTerm;
        private readonly Predicate<IStudent> _graduationPredicate;
        private readonly List<IStudent> _students;
        private IReadOnlyCollection<IStudying> StudyingStrategies { get; }
        
        public Institution(
            Guid id,
            IReadOnlyCollection<IStudying> studyingStrategies,
            int daysInTerm,
            Predicate<IStudent> graduationPredicate) : base(id)
        {
            if(daysInTerm <= 0)
                throw new ArgumentException(nameof(daysInTerm));
            
            if(graduationPredicate == null)
                throw new ArgumentNullException(nameof(graduationPredicate));
            
            StudyingStrategies = studyingStrategies;
            _daysInTerm = daysInTerm;
            _graduationPredicate = graduationPredicate;
            
            _students = new List<IStudent>();
        }     

        public IReadOnlyCollection<IStudent> Students => _students;
        
        public void Enter(IStudent student)
        {
            _students.Add(student);
        }

        public IReadOnlyCollection<IStudent> Graduate()
        {
            var graduatedStudents = _students.Where(student => _graduationPredicate(student));

            foreach (var graduatedStudent in graduatedStudents)
            {
                var graduationCertificate = CreateCertificate(Id);
                
                graduatedStudent.Graduate(graduationCertificate);
            }

            _students.RemoveAll(_graduationPredicate);

            return graduatedStudents.ToList();
        }

        public void TickTerm()
        {
            for (int day = 0; day < _daysInTerm; day++)
            {
                foreach (var student in Students)
                {
                    foreach (var studingStrategy in StudyingStrategies)
                    {
                        student.Study(studingStrategy);
                    }
                }
            }
        }
              
        private IGraduationCertificate CreateCertificate(Guid uniqId)
        {
            if(uniqId == Guid.Empty)
                throw new ArgumentException(nameof(uniqId));
            
            return new GraduationCertificate(uniqId, Id);
        }
        
        private class GraduationCertificate : IGraduationCertificate
        {
            public Guid Id { get; }
            public Guid InstitutionId { get; }

            public GraduationCertificate(Guid id, Guid type)
            {
                Id = id;
                InstitutionId = type;
            }
        }
    }
}