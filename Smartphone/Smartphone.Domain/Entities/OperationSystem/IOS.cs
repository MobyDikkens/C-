namespace Smartphone.Domain.Entities.OperationSystem
{
    public class IOS : OperationSystem
    {
        private const string IOSName = "IOS";
        
        public IOS(
            string version) : base(IOSName, version)
        {
        }
    }
}