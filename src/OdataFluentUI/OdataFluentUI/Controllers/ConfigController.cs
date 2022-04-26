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

    #region EnumType
    /// <summary>
    /// 新建EnumTypeConfig
    /// </summary>
    /// <param name="enumTypeConfigs">EnumTypeConfigs</param>
    /// <returns></returns>
    [HttpPost("enumTypeConfigs")]
    public ActionResult<EnumTypeConfig> CreateEnumTypeConfigs(List<EnumTypeConfigModel> enumTypeConfigs)
    {
        try
        {
            List<EnumTypeConfig> _EnumTypeConfigs = _mapper.Map<List<EnumTypeConfig>>(enumTypeConfigs);
            _documentRepository.CreateEnumTypeConfigs(_EnumTypeConfigs);
            return CreatedAtAction("GetEnumTypeConfigs", new { ids = _EnumTypeConfigs.Select(d => d.Id) }, _EnumTypeConfigs);
        }
        catch (LiteException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// 更新EnumTypeConfig
    /// </summary>
    /// <param name="id">id</param>
    /// <param name="enumTypeConfig">EnumTypeConfig</param>
    /// <returns></returns>
    [HttpPut("enumTypeConfigs/{id}")]
    public IActionResult UpdateEnumTypeConfig(string id, EnumTypeConfigModel enumTypeConfig)
    {
        EnumTypeConfig _EnumTypeConfig = _documentRepository.GetEnumTypeConfig(id);
        _mapper.Map(enumTypeConfig, _EnumTypeConfig);
        if (_documentRepository.UpdateEnumTypeConfig(_EnumTypeConfig))
        {
            return NoContent();
        }
        else
        {
            return StatusCode(500);
        }
    }

    /// <summary>
    /// 查询EnumTypeConfig
    /// </summary>
    /// <param name="id">id</param>
    /// <returns></returns>
    [HttpGet("enumTypeConfigs/{id}", Name = "GetEnumTypeConfig")]
    public ActionResult<EnumTypeConfig> GetEnumTypeConfig(string id)
    {
        EnumTypeConfig EnumTypeConfig = _documentRepository.GetEnumTypeConfig(id);
        return Ok(EnumTypeConfig);
    }

    /// <summary>
    /// 查询EnumTypeConfigs
    /// </summary>
    /// <param name="ids">ids</param>
    /// <returns></returns>
    [HttpGet("enumTypeConfigs", Name = "GetEnumTypeConfigs")]
    public ActionResult<List<EnumTypeConfig>> GetEnumTypeConfigs([FromQuery] List<string> ids)
    {
        List<EnumTypeConfig> EnumTypeConfigs = _documentRepository.GetEnumTypeConfigs(ids);
        return Ok(EnumTypeConfigs);
    }

    /// <summary>
    /// 删除EnumTypeConfig
    /// </summary>
    /// <param name="id">id</param>
    /// <returns></returns>
    [HttpDelete("enumTypeConfigs/{id}")]
    public IActionResult DeleteEnumTypeConfig(string id)
    {
        if (_documentRepository.DeleteEnumTypeConfig(id))
        {
            return NoContent();
        }
        else
        {
            return StatusCode(500);
        }
    }
    #endregion

    #region EntitySet
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
    #endregion
}

