using Microsoft.EntityFrameworkCore;
using YounathanAStudentDirectoryDatabase.Models;

namespace YounathanAStudentDirectoryDatabase.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students {get; set;}
    }
