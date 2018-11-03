using System;
using System.Collections.Generic;
using Studing.Domain.Core;
using Studing.Domain.Student;

namespace Studing.Domain.Institution
{
    public interface IInstitution : IEntity<Guid>
    {
        Guid InstitutionType { get; }
        IReadOnlyCollection<IStudent> Students { get; }
        void Enter(IStudent student);
        IReadOnlyCollection<IStudent> Graduate();
    }
}