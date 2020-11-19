using System;
using dotnet.service.lifetime.Controllers.DTO;

namespace dotnet.service.lifetime.Services
{
    public class SingletonWithScopedExample
    {
        // private readonly ScopedServiceExample scoped;

        // public SingletonWithScopedExample(ScopedServiceExample scoped)
        // {
        //     this.scoped = scoped;
        // }

        private readonly Guid id = Guid.NewGuid();
        
        public void setGroupGuid(GuidGroup guidGroup)
        {
            // guidGroup.SingletonId = scoped.getScopedGuid();
            guidGroup.SingletonIdInScoped = id.ToString();
        }
    }
    
}