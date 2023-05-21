using CleanWebAPI.Models.MainModels;
using Microsoft.EntityFrameworkCore;

namespace CleanWebAPI.Models.Context;

public partial class MyPetContext : DbContext
{
    public  MyPetContext()
    {
        Database.EnsureCreated();
    }

    public MyPetContext(DbContextOptions<MyPetContext> options)
        : base(options)
    {
        
    }

    public virtual DbSet<Product> Products { get; set; }

 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
