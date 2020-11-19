using System;
using dotnet.service.lifetime.Controllers.DTO;

namespace dotnet.service.lifetime.Services
{
    public class TransientWithScopedExample
    {
        private readonly ScopedServiceExample scoped;

        public TransientWithScopedExample(ScopedServiceExample scoped)
        {
        this.scoped = scoped;
        }

        private readonly Guid id = Guid.NewGuid();

        public void setGuidGroup(GuidGroup guidgroup)
        {
            guidgroup.TransientId = id.ToString();
            guidgroup.ScopedIdInTransient = scoped.getScopedGuid();
        }
    }
    
}