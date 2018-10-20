namespace Smartphone.Domain.Entities.OperationSystem
{
    public class Android : OperationSystem
    {
        private const string AndroidName = "Android";
        
        public Android(
            string version) : base(AndroidName, version)
        {
        }
    }
}