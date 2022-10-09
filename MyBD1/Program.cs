using MyBD1;
using System;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MyFirstBd1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new MybDbContext())
            {
                Thread thread1 = new Thread(() => CreateUser.CreateNewUser(context));
                Parallel.Invoke(
                    () =>
                    {
                        //need = thread1.IsAlive;
                        thread1.Start();
                    },
                    () =>
                    {
                        UpDataBase.UpdateDataBase(context, thread1);
                    });

                Console.WriteLine("done");
                Console.WriteLine(context.Users.Count());
                foreach (var item in context.Users)
                {
                    Console.WriteLine($"{item.Name}\t{item.Age}");
                }
                

                var a = context.Users.ToList().OrderBy(x => x.Age);
                
                Console.ReadLine();
                



            }
        }
       




    }
}