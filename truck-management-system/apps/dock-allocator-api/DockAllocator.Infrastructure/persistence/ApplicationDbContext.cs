using DockAllocator.Domain.models;
using Microsoft.EntityFrameworkCore;

namespace DockAllocator.Infrastructure.persistence
{
/// <summary>
///     Database context class that manages entity-database mappings and relationships for the DockAllocator application.
///     Provides access to the following entities:
///     - Trucks
///     - Docks
///     - DockAllocations
///     - Users
///     - Roles
///     - Warehouses
/// </summary>
/// <remarks>
///     <para>
///         Implements Entity Framework Core configurations for:
///         - Table and column name mappings using snake_case convention
///         - One-to-many relationships between entities
///         - Cascade delete behaviors for related entities
///     </para>
///     <para>
///         Uses fluent API in OnModelCreating to configure:
///         - Database schema mappings
///         - Foreign key relationships
///         - Delete behaviors
///     </para>
/// </remarks>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Dock> Docks { get; set; }
        public DbSet<DockAllocation> DockAllocations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            // Configuring Table Names to match with the database schema
            modelBuilder.Entity<Truck>().ToTable("trucks");
            modelBuilder.Entity<Dock>().ToTable("docks");
            modelBuilder.Entity<DockAllocation>().ToTable("dock_allocations");
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Role>().ToTable("roles");
            modelBuilder.Entity<Warehouse>().ToTable("warehouses");


            // Configuring Column Names to match with the database schema

            // User
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Username).HasColumnName("username");
                entity.Property(e => e.Email).HasColumnName("email");
                entity.Property(e => e.PasswordHashed).HasColumnName("password_hash");
                entity.Property(e => e.RoleId).HasColumnName("role_id");

                /// <summary>
                ///     Navigation property for the user's role.
                /// </summary>
                entity.HasOne(e => e.Role)
                    .WithMany(r => r.Users)
                    .HasForeignKey(e => e.RoleId)
                    .OnDelete(DeleteBehavior.Cascade);
            });


            // Role
            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");

                /// <summary>
                ///     Navigation property for the role's users.
                /// </summary>
                entity.HasMany(e => e.Users)
                    .WithOne(u => u.Role)
                    .HasForeignKey(u => u.RoleId)
                    .OnDelete(DeleteBehavior.Cascade);
            });


            // Warehouse
            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.Location).HasColumnName("location");

                /// <summary>
                ///     Navigation property for the warehuse's docks.
                /// </summary>
                entity.HasMany(e => e.Docks)
                    .WithOne(d => d.Warehouse)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Dock
            modelBuilder.Entity<Dock>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.IsOccupied).HasColumnName("is_occupied");
                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                /// <summary>
                ///     Navigation property for the dock's warehouse.
                /// </summary>
                entity.HasOne(d => d.Warehouse)
                    .WithMany(w => w.Docks)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.Cascade);

                /// <summary>
                ///     Navigation property for the dock's allocations.
                /// </summary>
                entity.HasMany(d => d.Allocations)
                    .WithOne(a => a.Dock)
                    .HasForeignKey(a => a.DockId)
                    .OnDelete(DeleteBehavior.Cascade);
            });


            // DockAllocation
            modelBuilder.Entity<DockAllocation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.DockId).HasColumnName("dock_id");
                entity.Property(e => e.TruckId).HasColumnName("truck_id");
                entity.Property(e => e.ScheduledArrival).HasColumnName("scheduled_arrival");
                entity.Property(e => e.ActualArrival).HasColumnName("actual_arrival");
                entity.Property(e => e.Status).HasColumnName("status");

                /// <summary>
                ///    Navigation property for the allocation's dock.
                /// </summary>

                entity.HasOne(d => d.Dock)
                    .WithMany(d => d.Allocations)
                    .HasForeignKey(d => d.DockId)
                    .OnDelete(DeleteBehavior.Cascade);

                /// <summary>
                ///    Navigation property for the allocation's truck.
                /// </summary>
                entity.HasOne(a => a.Truck)
                    .WithMany(t => t.DockAllocations)
                    .HasForeignKey(a => a.TruckId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Truck
            modelBuilder.Entity<Truck>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.RegistrationNumber).HasColumnName("registration_number");
                entity.Property(e => e.DriverName).HasColumnName("driver_name");
                entity.Property(e => e.Status).HasColumnName("status");

                /// <summary>
                ///     Navigation property for the truck's allocations.
                /// </summary>
                entity.HasMany(t => t.DockAllocations)
                    .WithOne(a => a.Truck)
                    .HasForeignKey(a => a.TruckId)
                    .OnDelete(DeleteBehavior.Cascade);
            });


        }

        


    }
}