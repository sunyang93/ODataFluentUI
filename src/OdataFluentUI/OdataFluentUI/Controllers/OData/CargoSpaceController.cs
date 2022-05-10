namespace OdataFluentUI.Controllers;

[Route("odata")]
[ApiExplorerSettings(GroupName = "odata")]
public class CargoSpaceController : ODataController
{
    private readonly WarehouseContext _warehouseContext;
    public CargoSpaceController(WarehouseContext warehouseContext)
    {
        ArgumentNullException.ThrowIfNull(warehouseContext, nameof(warehouseContext));
        _warehouseContext = warehouseContext;
        #region 创建种子数据
        if (!_warehouseContext.CargoSpaces.Any())
        {
            List<StorageRack> top10StorageRacks = _warehouseContext.StorageRacks.Take(10).ToList();
            foreach (StorageRack storageRack in top10StorageRacks)
            {
                int index=top10StorageRacks.IndexOf(storageRack);
                for (int i = 100; i < 200; i++)
                {
                    CargoSpace cargoSpace = new()
                    {
                        CargoSpaceId = index * 1000 + i,
                        CargoSpaceCode = $"Code-{i}",
                        MaxAvailableSpace=(uint)i,
                        StorageRackId = storageRack.StorageRackId,
                    };
                    _warehouseContext.CargoSpaces.Add(cargoSpace);
                }
            }
            _warehouseContext.SaveChanges();
        }
        #endregion
    }

    [EnableQuery]
    [HttpGet("CargoSpaces")]
    public IActionResult GetAllCargoSpaces()
    {
        return Ok(_warehouseContext.CargoSpaces);
    }  

    [EnableQuery]
    [HttpGet("CargoSpaces({key})")]
    public IActionResult GetOneCargoSpace(int key)
    {
        IQueryable<CargoSpace> cargoSpaces = _warehouseContext.CargoSpaces.Where(p => p.CargoSpaceId == key);

        if (!cargoSpaces.Any())
        {
            return NotFound();
        }

        return Ok(SingleResult.Create(cargoSpaces));
    }

    [EnableQuery]
    [HttpGet("CargoSpaces({key})/StorageRack")]
    public IActionResult GetOneCargoSpaceStorageRack(int key)
    {
        CargoSpace cargoSpaces = _warehouseContext.CargoSpaces.Include(d => d.StorageRack).FirstOrDefault(p => p.CargoSpaceId == key);

        if (cargoSpaces == null)
        {
            return NotFound();
        }

        return Ok(cargoSpaces.StorageRack);
    }

    [HttpPost("CargoSpaces")]
    public async Task<IActionResult> CreateCargoSpace([FromBody] CargoSpace cargoSpace)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _warehouseContext.CargoSpaces.Add(cargoSpace);
        await _warehouseContext.SaveChangesAsync();

        return CreatedAtAction("GetOneCargoSpace", new { key = cargoSpace.CargoSpaceId }, cargoSpace);
    }

    [HttpPatch("CargoSpaces({key})")]
    public async Task<IActionResult> UpdateCargoSpacePartially(int key,
        [FromBody] Delta<CargoSpace> patch)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        CargoSpace currentCargoSpace = await _warehouseContext.CargoSpaces
            .FirstOrDefaultAsync(p => p.CargoSpaceId == key);

        if (currentCargoSpace == null)
        {
            return NotFound();
        }

        patch.Patch(currentCargoSpace);
        currentCargoSpace.UpdateTime = DateTime.UtcNow;
        await _warehouseContext.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("CargoSpaces({key})")]
    public async Task<IActionResult> DeleteCargoSpace(int key)
    {
        CargoSpace currentCargoSpace = await _warehouseContext.CargoSpaces
            .FirstOrDefaultAsync(p => p.CargoSpaceId == key);

        if (currentCargoSpace == null)
        {
            return NotFound();
        }

        _warehouseContext.CargoSpaces.Remove(currentCargoSpace);
        await _warehouseContext.SaveChangesAsync();

        return NoContent();
    }
}
