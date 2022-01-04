using Net6.NuGet.PoC.Services.Interfaces;

namespace Net6.NuGet.PoC.Services
{
    public class TestServiceImplementation : ITestService
    {
        public string Base64Encode(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                throw new ArgumentNullException(nameof(bytes));
            }

            return Convert.ToBase64String(bytes);
        }
    }
}
