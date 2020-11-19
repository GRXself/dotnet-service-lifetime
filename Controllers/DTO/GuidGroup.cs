namespace dotnet.service.lifetime.Controllers.DTO
{
    public class GuidGroup
    {
        public string TransientId { get; set; }
        public string TransientIdInScope { get; set; }
        public string TransientIdInSingleton { get; set; }
        public string ScopedId { get; set; }
        public string ScopedIdInTransient { get; set; }
        public string SingletonId { get; set; }
        public string SingletonIdInScoped { get; set; }
    }
}