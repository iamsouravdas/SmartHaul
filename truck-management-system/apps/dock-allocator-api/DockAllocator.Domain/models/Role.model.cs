namespace DockAllocator.Domain.models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        // A User Can have multiple roles
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}