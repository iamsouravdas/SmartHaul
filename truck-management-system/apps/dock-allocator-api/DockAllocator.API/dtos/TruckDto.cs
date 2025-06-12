
namespace DockAllocator.API.dtos
{
public class TruckDto
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; } = default!;
        public string DriverName { get; set; } = default!;
        public string Status { get; set; } = "Idle"; // Idle, In Transit, Unloading, etc.
    }
}

