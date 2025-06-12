namespace DockAllocator.API.DTOs
{
    public class DockDto
    {
        public int Id { get; set; }
        public string DockNumber { get; set; } = default!;
        public int WarehouseId { get; set; }
    }
}