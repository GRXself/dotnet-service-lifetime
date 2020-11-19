using System;
using dotnet.service.lifetime.Controllers.DTO;

namespace dotnet.service.lifetime.Services
{
    public class ScopedWithTransientExample
    {
        private readonly TransientServiceExample transient;

        public ScopedWithTransientExample(TransientServiceExample transient)
        {
            this.transient = transient;
        }

        private readonly Guid id = Guid.NewGuid();

        public void setGuidGroup(GuidGroup guidGroup)
        {
            guidGroup.ScopedId = id.ToString();
            guidGroup.TransientIdInScope = transient.getTransientGuid();
        }
    }
    
}