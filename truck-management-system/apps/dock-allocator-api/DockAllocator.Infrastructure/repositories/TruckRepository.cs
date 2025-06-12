using DockAllocator.Infrastructure.persistence;
using DockAllocator.Domain.models;
using Microsoft.EntityFrameworkCore;

public class TruckRepository : ITruckRepository
{
    private readonly ApplicationDbContext _context;
    public TruckRepository(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<List<Truck>> GetAllTrucksAsync()
    {
        return await _context.Trucks
            .Include(t => t.DockAllocations).ThenInclude(da => da.Dock)
            .ToListAsync();
    }

    // Retrieves a truck by its ID
    public async Task<Truck> GetTruckByIdAsync(int truckId)
    {
        if (truckId <= 0)
        {
            throw new ArgumentException("Truck ID must be greater than zero.", nameof(truckId));
        }
        return await _context.Trucks.Include(t => t.DockAllocations).ThenInclude(da => da.Dock).FirstOrDefaultAsync(t => t.Id == truckId) ??
               throw new KeyNotFoundException($"Truck with ID {truckId} not found.");
    }

    // Retrieves a list of trucks associated with a specific warehouse
    public async Task<List<Truck>> GetTrucksByWarehouseIdAsync(int warehouseId)
    {
        if (warehouseId <= 0)
        {
            throw new ArgumentException("Warehouse ID must be greater than zero.", nameof(warehouseId));
        }

        return await _context.Trucks
            .Include(t => t.DockAllocations).ThenInclude(da => da.Dock)
            .Where(t => t.DockAllocations.Any(da => da.Dock.WarehouseId == warehouseId))
            .ToListAsync();
    }
    
}