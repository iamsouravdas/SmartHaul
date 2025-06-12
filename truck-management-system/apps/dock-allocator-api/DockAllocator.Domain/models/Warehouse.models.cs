namespace DockAllocator.Domain.models{
    public class Warehouse{
        public int Id{get; set;}
        public string Name {get; set;} = default!;
        public string Location {get; set;} = default!;
        // A Warehouse can have multiple Docks
        public ICollection<Dock> Docks { get; set; } = new List<Dock>();
    }
}