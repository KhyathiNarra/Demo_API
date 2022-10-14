using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Demo_API.Model
{
    public class EmpDBContext : DbContext
    { 
        public EmpDBContext(DbContextOptions<EmpDBContext>options):base(options)
        {

        }
        public DbSet<Employee>? Employees { get; set; }


    }
}
