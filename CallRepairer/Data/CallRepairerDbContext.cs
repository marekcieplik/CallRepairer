using CallRepairer.Entities;
using Microsoft.EntityFrameworkCore;

namespace CallRepairer.Data;

public class CallRepairerDbContext : DbContext
{
    public DbSet<Repairer> Repairers => Set<Repairer>();

    public DbSet<Workplace> Workplaces => Set<Workplace>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("StorageAppDb");
    }
}
