using AutoMapper;

namespace OdataFluentUI.Profiles
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<EntitySetConfigModel, EntitySetConfig>();
            CreateMap<EnumTypeConfigModel, EnumTypeConfig>();
        }
    }
}
