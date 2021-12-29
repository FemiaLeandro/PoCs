namespace IoC.PoC.Web.Services
{
    public class TestService : ITestService
    {
        private const string TEST_STRING = "TEST";

        public string GetTestString()
        {
            return TEST_STRING;
        }
    }
}
