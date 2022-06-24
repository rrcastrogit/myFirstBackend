using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using myFirstBackend.Models.DataModels;
namespace myFirstBackend.DataAccess
{
    public class UniversityDBContext:DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options):base(options)
        {

        }
        //TODO: Add DbSets (Tables )
        public DbSet<User>? Users { get; set; }
    }
}
