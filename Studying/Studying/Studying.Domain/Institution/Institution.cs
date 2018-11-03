using System;
using System.Collections.Generic;
using Studying.Domain.Core;
using Studying.Domain.Graduation;
using Studying.Domain.Student;

namespace Studying.Domain.Institution
{
    public abstract class Institution : Entity<Guid>, IInstitution
    {
        protected Institution(Guid id) : base(id)
        {
        }

        public abstract Guid InstitutionType { get; }
        public abstract IReadOnlyCollection<IStudent> Students { get; }
        public abstract void Enter(IStudent student);
        public abstract IReadOnlyCollection<IStudent> Graduate();
        
        protected IGraduationCertificate CreateCertificate()
        {
            return new GraduationCertificate(Id, InstitutionType);
        }
        
        private class GraduationCertificate : IGraduationCertificate
        {
            public Guid Id { get; }
            public Guid Type { get; }

            public GraduationCertificate(Guid id, Guid type)
            {
                Id = id;
                Type = type;
            }
        }
    }
}