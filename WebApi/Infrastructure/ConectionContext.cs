using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Infrastructure;

public class ConectionContext : DbContext
{
    public ConectionContext(DbContextOptions<ConectionContext> option) : base(option)
    {
    }

    public DbSet<Employee> Employees { get; set; }
}

