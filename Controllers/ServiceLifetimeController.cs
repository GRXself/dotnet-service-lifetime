using dotnet.service.lifetime.Controllers.DTO;
using dotnet.service.lifetime.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.service.lifetime.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceLifetimeController
    {
        private readonly TransientServiceExample transient;

        private readonly TransientWithScopedExample transientWithScoped;

        private readonly ScopedServiceExample scoped;

        private readonly ScopedWithTransientExample scopedWithTransient;

        private readonly SingletonServiceExample singleton;

        private readonly SingletonWithScopedExample singletonWithScoped;

        private readonly SingletonWithTransientExample singletonWithTransient;

        public ServiceLifetimeController(TransientServiceExample transient, TransientWithScopedExample transientWithScoped, ScopedServiceExample scoped, ScopedWithTransientExample scopedWithTransient, SingletonServiceExample singleton, SingletonWithScopedExample singletonWithScoped, SingletonWithTransientExample singletonWithTransient)
        {
            this.transient = transient;
            this.transientWithScoped = transientWithScoped;
            this.scoped = scoped;
            this.scopedWithTransient = scopedWithTransient;
            this.singleton = singleton;
            this.singletonWithScoped = singletonWithScoped;
            this.singletonWithTransient = singletonWithTransient;
        }

        [HttpGet]
        [Route("transientScopedSingleton")]
        public GuidGroup GetTSS()
        {
            var guidGroup = new GuidGroup();
            guidGroup.TransientId = transient.getTransientGuid();
            guidGroup.ScopedId = scoped.getScopedGuid();
            guidGroup.SingletonId = singleton.getSingletonGuid();

            return guidGroup;
        }

        [HttpGet]
        [Route("transientInScoped")]
        public GuidGroup GetTransientInScoped()
        {
            var guidGroup = new GuidGroup();
            guidGroup.TransientId = transient.getTransientGuid();
            scopedWithTransient.setGuidGroup(guidGroup);

            return guidGroup;
        }

        [HttpGet]
        [Route("scopedInTransient")]
        public GuidGroup GetScopedInTransient()
        {
            var guidGroup = new GuidGroup();
            transientWithScoped.setGuidGroup(guidGroup);
            guidGroup.ScopedId = scoped.getScopedGuid();

            return guidGroup;
        }

        [HttpGet]
        [Route("scopedInSingleton")]
        public GuidGroup GetScopedInSingleton()
        {
            var guidGroup = new GuidGroup();
            guidGroup.ScopedId = scoped.getScopedGuid();
            singletonWithScoped.setGroupGuid(guidGroup);

            return guidGroup;
        }

        [HttpGet]
        [Route("transientInSingleton")]
        public GuidGroup GetTransientInSingleton()
        {
            var guidGroup = new GuidGroup();
            guidGroup.TransientId = transient.getTransientGuid();
            singletonWithTransient.setGroupGuid(guidGroup);

            return guidGroup;
        }
    }
}