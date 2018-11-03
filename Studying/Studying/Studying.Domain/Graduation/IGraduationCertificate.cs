using System;
using Studying.Domain.Core;

namespace Studying.Domain.Graduation
{
    public interface IGraduationCertificate : IEntity<Guid>
    {
        Guid Type { get; }
    }
}