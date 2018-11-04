using System;
using System.Collections.Generic;
using Studying.Domain.Institution;
using Studying.Domain.Student;
using Studying.Domain.Studying;

namespace Studying.Application.Institutions
{
    public class OxfordSchool : Institution
    {
        public OxfordSchool(
            Guid id, 
            IReadOnlyCollection<IStudying> studyingStrategies, 
            int daysInTerm, 
            Predicate<IStudent> graduationPredicate) 
                : base(id, studyingStrategies, daysInTerm, graduationPredicate)
        {
        }
    }
}