using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.EntityFrameworkCore;
using OdataFluentUI.Data.Models;

namespace OdataFluentUI.Controllers;

[Route("odata")]
[ApiController]
public class WorkOrderController : ControllerBase
{
    private readonly Adventureworks2019Context _adventureworks2019Context;
    public WorkOrderController(Adventureworks2019Context adventureworks2019Context)
    {
        _adventureworks2019Context = adventureworks2019Context ?? throw new ArgumentNullException(nameof(adventureworks2019Context));
    }

    [EnableQuery(PageSize =20)]
    [HttpGet("WorkOrders")]
    public IActionResult GetAllWorkOrders()
    {
        return Ok(_adventureworks2019Context.WorkOrders);
    }

    [EnableQuery]
    [HttpGet("WorkOrders({key})")]
    public IActionResult GetOneWorkOrder(int key)
    {
        var workOrders = _adventureworks2019Context.WorkOrders.Where(p => p.WorkOrderID == key);

        if (!workOrders.Any())
        {
            return NotFound();
        }

        return Ok(SingleResult.Create(workOrders));
    }

    [HttpPost("WorkOrders")]
    public async Task<IActionResult> CreateWorkOrder([FromBody] WorkOrder workOrder)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _adventureworks2019Context.WorkOrders.Add(workOrder);
        await _adventureworks2019Context.SaveChangesAsync();

        return Created("",workOrder);
    }

    [HttpPatch("WorkOrders({key})")]
    public async Task<IActionResult> UpdateWorkOrderPartially(int key,
        [FromBody] Delta<WorkOrder> patch)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // find a matching record store
        var currentWorkOrder = await _adventureworks2019Context.WorkOrders
            .FirstOrDefaultAsync(p => p.WorkOrderID == key);

        // if the record store isn't found, return NotFound
        if (currentWorkOrder == null)
        {
            return NotFound();
        }

        patch.Patch(currentWorkOrder);
        await _adventureworks2019Context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("WorkOrders({key})")]
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
