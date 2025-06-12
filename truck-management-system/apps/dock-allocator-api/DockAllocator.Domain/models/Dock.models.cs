namespace  DockAllocator.Domain.models
{
    public class Dock{
        public int Id {get; set;}
        public string Name {get; set;} = default!;
        public bool IsOccupied {get; set;}
        public int WarehouseId { get; set; }
        // A Dock can only belong to one warehouse
        public Warehouse Warehouse { get; set; } = default!;
        //A Dock can have mulitple Dock Allocations
        public ICollection<DockAllocation> Allocations { get; set; } = new List<DockAllocation>();
    }
}