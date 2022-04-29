namespace OdataFluentUI.Controllers;

[Route("api/configs")]
[ApiController]
[ApiExplorerSettings(GroupName = "document")]
public class ConfigController : ControllerBase
{
    private const string _entityTypeConfigRoute = "entityTypeConfigs";
    private const string _enumTypeConfigRoute = "enumTypeConfigs";
    private const string _entitySetConfigRoute = "entitySetConfigs";
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
    [HttpPost(_entityTypeConfigRoute)]
    public ActionResult<EntityTypeConfig> CreateEntityTypeConfigs(List<EntityTypeConfigModel> entityTypeConfigs)
    {
        try
        {
            List<EntityTypeConfig> _entityTypeConfigs = _mapper.Map<List<EntityTypeConfig>>(entityTypeConfigs);
            _documentRepository.CreateEntityTypeConfigs(_entityTypeConfigs);
            return CreatedAtAction("GetEntityTypeConfigs", new { ids = _entityTypeConfigs.Select(d => d.Id) }, _entityTypeConfigs);
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
    [HttpPut(_entityTypeConfigRoute+"/{id}")]
    public IActionResult UpdateEntityTypeConfig(string id, EntityTypeConfigModel entityTypeConfig)
    {
        EntityTypeConfig _entityTypeConfig = _documentRepository.GetEntityTypeConfig(id);
        _mapper.Map(entityTypeConfig, _entityTypeConfig);
        if (_documentRepository.UpdateEntityTypeConfig(_entityTypeConfig))
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
    [HttpGet(_entityTypeConfigRoute+"/{id}", Name = "GetEntityTypeConfig")]
    public ActionResult<EntityTypeConfig> GetEntityTypeConfig(string id)
    {
        EntityTypeConfig entityTypeConfig = _documentRepository.GetEntityTypeConfig(id);
        return Ok(entityTypeConfig);
    }

    /// <summary>
    /// 查询EntityTypeConfigs
    /// </summary>
    /// <param name="ids">ids</param>
    /// <returns></returns>
    [HttpGet(_entityTypeConfigRoute, Name = "GetEntityTypeConfigs")]
    public ActionResult<List<EntityTypeConfig>> GetEntityTypeConfigs([FromQuery] List<string> ids)
    {
        if (ids == null || ids.Count == 0)
        {
            List<EntityTypeConfig> entityTypeConfigs = _documentRepository.GetAllEntityTypeConfigs();
            return Ok(entityTypeConfigs);
        }
        else
        {
            List<EntityTypeConfig> entityTypeConfigs = _documentRepository.GetEntityTypeConfigs(ids);
            return Ok(entityTypeConfigs);
        }
    }

    /// <summary>
    /// 查询所有的EntityTypeConfigs视图
    /// </summary>
    /// <returns></returns>
    [HttpGet(_entityTypeConfigRoute+"/viewModel")]
    public ActionResult<List<EntityTypeConfigViewModel>> GetAllEntityTypeConfigsViewModel()
    {
        List<EntityTypeConfig> entityTypeConfigs = _documentRepository.GetAllEntityTypeConfigs();
        List<EntityTypeConfigViewModel> viewModels = _mapper.Map<List<EntityTypeConfigViewModel>>(entityTypeConfigs);
        return Ok(viewModels);
    }

    /// <summary>
    /// 根据名称查询EntityTypeConfig
    /// </summary>
    /// <param name="name">名称</param>
    /// <returns></returns>
    [HttpGet(_entityTypeConfigRoute+ "/name({name})")]
    public ActionResult<EntityTypeConfig> QueryEntityTypeConfigByName(string name)
    {
        EntityTypeConfig entityTypeConfig =_documentRepository.QueryEntityTypeConfigByName(name); 
        if(entityTypeConfig == null)
        {
            return NotFound();
        }
        return Ok(entityTypeConfig);
    }

    /// <summary>
    /// 删除EntityTypeConfig
    /// </summary>
    /// <param name="id">id</param>
    /// <returns></returns>
    [HttpDelete(_entityTypeConfigRoute+"/{id}")]
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
    [HttpPost(_enumTypeConfigRoute)]
    public ActionResult<EnumTypeConfig> CreateEnumTypeConfigs(List<EnumTypeConfigModel> enumTypeConfigs)
    {
        try
        {
            List<EnumTypeConfig> _enumTypeConfigs = _mapper.Map<List<EnumTypeConfig>>(enumTypeConfigs);
            _documentRepository.CreateEnumTypeConfigs(_enumTypeConfigs);
            return CreatedAtAction("GetEnumTypeConfigs", new { ids = _enumTypeConfigs.Select(d => d.Id) }, _enumTypeConfigs);
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
    [HttpPut(_enumTypeConfigRoute+"/{id}")]
    public IActionResult UpdateEnumTypeConfig(string id, EnumTypeConfigModel enumTypeConfig)
    {
        EnumTypeConfig _enumTypeConfig = _documentRepository.GetEnumTypeConfig(id);
        _mapper.Map(enumTypeConfig, _enumTypeConfig);
        if (_documentRepository.UpdateEnumTypeConfig(_enumTypeConfig))
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
    [HttpGet(_enumTypeConfigRoute+"/{id}", Name = "GetEnumTypeConfig")]
    public ActionResult<EnumTypeConfig> GetEnumTypeConfig(string id)
    {
        EnumTypeConfig enumTypeConfig = _documentRepository.GetEnumTypeConfig(id);
        return Ok(enumTypeConfig);
    }

    /// <summary>
    /// 查询EnumTypeConfigs
    /// </summary>
    /// <param name="ids">ids</param>
    /// <returns></returns>
    [HttpGet(_enumTypeConfigRoute, Name = "GetEnumTypeConfigs")]
    public ActionResult<List<EnumTypeConfig>> GetEnumTypeConfigs([FromQuery] List<string> ids)
    {
        if (ids == null || ids.Count == 0)
        {
            List<EnumTypeConfig> enumTypeConfigs = _documentRepository.GetAllEnumTypeConfigs();
            return Ok(enumTypeConfigs);
        }
        else
        {
            List<EnumTypeConfig> enumTypeConfigs = _documentRepository.GetEnumTypeConfigs(ids);
            return Ok(enumTypeConfigs);
        }
    }

    /// <summary>
    /// 查询EnumTypeConfig视图
    /// </summary>
    /// <returns></returns>
    [HttpGet(_enumTypeConfigRoute+"/viewModel")]
    public ActionResult<List<EnumTypeConfigViewModel>> GetAlEnumTypeConfigsViewModel()
    {
        List<EnumTypeConfig> enumTypeConfigs = _documentRepository.GetAllEnumTypeConfigs();
        List<EnumTypeConfigViewModel> viewModels = _mapper.Map<List<EnumTypeConfigViewModel>>(enumTypeConfigs);
        return Ok(viewModels);
    }

    /// <summary>
    /// 根据名称查询EnumTypeConfig
    /// </summary>
    /// <param name="name">名称</param>
    /// <returns></returns>
    [HttpGet(_enumTypeConfigRoute + "/name({name})")]
    public ActionResult<EnumTypeConfig> QueryEnumTypeConfigByName(string name)
    {
        EnumTypeConfig enumTypeConfig = _documentRepository.QueryEnumTypeConfigByName(name);
        if (enumTypeConfig == null)
        {
            return NotFound();
        }
        return Ok(enumTypeConfig);
    }

    /// <summary>
    /// 删除EnumTypeConfig
    /// </summary>
    /// <param name="id">id</param>
    /// <returns></returns>
    [HttpDelete(_enumTypeConfigRoute+"/{id}")]
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
    [HttpPost(_entitySetConfigRoute)]
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
    [HttpPut(_entitySetConfigRoute+"/{id}")]
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
    [HttpGet(_entitySetConfigRoute+"/{id}",Name = "GetEntitySetConfig")]
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
    [HttpGet(_entitySetConfigRoute, Name = "GetEntitySetConfigs")]
    public ActionResult<List<EntitySetConfig>> GetEntitySetConfigs([FromQuery]List<string> ids)
    {
        if (ids == null || ids.Count == 0)
        {
            List<EntitySetConfig> entitySetConfigs = _documentRepository.GetAllEntitySetConfigs();
            return Ok(entitySetConfigs);
        }
        else
        {
            List<EntitySetConfig> entitySetConfigs = _documentRepository.GetEntitySetConfigs(ids);
            return Ok(entitySetConfigs);
        }
    }

    /// <summary>
    /// 查询EntitySetConfig视图
    /// </summary>
    /// <returns></returns>
    [HttpGet(_entitySetConfigRoute+"/viewModel")]
    public ActionResult<List<EnumTypeConfigViewModel>> GetAlEntitySetConfigsViewModel()
    {
        List<EntitySetConfig> entitySetConfigs = _documentRepository.GetAllEntitySetConfigs();
        List<EntitySetConfigViewModel> viewModels = _mapper.Map<List<EntitySetConfigViewModel>>(entitySetConfigs);
        return Ok(viewModels);
    }

    /// <summary>
    /// 根据名称查询EntitySetConfig
    /// </summary>
    /// <param name="name">名称</param>
    /// <returns></returns>
    [HttpGet(_entitySetConfigRoute + "/name({name})")]
    public ActionResult<EntitySetConfig> QueryEntitySetConfigByName(string name)
    {
        EntitySetConfig entitySetConfig = _documentRepository.QueryEntitySetConfigByName(name);
        if (entitySetConfig == null)
        {
            return NotFound();
        }
        return Ok(entitySetConfig);
    }

    /// <summary>
    /// 删除EntitySetConfig
    /// </summary>
    /// <param name="id">id</param>
    /// <returns></returns>
    [HttpDelete(_entitySetConfigRoute+"/{id}")]
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

