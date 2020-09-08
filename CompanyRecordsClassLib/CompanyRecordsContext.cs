using Microsoft.EntityFrameworkCore;

namespace CompanyRecordsClassLib
{
    //the context class implements DBContext interface
    class CompanyRecordsContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (LocalDB)\MSSQLLocalDB; Database = DemoCompanyRecords; Trusted_Connection = True;");
        }
    }
}
