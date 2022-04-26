namespace OdataFluentUI.Controllers;

[Route("odata")]
[ApiExplorerSettings(GroupName = "odata")]
public class MaterialController : ODataController
{
    private readonly WarehouseContext _warehouseContext;
    public MaterialController(WarehouseContext warehouseContext)
    {
        ArgumentNullException.ThrowIfNull(warehouseContext, nameof(warehouseContext));
        _warehouseContext = warehouseContext;                         
    }

    [EnableQuery]
    [HttpGet("Materials")]
    public IActionResult GetAllMaterials()
    {
        return Ok(_warehouseContext.Materials);
    }

    [EnableQuery]
    [HttpGet("Materials({key})")]
    public IActionResult GetOneMaterial(int key)
    {
        IQueryable<Material>? Materials = _warehouseContext.Materials.Where(p => p.MaterialId == key);

        if (!Materials.Any())
        {
            return NotFound();
        }

        return Ok(SingleResult.Create(Materials));
    }

    [HttpPost("Materials")]
    public async Task<IActionResult> CreateMaterial([FromBody]Material Material)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _warehouseContext.Materials.Add(Material);
        await _warehouseContext.SaveChangesAsync();

        return CreatedAtAction("GetOneMaterial", new { key = Material.MaterialId }, Material);
    }

    [HttpPatch("Materials({key})")]
    public async Task<IActionResult> UpdateMaterialPartially(int key,
        [FromBody]Delta<Material> patch)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        Material? currentMaterial = await _warehouseContext.Materials
            .FirstOrDefaultAsync(p => p.MaterialId == key);

        if (currentMaterial == null)
        {
            return NotFound();
        }

        patch.Patch(currentMaterial);
        currentMaterial.UpdateTime = DateTime.UtcNow;
        await _warehouseContext.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("Materials({key})")]
    public async Task<IActionResult> DeleteMaterial(int key)
    {
        Material? currentMaterial = await _warehouseContext.Materials
            .FirstOrDefaultAsync(p => p.MaterialId == key);

        if (currentMaterial == null)
        {
            return NotFound();
        }

        _warehouseContext.Materials.Remove(currentMaterial);
        await _warehouseContext.SaveChangesAsync();

        return NoContent();
    }
}
