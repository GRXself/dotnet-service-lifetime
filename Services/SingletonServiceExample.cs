using System;

namespace dotnet.service.lifetime.Services
{
    public class SingletonServiceExample
    {
        private readonly Guid id = Guid.NewGuid();
        
        public string getSingletonGuid()
        {
            return id.ToString();
        }
    }
    
}