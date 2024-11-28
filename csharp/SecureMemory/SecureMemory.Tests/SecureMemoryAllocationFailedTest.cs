namespace GoDaddy.Asherah.SecureMemory.Tests;

[ExcludeFromCodeCoverage]
[Collection("Logger Fixture collection")]
public class SecureMemoryAllocationFailedTest
{
    private const string Message = "Failure message";

    [Fact]
    private void ProtectedMemoryAllocationFailedConstructorTest()
    {
        SecureMemoryAllocationFailedException exception = new SecureMemoryAllocationFailedException(Message);
        Assert.Equal(Message, exception.Message);
    }
}
