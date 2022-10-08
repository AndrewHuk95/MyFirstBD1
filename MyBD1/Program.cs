using MyBD1;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MyFirstBd1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //using (var context = new MybDbContext())
            //{
            //    var user1 = new User();
            //    context.Users.Add(user1);
            //    var user2 = new User();
            //    context.Users.Add(user2);
            //    var user3 = new User();
            //    context.Users.Add(user3);
            //    var user4 = new User();
            //    context.Users.Add(user4);
            //    //context.SaveChanges();
            //    Console.WriteLine(context.Users.);
            //}

            //var nameGenerator = new NameGenerator();
            //var user = new CreateUser();
            //user.CreateUsers.Add(user);
            //var user2 = new CreateUser();
            //user.CreateUsers.Add(user2);
            //const int MaxUsers = 10;
            //var addNewUser = true;
            //using (var context = new MybDbContext())
            //{
            //    do
            //    {

            //        //var user = new User();
            //        //context.Users.Add(user);
            //        CreateUser.CreateNewUser(context);
            //        if (context.Users.Count() >= MaxUsers)
            //        {
            //            addNewUser = false;
            //            Console.WriteLine("is full");
            //        }
            //        SaveDataBase(context);
            //        Thread.Sleep(5000);



            //    } while (addNewUser);


            //}
            using (var context = new MybDbContext())
            {
                //working
                //Console.WriteLine("Start");
                //CreateUser.CreateNewUser(context);
                //Console.WriteLine("---------");
                //CreateUser.CreateNewUser(context);
                //Console.WriteLine("saveBD");
                //context.SaveChanges();
                //Console.WriteLine("Bd is save!");

                //07/10/22
                //var need = true;
                //Thread thread1 = new Thread(() => UpDataBase.UpdateDataBase(context, need));
                //thread1.Start();
                //var i = 0;

                //while (i <= 10)
                //{
                //    CreateUser.CreateNewUser(context);
                //    i++;
                //    if (i >= 10)
                //    {
                //        //thread1.Interrupt();
                //        need = false;
                //        thread1.Join();
                //    }

                //}
                //Console.WriteLine("Done");

                //08/07/22


                //Thread thread1 = new Thread(() => CreateUser.CreateNewUser(context));
                //Parallel.Invoke(
                //    () =>
                //    {
                //        //need = thread1.IsAlive;
                //        thread1.Start();
                //    },
                //    () =>
                //    {
                //        UpDataBase.UpdateDataBase(context, thread1);
                //    });

                Console.WriteLine("done");
                Console.WriteLine(context.Users.Count());
                foreach (var item in context.Users)
                {
                    Console.WriteLine($"{item.Name}\t{item.Age}");
                }
                var a = context.Users.ToList().OrderBy(x => x.Age);
                foreach (var item in a)
                {
                    Console.WriteLine(item.Name);
                }
                Console.ReadLine();
                



            }
        }
        //static async void SaveDataBase(MybDbContext x)
        //{
        //    await Task.Run(() => x.SaveChanges());
        //}




    }
}