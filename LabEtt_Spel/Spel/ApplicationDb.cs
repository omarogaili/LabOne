using Microsoft.EntityFrameworkCore;
namespace Spel;

public class ApplicationDb : DbContext
{
    public DbSet<User> users { get; set; } // crate an object for the users collection
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
     optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Spel_LabEtt"); //can be changed if u have another server. 
 }
}