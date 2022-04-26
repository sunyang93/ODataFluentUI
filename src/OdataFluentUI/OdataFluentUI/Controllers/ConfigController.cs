namespace OdataFluentUI.Controllers;

[Route("api/configs")]
[ApiController]
[ApiExplorerSettings(GroupName = "document")]
public class ConfigController : ControllerBase
{
    private readonly IDocumentRepository _documentRepository;
    private readonly IMapper _mapper;
    public ConfigController(IDocumentRepository documentRepository, IMapper mapper)
    {
        _documentRepository = documentRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// 新建EntitySetConfig
    /// </summary>
    /// <param name="entitySetConfigs">EntitySetConfigs</param>
    /// <returns></returns>
    [HttpPost("entitySetConfigs")]
    public ActionResult<EntitySetConfig> CreateEntitySetConfigs(List<EntitySetConfigModel> entitySetConfigs)
    {
        try
        {
            List<EntitySetConfig>  _entitySetConfigs=_mapper.Map<List<EntitySetConfig>>(entitySetConfigs);
            _documentRepository.CreateEntitySetConfigs(_entitySetConfigs);
            return CreatedAtAction("GetEntitySetConfigs", new { ids = _entitySetConfigs.Select(d => d.Id) }, _entitySetConfigs);
        }
        catch(LiteException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// 更新EntitySetConfig
    /// </summary>
    /// <param name="id">id</param>
    /// <param name="entitySetConfig">EntitySetConfig</param>
    /// <returns></returns>
    [HttpPut("entitySetConfigs/{id}")]
    public IActionResult UpdateEntitySetConfig(string id, EntitySetConfigModel entitySetConfig)
    {
        EntitySetConfig _entitySetConfig = _documentRepository.GetEntitySetConfig(id);
        _mapper.Map(entitySetConfig,_entitySetConfig);
        if (_documentRepository.UpdateEntitySetConfig(_entitySetConfig))
        {
            return NoContent();
        }
        else
        {
            return StatusCode(500);
        }
    }

    /// <summary>
    /// 查询EntitySetConfig
    /// </summary>
    /// <param name="id">id</param>
    /// <returns></returns>
    [HttpGet("entitySetConfigs/{id}",Name = "GetEntitySetConfig")]
    public ActionResult<EntitySetConfig> GetEntitySetConfig(string id)
    {
        EntitySetConfig entitySetConfig = _documentRepository.GetEntitySetConfig(id);
        return Ok(entitySetConfig);
    }

    /// <summary>
    /// 查询EntitySetConfigs
    /// </summary>
    /// <param name="ids">ids</param>
    /// <returns></returns>
    [HttpGet("entitySetConfigs", Name = "GetEntitySetConfigs")]
    public ActionResult<List<EntitySetConfig>> GetEntitySetConfigs([FromQuery]List<string> ids)
    {
        List<EntitySetConfig> entitySetConfigs = _documentRepository.GetEntitySetConfigs(ids);
        return Ok(entitySetConfigs);
    }

    /// <summary>
    /// 删除EntitySetConfig
    /// </summary>
    /// <param name="id">id</param>
    /// <returns></returns>
    [HttpDelete("entitySetConfigs/{id}")]
    public IActionResult DeleteEntitySetConfig(string id)
    {
        if(_documentRepository.DeleteEntitySetConfig(id))
        {
            return NoContent();
        }
        else
        {
            return StatusCode(500);
        }
    }
}

