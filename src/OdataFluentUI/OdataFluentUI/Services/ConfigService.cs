using Grpc.Core;

namespace GrpcService.Services
{
    public class ConfigService : Config.ConfigBase
    {
        private readonly IDocumentRepository _documentRepository;
        private readonly IMapper _mapper;
        public ConfigService(IDocumentRepository documentRepository, IMapper mapper)
        {
            _documentRepository = documentRepository;
            _mapper = mapper;
        }

        public override Task<GrpcEnumTypeConfigResponse> CreateEnumTypeConfigs(GrpcEnumTypeConfigRequest request,
             ServerCallContext context)
        {
            List<EnumTypeConfig> _enumTypeConfigs = _mapper.Map<List<EnumTypeConfig>>(request.Items);
            var enumTypeConfigs = _documentRepository.CreateEnumTypeConfigs(_enumTypeConfigs);
            var response = new GrpcEnumTypeConfigResponse();
            response.Items.AddRange(_mapper.Map<IEnumerable<GrpcEnumTypeConfig>>(enumTypeConfigs));
            return Task.FromResult(response);
        }

        public override Task<GrpcEnumTypeConfig> GetEnumTypeConfig(Query query,
            ServerCallContext context)
        {
            EnumTypeConfig enumTypeConfig = _documentRepository.GetEnumTypeConfig(query.Id);
            var response = _mapper.Map<GrpcEnumTypeConfig>(enumTypeConfig);
            return Task.FromResult(response);
        }
    }
}
