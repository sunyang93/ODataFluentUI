namespace OdataFluentUI.Controllers;

[Route("odata")]
public class InventoryController : ODataController
{
    private readonly WarehouseContext _warehouseContext;
    public InventoryController(WarehouseContext warehouseContext)
    {
        ArgumentNullException.ThrowIfNull(warehouseContext, nameof(warehouseContext));
        _warehouseContext = warehouseContext;
        #region 创建种子数据
        if (!_warehouseContext.Inventorys.Any())
        {
            foreach (var material in _warehouseContext.Materials.Take(10))
            {
                for (var i = 100; i < 200; i++)
                {
                    var inventory = new Inventory()
                    {
                        MaterialId = material.MaterialId,
                        Batch = $"Batch-{i}",
                        Number = (ulong)i,
                        IsAvailable = true,
                    };
                    _warehouseContext.Inventorys.Add(inventory);
                }
            }
            _warehouseContext.SaveChanges();
        }
        #endregion
    }

    [EnableQuery]
    [HttpGet("Inventory")]
    public IActionResult GetAllInventorys()
    {
        return Ok(_warehouseContext.Inventorys);
    }

    [EnableQuery]
    [HttpGet("Inventory(Batch={key1},MaterialId={key2})")]
    public IActionResult GetOneInventory(string key1, int key2)
    {
        var Inventorys = _warehouseContext.Inventorys.Where(p => p.MaterialId == key2 && p.Batch == key1);

        if (!Inventorys.Any())
        {
            return NotFound();
        }

        return Ok(SingleResult.Create(Inventorys));
    }

    [HttpPost("Inventory")]
    public async Task<IActionResult> CreateInventory([FromBody] Inventory Inventory)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _warehouseContext.Inventorys.Add(Inventory);
        await _warehouseContext.SaveChangesAsync();

        return CreatedAtAction("GetOneInventory", new { key1 = Inventory.MaterialId, key2 = Inventory.Batch }, Inventory);
    }

    [HttpPatch("Inventory(Batch={key1},MaterialId={key2})")]
    public async Task<IActionResult> UpdateInventoryPartially(string key1, int key2,
        [FromBody] Delta<Inventory> patch)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var currentInventory = await _warehouseContext.Inventorys
            .FirstOrDefaultAsync(p => p.MaterialId == key2 && p.Batch == key1);

        if (currentInventory == null)
        {
            return NotFound();
        }

        patch.Patch(currentInventory);
        currentInventory.UpdateTime = DateTime.UtcNow;
        await _warehouseContext.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("Inventory(Batch={key1},MaterialId={key2})")]
    public async Task<IActionResult> DeleteInventory(string key1, int key2)
    {
        var currentInventory = await _warehouseContext.Inventorys
            .FirstOrDefaultAsync(p => p.MaterialId == key2 && p.Batch == key1);

        if (currentInventory == null)
        {
            return NotFound();
        }

        _warehouseContext.Inventorys.Remove(currentInventory);
        await _warehouseContext.SaveChangesAsync();

        return NoContent();
    }
}
