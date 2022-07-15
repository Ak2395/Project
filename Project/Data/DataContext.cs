

namespace Project.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer()
                /*.UseSqlServer("Server=.\\192.168.1.8,1433;Database=Project;Trusted_Connection=true;");*/
                .UseSqlServer("Data Source=192.168.1.8,1433;Initial Catalog = project; Integrated Security = True;");
            /*.UseSqlServer("User Id=sample;" + "Password=1234;" + "Server=192.168.1.8,1433;" + "Trusted_Connection=true;" + "Database=project;" + "Connection Timeout=10;");*/
        }

        public DbSet<User> DbUsers => Set<User>();
    }

}
