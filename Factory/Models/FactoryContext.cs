using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {

    public DbSet<Machine> Machines { get; set; }
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<EngineerMachine> JoinEntities { get; set; }
    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}

//  protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//       modelBuilder.Entity<EngineerMachine>()
//       .HasKey(em => new { em.EngineerId, em.MachineId });
      
//       modelBuilder.Entity<EngineerMachine>()
//         .HasOne(m => m.Machine)
//         .WithMany(em => em.JoinEntities)
//         .HasForeignKey(mi => mi.MachineId);

//       modelBuilder.Entity<EngineerMachine>()
//         .HasOne(m => m.Engineer)
//         .WithMany(em => em.JoinEntities)
//         .HasForeignKey(ei => ei.EngineerId);
//     }
