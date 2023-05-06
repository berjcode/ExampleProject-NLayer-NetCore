,
using ExampleProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ExampleProject.Data.Concrete.Contexts;

public  class ExampleDbContext :DbContext
{

    public DbSet<Product>  Products { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<User> Users { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=berjcode;Initial Catalog =ExampleProjectGİthub;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }

}
