using System;

namespace dotnet.service.lifetime.Services
{
    public class TransientServiceExample
    {
        private readonly Guid id = Guid.NewGuid();

        public string getTransientGuid()
        {
            return id.ToString();
        }
    }
    
}