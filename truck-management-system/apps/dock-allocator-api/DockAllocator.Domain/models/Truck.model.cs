namespace DockAllocator.Domain.models
{
    public class Truck
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; } = default!;
        public string DriverName { get; set; } = default!;
        public string Status { get; set; } = "Idle"; // Idle, In Transit, Unloading, etc.
        public ICollection<DockAllocation> DockAllocations { get; set; } = new List<DockAllocation>();
    }
}