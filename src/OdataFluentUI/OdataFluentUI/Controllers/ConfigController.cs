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

    #region EntityType
    /// <summary>
    /// 新建EntityTypeConfig
    /// </summary>
    /// <param name="entityTypeConfigs">EntityTypeConfigs</param>
    /// <returns></returns>
    [HttpPost("entityTypeConfigs")]
    public ActionResult<EntityTypeConfig> CreateEntityTypeConfigs(List<EntityTypeConfigModel> entityTypeConfigs)
    {
        try
        {
            List<EntityTypeConfig> _EntityTypeConfigs = _mapper.Map<List<EntityTypeConfig>>(entityTypeConfigs);
            _documentRepository.CreateEntityTypeConfigs(_EntityTypeConfigs);
            return CreatedAtAction("GetEntityTypeConfigs", new { ids = _EntityTypeConfigs.Select(d => d.Id) }, _EntityTypeConfigs);
        }
        catch (LiteException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// 更新EntityTypeConfig
    /// </summary>
    /// <param name="id">id</param>
    /// <param name="entityTypeConfig">EntityTypeConfig</param>
    /// <returns></returns>
    [HttpPut("entityTypeConfigs/{id}")]
    public IActionResult UpdateEntityTypeConfig(string id, EntityTypeConfigModel entityTypeConfig)
    {
        EntityTypeConfig _EntityTypeConfig = _documentRepository.GetEntityTypeConfig(id);
        _mapper.Map(entityTypeConfig, _EntityTypeConfig);
        if (_documentRepository.UpdateEntityTypeConfig(_EntityTypeConfig))
        {
            return NoContent();
        }
        else
        {
            return StatusCode(500);
        }
    }

    /// <summary>
    /// 查询EntityTypeConfig
    /// </summary>
    /// <param name="id">id</param>
    /// <returns></returns>
    [HttpGet("entityTypeConfigs/{id}", Name = "GetEntityTypeConfig")]
    public ActionResult<EntityTypeConfig> GetEntityTypeConfig(string id)
    {
        EntityTypeConfig EntityTypeConfig = _documentRepository.GetEntityTypeConfig(id);
        return Ok(EntityTypeConfig);
    }

    /// <summary>
    /// 查询EntityTypeConfigs
    /// </summary>
    /// <param name="ids">ids</param>
    /// <returns></returns>
    [HttpGet("entityTypeConfigs", Name = "GetEntityTypeConfigs")]
    public ActionResult<List<EntityTypeConfig>> GetEntityTypeConfigs([FromQuery] List<string> ids)
    {
        List<EntityTypeConfig> EntityTypeConfigs = _documentRepository.GetEntityTypeConfigs(ids);
        return Ok(EntityTypeConfigs);
    }

    /// <summary>
    /// 删除EntityTypeConfig
    /// </summary>
    /// <param name="id">id</param>
    /// <returns></returns>
    [HttpDelete("entityTypeConfigs/{id}")]
    public IActionResult DeleteEntityTypeConfig(string id)
    {
        if (_documentRepository.DeleteEntityTypeConfig(id))
        {
            return NoContent();
        }
        else
        {
            return StatusCode(500);
        }
    }
    #endregion

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

