namespace OdataFluentUI.Controllers;

[Route("odata")]
public class MaterialController : ODataController
{
    private readonly WarehouseContext _warehouseContext;
    public MaterialController(WarehouseContext warehouseContext)
    {
        ArgumentNullException.ThrowIfNull(warehouseContext, nameof(warehouseContext));
        _warehouseContext = warehouseContext;                         
    }

    [EnableQuery]
    [HttpGet("Material")]
    public IActionResult GetAllMaterials()
    {
        return Ok(_warehouseContext.Materials);
    }

    [EnableQuery]
    [HttpGet("Material({key})")]
    public IActionResult GetOneMaterial(int key)
    {
        var Materials = _warehouseContext.Materials.Where(p => p.MaterialId == key);

        if (!Materials.Any())
        {
            return NotFound();
        }

        return Ok(SingleResult.Create(Materials));
    }

    [HttpPost("Material")]
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

    [HttpPatch("Material({key})")]
    public async Task<IActionResult> UpdateMaterialPartially(int key,
        [FromBody]Delta<Material> patch)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var currentMaterial = await _warehouseContext.Materials
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

    [HttpDelete("Material({key})")]
    public async Task<IActionResult> DeleteMaterial(int key)
    {
        var currentMaterial = await _warehouseContext.Materials
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
