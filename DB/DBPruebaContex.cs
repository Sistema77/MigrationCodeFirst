using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class DBPruebaContex : DbContext
    {
        public DBPruebaContex(DbContextOptions<DBPruebaContex> options) 
            : base(options) 
        {
        
        }

        public DbSet<Libros> libro { get; set; }
    }
}