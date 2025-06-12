namespace DockAllocator.Domain.models{
    public class DockAllocation{

        public int Id { get; set; }
        public int DockId { get; set; }
        public Dock Dock { get; set; } = default!;
        public int TruckId { get; set; }
        public Truck Truck { get; set; } = default!;
        public DateTime ScheduledArrival { get; set; }
        public DateTime? ActualArrival { get; set; }
        public string Status { get; set; } = "Scheduled"; // Scheduled, Arrived, Cancelled, etc.
    }
}