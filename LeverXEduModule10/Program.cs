using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace LeverXEduModule10
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.Migrate();

                var user1 = new User { Name = "Tom", Age = 33 };
                var user2 = new User { Name = "Alice", Age = 26 };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Objects created");

                var users = db.Users.ToList();
                Console.WriteLine("Objects list:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
        }
    }
}
