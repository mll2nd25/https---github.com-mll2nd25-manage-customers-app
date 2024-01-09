using Microsoft.EntityFrameworkCore;
using Customers.API.DAL.Entity;

namespace Customers.API.DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}