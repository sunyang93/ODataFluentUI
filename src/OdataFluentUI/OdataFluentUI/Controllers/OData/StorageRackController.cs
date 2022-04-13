namespace OdataFluentUI.Controllers;

[Route("odata")]
public class StorageRackController : ODataController
{
    private readonly WarehouseContext _warehouseContext;
    public StorageRackController(WarehouseContext warehouseContext)
    {
        ArgumentNullException.ThrowIfNull(warehouseContext, nameof(warehouseContext));
        _warehouseContext = warehouseContext;
    }

    [EnableQuery]
    [HttpGet("StorageRack")]
    public IActionResult GetAllStorageRacks()
    {
        return Ok(_warehouseContext.StorageRacks);
    }

    [EnableQuery]
    [HttpGet("StorageRack({key})")]
    public IActionResult GetOneStorageRack(int key)
    {
        IQueryable<StorageRack>? storageRacks = _warehouseContext.StorageRacks.Where(p => p.StorageRackId == key);

        if (!storageRacks.Any())
        {
            return NotFound();
        }

        return Ok(SingleResult.Create(storageRacks));
    }

    [HttpPost("StorageRack")]
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

    [HttpPatch("StorageRack({key})")]
    public async Task<IActionResult> UpdateStorageRackPartially(int key,
        [FromBody] Delta<StorageRack> patch)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        StorageRack? currentStorageRack = await _warehouseContext.StorageRacks
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

    [HttpDelete("StorageRack({key})")]
    public async Task<IActionResult> DeleteStorageRack(int key)
    {
        StorageRack? currentStorageRack = await _warehouseContext.StorageRacks
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
