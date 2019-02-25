using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BollywoodMovieApp.NewDb
{
    public class BollywoodMovieContext : DbContext
    {
        public DbSet<BollywoodMovietbl> BollywoodMovies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.BollywoodMovieApp.NewDb;Trusted_Connection=True;");
        }
    }

    public class BollywoodMovietbl
    {
        [Key]
        public int BollywoodMovieId { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string category_name { get; set; }
    }


}
