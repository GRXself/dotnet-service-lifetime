using System;
using dotnet.service.lifetime.Controllers.DTO;

namespace dotnet.service.lifetime.Services
{
    public class SingletonWithTransientExample
    {
        private readonly TransientServiceExample transient;

        public SingletonWithTransientExample(TransientServiceExample transient)
        {
        this.transient = transient;
        }

        private readonly Guid id = Guid.NewGuid();
            
            public void setGroupGuid(GuidGroup guidGroup)
            {
                guidGroup.TransientIdInSingleton = transient.getTransientGuid();
                guidGroup.SingletonId = id.ToString();
            }
        }
    
}