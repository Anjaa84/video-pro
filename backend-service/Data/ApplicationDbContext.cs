using Microsoft.EntityFrameworkCore;
using MyBackendService.Models;


namespace BackendService
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options){}
        public DbSet<User> Users {get;set;}
    }
}