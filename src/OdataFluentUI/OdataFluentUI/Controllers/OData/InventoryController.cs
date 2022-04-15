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
            foreach (Material material in _warehouseContext.Materials.Take(10))
            {
                for (int i = 100; i < 200; i++)
                {
                    Inventory inventory = new ()
                    {
                        MaterialId = material.MaterialId,
                        Batch = $"Batch-{i}",
                        Number = (ulong)i,
                    };
                    _warehouseContext.Inventorys.Add(inventory);
                }
            }
            _warehouseContext.SaveChanges();
        }
        #endregion
    }

    [EnableQuery]
    [HttpGet("Inventories")]
    public IActionResult GetAllInventorys()
    {
        return Ok(_warehouseContext.Inventorys);
    }

    [EnableQuery]
    [HttpGet("Inventory(Batch={key1},MaterialId={key2})")]
    public IActionResult GetOneInventory(string key1, int key2)
    {
        IQueryable<Inventory>? inventorys = _warehouseContext.Inventorys.Include(d=>d.Material).Where(p => p.MaterialId == key2 && p.Batch == key1);
        if (!inventorys.Any())
        {
            return NotFound();
        }

        return Ok(SingleResult.Create(inventorys));
    }

    [EnableQuery]
    [HttpGet("Inventories(Batch={key1},MaterialId={key2})/Material")]
    public IActionResult GetOneInventoryMaterial(string key1, int key2)
    {
        Inventory? inventory = _warehouseContext.Inventorys.Include(d => d.Material).FirstOrDefault(p => p.MaterialId == key2 && p.Batch == key1);
        if (inventory == null)
        {
            return NotFound();
        }

        return Ok(inventory.Material);
    }

    [HttpPost("Inventories")]
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

    [HttpPatch("Inventories(Batch={key1},MaterialId={key2})")]
    public async Task<IActionResult> UpdateInventoryPartially(string key1, int key2,
        [FromBody] Delta<Inventory> patch)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        Inventory? currentInventory = await _warehouseContext.Inventorys
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

    [HttpDelete("Inventories(Batch={key1},MaterialId={key2})")]
    public async Task<IActionResult> DeleteInventory(string key1, int key2)
    {
        Inventory? currentInventory = await _warehouseContext.Inventorys
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
