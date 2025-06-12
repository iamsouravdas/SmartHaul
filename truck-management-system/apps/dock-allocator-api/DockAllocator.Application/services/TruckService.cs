using DockAllocator.Domain.models;

public class TruckService
{
    private readonly ITruckRepository _truckRepository;

    public TruckService(ITruckRepository truckRepository)
    {
        _truckRepository = truckRepository;
    }

    /// <summary>
    /// Retrieves a list of trucks associated with a specific warehouse.
    /// </summary>
    /// <param name="warehouseId">The ID of the warehouse.</param>
    /// <returns>A task that represents the asynchronous operation, containing a list of trucks.</returns>
    public async Task<List<Truck>> GetTrucksByWarehouseIdAsync(int warehouseId)
    {
        return await _truckRepository.GetTrucksByWarehouseIdAsync(warehouseId);
    }

    /// <summary>
    /// Retrieves a truck by its ID.
    /// </summary>
    /// <param name="truckId">The ID of the truck.</param>
    /// <returns>A task that represents the asynchronous operation, containing the truck if found.</returns>

    public async Task<Truck> GetTruckByIdAsync(int truckId)
    {
        return await _truckRepository.GetTruckByIdAsync(truckId);
    }

    /// <summary>
    /// Retrieves all trucks.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation, containing a list of all trucks.</returns>
    public async Task<List<Truck>> GetAllTrucksAsync()
    {
        return await _truckRepository.GetAllTrucksAsync();
    }
}