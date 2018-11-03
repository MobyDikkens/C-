using Studing.Domain.Graduation;

namespace Studing.Domain.Student
{
    public interface IStudent
    {
        void Study();
        void Graduate(IGraduationCertificate certificate);
    }
}