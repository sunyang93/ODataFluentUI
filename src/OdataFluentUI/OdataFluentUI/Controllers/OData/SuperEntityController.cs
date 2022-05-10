namespace OdataFluentUI.Controllers;

[Route("odata")]
[ApiExplorerSettings(GroupName = "odata")]
public class SuperEntityController : ODataController
{
    private readonly WarehouseContext _warehouseContext;
    public SuperEntityController(WarehouseContext warehouseContext)
    {
        ArgumentNullException.ThrowIfNull(warehouseContext, nameof(warehouseContext));
        _warehouseContext = warehouseContext;
    }

    [EnableQuery]
    [HttpGet("SuperEntities")]
    public IActionResult GetAllSuperEntities()
    {
        return Ok(_warehouseContext.SuperEntities);
    }

    [EnableQuery]
    [HttpGet("SuperEntities({key})")]
    public IActionResult GetOneSuperEntity(int key)
    {
        IQueryable<SuperEntity> superEntities = _warehouseContext.SuperEntities.Where(p => p.SuperEntityId == key);

        if (!superEntities.Any())
        {
            return NotFound();
        }

        return Ok(SingleResult.Create(superEntities));
    }

    [HttpPost("SuperEntities")]
    public async Task<IActionResult> CreateSuperEntity([FromBody] SuperEntity superEntity)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _warehouseContext.SuperEntities.Add(superEntity);
        await _warehouseContext.SaveChangesAsync();

        return CreatedAtAction("GetOneSuperEntity", new { key = superEntity.SuperEntityId }, superEntity);
    }

    [HttpPatch("SuperEntities({key})")]
    public async Task<IActionResult> UpdateSuperEntityPartially(int key,
        [FromBody] Delta<SuperEntity> patch)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        SuperEntity currentSuperEntity = await _warehouseContext.SuperEntities
            .FirstOrDefaultAsync(p => p.SuperEntityId == key);

        if (currentSuperEntity == null)
        {
            return NotFound();
        }

        patch.Patch(currentSuperEntity);
        currentSuperEntity.UpdateTime = DateTime.UtcNow;
        await _warehouseContext.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("SuperEntities({key})")]
    public async Task<IActionResult> DeleteSuperEntity(int key)
    {
        SuperEntity currentSuperEntity = await _warehouseContext.SuperEntities
            .FirstOrDefaultAsync(p => p.SuperEntityId == key);

        if (currentSuperEntity == null)
        {
            return NotFound();
        }

        _warehouseContext.SuperEntities.Remove(currentSuperEntity);
        await _warehouseContext.SaveChangesAsync();

        return NoContent();
    }
}
