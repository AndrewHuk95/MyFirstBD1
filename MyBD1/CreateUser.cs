using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstBd1
{
    public static class CreateUser
    {
        public static void CreateNewUser(MybDbContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                var user = new User();
                context.Users.Add(user);
                Console.WriteLine("user is create!");
                Thread.Sleep(1000);
            }
            
        }


    }
}
