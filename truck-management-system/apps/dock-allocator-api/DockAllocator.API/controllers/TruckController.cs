using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("smart-haul/dock-allocator/api/[controller]")]

public class TruckController : ControllerBase
{
    private readonly TruckService _truckService;

    public TruckController(TruckService truckService)
    {
        _truckService = truckService ?? throw new ArgumentNullException(nameof(truckService));
    }

    /// <summary>
    /// Retrieves a list of trucks associated with a specific warehouse.
    /// </summary>
    /// <param name="warehouseId">The ID of the warehouse.</param>
    /// <returns>A list of trucks associated with the specified warehouse.</returns>
    [HttpGet("getTruckByWarehouseId/{warehouseId}")]
    public async Task<IActionResult> GetTrucksByWarehouseIdAsync(int warehouseId)
    {
        if (warehouseId <= 0)
        {
            return BadRequest("Warehouse ID must be greater than zero.");
        }
        var trucks = await _truckService.GetTrucksByWarehouseIdAsync(warehouseId);
        return Ok(trucks);
    }


    /// <summary>
    /// Retrieves a truck by its ID.
    /// </summary>
    ///  /// <param name="truckId">The ID of the truck.</param>
    /// /// <returns>The truck with the specified ID, if found.</returns>
    [HttpGet("getTruckById/{truckId}")]
    public async Task<IActionResult> GetTruckByIdAsync(int truckId)
    {
        if (truckId <= 0)
        {
            return BadRequest("Truck ID must be greater than zero.");
        }

        try
        {
            var truck = await _truckService.GetTruckByIdAsync(truckId);
            return Ok(truck);
        }
        catch (KeyNotFoundException)
        {
            return NotFound($"Truck with ID {truckId} not found.");
        }
    }

    [HttpGet("getAllTrucks")]
    public async Task<IActionResult> GetAllTrucksAsync()
    {
        var trucks = await _truckService.GetAllTrucksAsync();
        return Ok(trucks);
    }
}
