namespace OdataFluentUI.Controllers;

[Route("odata")]
[ApiController]
public class WorkOrderController : ControllerBase
{
    private readonly Adventureworks2019Context _adventureworks2019Context;
    public WorkOrderController(Adventureworks2019Context adventureworks2019Context)
    {
        ArgumentNullException.ThrowIfNull(adventureworks2019Context, nameof(adventureworks2019Context));
        _adventureworks2019Context = adventureworks2019Context;
    }

    [EnableQuery(PageSize =20)]
    [HttpGet("WorkOrder")]
    public IActionResult GetAllWorkOrders()
    {
        return Ok(_adventureworks2019Context.WorkOrders);
    }

    [EnableQuery]
    [HttpGet("WorkOrder({key})")]
    public IActionResult GetOneWorkOrder(int key)
    {
        var workOrders = _adventureworks2019Context.WorkOrders.Where(p => p.WorkOrderID == key);

        if (!workOrders.Any())
        {
            return NotFound();
        }

        return Ok(SingleResult.Create(workOrders));
    }

    [HttpPost("WorkOrder")]
    public async Task<IActionResult> CreateWorkOrder([FromBody] WorkOrder workOrder)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _adventureworks2019Context.WorkOrders.Add(workOrder);
        await _adventureworks2019Context.SaveChangesAsync();

        return CreatedAtAction("GetOneWorkOrder", workOrder, new { key=workOrder.WorkOrderID});
    }

    [HttpPatch("WorkOrder({key})")]
    public async Task<IActionResult> UpdateWorkOrderPartially(int key,
        [FromBody] Delta<WorkOrder> patch)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var currentWorkOrder = await _adventureworks2019Context.WorkOrders
            .FirstOrDefaultAsync(p => p.WorkOrderID == key);

        if (currentWorkOrder == null)
        {
            return NotFound();
        }

        patch.Patch(currentWorkOrder);
        await _adventureworks2019Context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("WorkOrder({key})")]
    public async Task<IActionResult> DeleteWorkOrder(int key)
    {
        var currentWorkOrder = await _adventureworks2019Context.WorkOrders
            .FirstOrDefaultAsync(p => p.WorkOrderID == key);

        if (currentWorkOrder == null)
        {
            return NotFound();
        }

        _adventureworks2019Context.WorkOrders.Remove(currentWorkOrder);
        await _adventureworks2019Context.SaveChangesAsync();

        return NoContent();
    }
}
