using System;

namespace dotnet.service.lifetime.Services
{
    public class ScopedServiceExample
    {
        private readonly Guid id = Guid.NewGuid();

        public string getScopedGuid()
        {
            return id.ToString();
        }
    }
    
}