using AutoMapper;

namespace RabbidsIncubator.LightApi.Infrastructure.MongoDb.MappingProfiles
{
    internal class MongoDbMappingProfiles : Profile
    {
        public override string ProfileName
        {
            get { return "RabbidsIncubatorLightApiInfrastructureMongoDbMongoDbMappingProfiles"; }
        }

        public MongoDbMappingProfiles()
        {
            CreateMap<Entities.Device, Domain.Models.DeviceModel>();
            CreateMap<Domain.Models.DeviceModel, Entities.Device>();

            CreateMap<Entities.VirtualLan, Domain.Models.VirtualLanModel>();
            CreateMap<Domain.Models.DeviceModel, Entities.VirtualLan>();
        }
    }
}
