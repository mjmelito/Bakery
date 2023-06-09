using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public DbSet<Machine> Machines { get; set; }
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<EngineerTag> EngineerTags { get; set; }
    public DbSet<EngineerMachine> EngineerMachine { get; set; }

    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}
