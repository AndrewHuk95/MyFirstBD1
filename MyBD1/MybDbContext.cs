using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstBd1
{
    public class MybDbContext : DbContext
    {
        public MybDbContext() : base("GreatDataBase")
        {

        }
        public DbSet<User> Users { get; set; }
        
    }
}
