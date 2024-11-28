using System;

namespace GoDaddy.Asherah.SecureMemory;

public class SecureMemoryConfigurationException : Exception
{
    public SecureMemoryConfigurationException(string message)
        : base(message)
    {
    }
}
