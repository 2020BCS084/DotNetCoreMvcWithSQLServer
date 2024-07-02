using Microsoft.EntityFrameworkCore;
using BulkyWeb.Models;

namespace BulkyWeb.Data
{
    
    public class ApplicationDbContext : DbContext  //this DbContext class is a root class for the entity framework.
    {
        //We have to register this method to Program.cs file.
        //following method is used to create a database in sql server.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //following method is used to create table in the database.
        public DbSet<Category> Categories { get; set; }     //here Category is the Model name and Categories is the table name for the Model table.

        //following method is used to add data to table : 
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(                         //run=> add-migration SeedCategoryTable to store the data into table.
                    new Category{ Id = 1, Name = "Action", DisplayOrder = 1 },
                    new Category{ Id = 2, Name = "SciFi", DisplayOrder = 2 },
                    new Category { Id = 3, Name = "History", DisplayOrder = 3 }
            );
        }
    }
}