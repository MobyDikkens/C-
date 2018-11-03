using System;
using Studing.Domain.Core;

namespace Studing.Domain.Graduation
{
    public interface IGraduationCertificate : IEntity<Guid>
    {
        Guid Type { get; }
    }
}