using System;
using System.Collections.Generic;
using Studying.Domain.Graduation;
using Studying.Domain.Studying;

namespace Studying.Domain.Student
{
    public interface IStudent
    {
        int TotalPoints { get; }
        void Study(IStudying studying);
        void Graduate(IGraduationCertificate certificate);
        IReadOnlyCollection<IGraduationCertificate> Certificates { get; }
    }
}