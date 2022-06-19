using Microsoft.EntityFrameworkCore;
using PizzaMart.Models;

namespace PizzaMart.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<PizzaOrder> PizzaOrders { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}