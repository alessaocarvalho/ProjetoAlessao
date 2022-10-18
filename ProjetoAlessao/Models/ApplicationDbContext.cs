using Microsoft.EntityFrameworkCore;

namespace ProjetoAlessao.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {

        }
    }
}
