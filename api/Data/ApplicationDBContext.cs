using Microsoft.EntityFrameworkCore;
using DotNetEnv; // Make sure you have the DotNetEnv package installed
using api.Models;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Load environment variables from .env file
                DotNetEnv.Env.Load();

                // Get MySQL connection details from environment variables
                var host = Environment.GetEnvironmentVariable("MYSQL_HOST");
                var port = Environment.GetEnvironmentVariable("MYSQL_PORT");
                var database = Environment.GetEnvironmentVariable("MYSQL_DATABASE");
                var user = Environment.GetEnvironmentVariable("MYSQL_USER");
                var password = Environment.GetEnvironmentVariable("MYSQL_PASSWORD");

                // Construct the connection string
                var connectionString = $"Server={host};Port={port};Database={database};User={user};Password={password}";

                // Configure the context to use MySQL
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }
    }
}
