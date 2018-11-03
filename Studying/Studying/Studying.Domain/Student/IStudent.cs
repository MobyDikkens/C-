using Studying.Domain.Graduation;

namespace Studying.Domain.Student
{
    public interface IStudent
    {
        void Study();
        void Graduate(IGraduationCertificate certificate);
    }
}