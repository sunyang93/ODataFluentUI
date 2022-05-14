using AutoMapper;
using GrpcService;

namespace OdataFluentUI.Profiles
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<EntityTypeConfigModel, EntityTypeConfig>();
            CreateMap<EntityTypeConfig, EntityTypeConfigViewModel>();
            CreateMap<EnumTypeConfigModel, EnumTypeConfig>();
            CreateMap<EnumTypeConfig, EnumTypeConfigViewModel>();
            CreateMap<EntitySetConfigModel, EntitySetConfig>();
            CreateMap<EntitySetConfig, EntitySetConfigViewModel>();
            // gRPC
            CreateMap<EnumTypeConfig, GrpcEnumTypeConfig>();
            CreateMap<EnumType, GrpcEnumType>();
        }
    }
}
