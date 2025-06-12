using DockAllocator.Domain.models;

public interface ITruckRepository
{
    /// <summary>
    /// Retrieves a truck by warehouse Id.
    /// </summary>
    /// <param name="warehouseId">The ID of the warehouse.</param>
    /// <returns>A task that represents the asynchronous operation, containing the trucks if found.</returns>
    Task<List<Truck>> GetTrucksByWarehouseIdAsync(int warehouseId);

    /// <summary>
    /// Retrieves a truck by its ID.
    /// </summary>
    /// <param name="truckId">The ID of the truck.</param>
    /// <returns>A task that represents the asynchronous operation, containing the truck if found.</returns>
    Task<Truck> GetTruckByIdAsync(int truckId);

    /// <summary>
    /// Retrieves all trucks.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation, containing a list of all trucks.</returns>
    Task<List<Truck>> GetAllTrucksAsync();
}