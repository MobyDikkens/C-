using System;
using System.Collections.Generic;
using Studying.Domain.Graduation;
using Studying.Domain.Studying;

namespace Studying.Domain.Student
{
    public class Student : IStudent
    {
        private List<IGraduationCertificate> _graduationCertificates;

        public IReadOnlyCollection<IGraduationCertificate> Certificates => _graduationCertificates;       
        public int TotalPoints { get; private set; }

        public void Study(IStudying studying)
        {
            if(studying == null)
                throw new ArgumentNullException(nameof(studying));

            studying.GetStudingStategy()();
            TotalPoints += studying.Profit;
            
            _graduationCertificates = new List<IGraduationCertificate>();
        }

        public void Graduate(IGraduationCertificate certificate)
        {
            if(certificate == null)
                throw new ArgumentNullException(nameof(certificate));
            
            _graduationCertificates.Add(certificate);
        }
    }
}