namespace DockAllocator.Domain.models{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PasswordHashed { get; set; } = default!;
        public int RoleId { get; set; }
            public Role Role { get; set; } = default!;
    }
}