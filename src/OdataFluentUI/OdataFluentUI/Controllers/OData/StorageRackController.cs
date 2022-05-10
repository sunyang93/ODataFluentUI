namespace OdataFluentUI.Controllers;

[Route("odata")]
[ApiExplorerSettings(GroupName = "odata")]
public class StorageRackController : ODataController
{
    private readonly WarehouseContext _warehouseContext;
    public StorageRackController(WarehouseContext warehouseContext)
    {
        ArgumentNullException.ThrowIfNull(warehouseContext, nameof(warehouseContext));
        _warehouseContext = warehouseContext;
    }

    [EnableQuery]
    [HttpGet("StorageRacks")]
    public IActionResult GetAllStorageRacks()
    {
        return Ok(_warehouseContext.StorageRacks);
    }

    [EnableQuery]
    [HttpGet("StorageRacks({key})")]
    public IActionResult GetOneStorageRack(int key)
    {
        IQueryable<StorageRack> storageRacks = _warehouseContext.StorageRacks.Include(d=>d.CargoSpaces).Where(p => p.StorageRackId == key);

        if (!storageRacks.Any())
        {
            return NotFound();
        }

        return Ok(SingleResult.Create(storageRacks));
    }

    [HttpPost("StorageRacks")]
    public async Task<IActionResult> CreateStorageRack([FromBody] StorageRack storageRack)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _warehouseContext.StorageRacks.Add(storageRack);
        await _warehouseContext.SaveChangesAsync();

        return CreatedAtAction("GetOneStorageRack", new { key = storageRack.StorageRackId }, storageRack);
    }

    [HttpPatch("StorageRacks({key})")]
    public async Task<IActionResult> UpdateStorageRackPartially(int key,
        [FromBody] Delta<StorageRack> patch)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        StorageRack currentStorageRack = await _warehouseContext.StorageRacks
            .FirstOrDefaultAsync(p => p.StorageRackId == key);

        if (currentStorageRack == null)
        {
            return NotFound();
        }

        patch.Patch(currentStorageRack);
        currentStorageRack.UpdateTime = DateTime.UtcNow;
        await _warehouseContext.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("StorageRacks({key})")]
    public async Task<IActionResult> DeleteStorageRack(int key)
    {
        StorageRack currentStorageRack = await _warehouseContext.StorageRacks
            .FirstOrDefaultAsync(p => p.StorageRackId == key);

        if (currentStorageRack == null)
        {
            return NotFound();
        }

        _warehouseContext.StorageRacks.Remove(currentStorageRack);
        await _warehouseContext.SaveChangesAsync();

        return NoContent();
    }
}
