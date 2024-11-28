namespace GoDaddy.Asherah.SecureMemory.Tests;

[ExcludeFromCodeCoverage]
[Collection("Logger Fixture collection")]
public class SecureMemoryExceptionTest
{
    private const string Message = "Failure message";

    [Fact]
    private void SecureMemoryExceptionConstructorTest()
    {
        SecureMemoryException exception = new SecureMemoryException(Message);
        Assert.Equal(Message, exception.Message);
    }
}
