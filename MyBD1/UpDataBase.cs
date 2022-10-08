using MyFirstBd1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBD1
{
    public static class UpDataBase
    {
        public static void UpdateDataBase(MybDbContext context, Thread thread1)
        {

            while (thread1.IsAlive)
            {
                context.SaveChanges();
                Console.WriteLine("DATA_BASE is update!");
                Thread.Sleep(2000);
                
                
            }
                
            
            
        }
    }
}
